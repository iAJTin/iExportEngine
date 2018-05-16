
namespace iTin.Export.Writers
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.Composition;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;

    using ComponentModel.Writer;
    using Model;

    /// <inheritdoc />
    /// <summary>
    /// Represents custom writer for SQL script (SQL format). 
    /// </summary>
    [Export(typeof(IWriter))]
    [WriterOptions(Name = "SqlScriptWriter", Author = "iTin", Company = "iTin", Version = 1, Extension = "sql", Description = "SQL Script Writer")]
    public class SqlScriptWriter : BaseWriterDirect
    {
        #region private constant members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string SpaceString = " ";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string SqlComment = "-- ";

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private const string FieldSeparatorString = ", ";
        #endregion

        #region private static readonly members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly string[] SpecialChars = { "\'", "\"" };
        #endregion

        #region private members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StringBuilder _sqlBuilder;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private StringBuilder _sqlErrorBuilder;
        #endregion

        #region private properties

        #region [private] (TableModel) Table: Gets a reference to the model table
        /// <summary>
        /// Gets a reference to the model table.
        /// </summary>
        /// <value>
        /// Reference to the model table.
        /// </value>
        private TableModel Table => Provider.Input.Model.Table;
        #endregion

        #endregion

        #region protected override methods

        #region [protected] {override} (void) Execute(): Generates SQL script
        /// <inheritdoc />
        /// <summary>
        /// Generates <c>SQL</c> script.
        /// </summary>
        protected override void Execute()
        {                
            // initialize
            var items = Table.Fields;

            // get target data
            var rows = Service.RawDataFiltered;

            // sql document result
            _sqlBuilder = new StringBuilder();

            // add script header
            CreateScriptheader();

            // add sentences
            foreach (var row in rows)
            {
                _sqlErrorBuilder = new StringBuilder();

                var values = new Collection<string>();
                foreach (var field in items)
                {
                    field.DataSource = row;
                    var value = field.Value.GetValue(Provider.SpecialChars);
                    var parsedValue = ParseField(value.FormattedValue);
                    values.Add(parsedValue);
                }

                CreateSqlSentence(values);
            }

            // add document to result list.
            Result.Add(Encoding.UTF8.GetBytes(_sqlBuilder.ToString()));
        }
        #endregion

        #endregion

        #region private static methods

        #region [private] {static} (string) ParseField(string): Gets parsed value
        /// <summary>
        /// Gets parsed value.
        /// </summary>
        /// <param name="value">Value to check.</param>
        /// <returns>
        /// Parsed value.
        /// </returns>
        private static string ParseField(string value)
        {
            return SpecialChars.Aggregate(value, (current, specialChar) => current.Replace(specialChar, @"\" + specialChar));
        }
        #endregion

        #endregion

        #region private methods

        #region [private] (void) AddSqlError(string, string): Adds an SQL error
        /// <summary>
        /// Adds an SQL error.
        /// </summary>
        /// <param name="name">Field name.</param>
        /// <param name="value">Field value.</param>
        private void AddSqlError(string name, string value)
        {
            _sqlErrorBuilder.Append(Table.Output.NewLineDelimiter);
            _sqlErrorBuilder.Append(SqlComment);
            _sqlErrorBuilder.Append("Field Value Error");
            _sqlErrorBuilder.Append(Table.Output.NewLineDelimiter);
            _sqlErrorBuilder.Append(SqlComment);
            _sqlErrorBuilder.Append("Field:");
            _sqlErrorBuilder.Append(SpaceString);
            _sqlErrorBuilder.Append(name);
            _sqlErrorBuilder.Append(Table.Output.NewLineDelimiter);
            _sqlErrorBuilder.Append(SqlComment);
            _sqlErrorBuilder.Append("Value:");
            _sqlErrorBuilder.Append(SpaceString);
            _sqlErrorBuilder.Append(value);            
        }                   
        #endregion

        #region [private] (void) CreateScriptheader(): Creates script header
        /// <summary>
        /// Creates script header.
        /// </summary>
        private void CreateScriptheader()
        {
            _sqlBuilder.Append("-- Generated by iTin.Export.Writers.Native.");
            _sqlBuilder.Append(WriterMetadata.Name);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);

            _sqlBuilder.Append("-- Writer:");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append(WriterMetadata.Name);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);

            _sqlBuilder.Append("-- Company:");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append(WriterMetadata.Company);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);

            _sqlBuilder.Append("-- Author:");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append(WriterMetadata.Author);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);

            _sqlBuilder.Append("-- Version:");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append(WriterMetadata.Version);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);
        }
        #endregion

        #region [private] (void) CreateSqlSentence(IEnumerable<string>): Creates the SQL sentence
        /// <summary>
        /// Creates the SQL sentence.
        /// </summary>
        /// <param name="values">The values.</param>
        private void CreateSqlSentence(IEnumerable<string> values)
        {
            _sqlBuilder.Append("INSERT INTO");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append(Table.Name);
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append("VALUES");
            _sqlBuilder.Append(SpaceString);
            _sqlBuilder.Append("(");
            _sqlBuilder.Append(string.Join(FieldSeparatorString, values.ToArray()));
            _sqlBuilder.Append(")");
            _sqlBuilder.Append(Table.Output.NewLineDelimiter);
        }
        #endregion

        #endregion
    }
}
