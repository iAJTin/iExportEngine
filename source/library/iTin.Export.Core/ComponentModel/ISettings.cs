
namespace iTin.Export.ComponentModel
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Xml.Linq;

    using Adapters;
    using Model;

    /// <summary>
    /// Declares a generic target.
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// Gets a reference that contains metadata information of this adapter.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.AdapterMetadata"/> that contains the metadata information about this adapter.
        /// </value>
        AdapterMetadata AdapterMetadata { get; }
        
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>XML</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if you can create an <strong>XML</strong>; otherwise, <strong>false</strong>.
        /// </value>
        bool CanCreateInputXml { get; }

        /// <summary>
        /// Gets a value indicating whether this instance can get data table.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance can get data table; otherwise, <strong>false</strong>.
        /// </value>
        bool CanGetDataTable { get; }

        /// <summary>
        /// Gets the input Uri.
        /// </summary>
        /// <value>
        /// Reference to the input file.
        /// </value>
        Uri InputUri { get; }

        /// <summary>
        /// Gets a reference to the data model.
        /// </summary>
        /// <value>
        /// Reference to data model.
        /// </value>
        ExportModel Model { get; }

        /// <summary>
        /// Gets a reference to the resources model.
        /// </summary>
        /// <value>
        /// Reference to resources model.
        /// </value>
        GlobalResourcesModel Resources { get; }

        /// <summary>
        /// Gets an special char array.
        /// </summary>
        /// <value>
        /// Special char array.
        /// </value>
        IEnumerable<char> SpecialChars { get; }

        /// <summary>
        /// Gets a reference to the <see cref="T:System.Data.DataTable" /> object than contains the data this instance.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="T:System.Data.DataTable" /> object.
        /// </returns>
        DataTable ToDataTable();

        /// <summary>
        /// Gets a reference to the <see cref="IEnumerable{XElement}" /> object than contains the data this instance.
        /// </summary>
        /// <returns>
        /// Reference to the <see cref="IEnumerable{XElement}" /> object.
        /// </returns>
        IEnumerable<XElement> ToXml();

        /// <summary>
        /// Add a data model to this target.
        /// </summary>
        /// <param name="model">Data model.</param>
        void SetModel(ExportModel model);

        /// <summary>
        /// Export this target by applying the specified configuration.
        /// </summary>
        /// <param name="settings">Export settings</param>
        void Export(ExportSettings settings);

        /// <summary>
        /// Parse special chars of argument.
        /// </summary>
        /// <param name="value"><see cref="T:System.String" /> for parse.</param>
        /// <returns>
        /// Parsed string.
        /// </returns>
        /// <remarks>
        /// Analyzes the argument <paramref name="value" />, 
        /// replacing special characters by the pattern '_x####_', where: 
        /// ####: Represents ASCII char code in Hexadecimal format.
        /// </remarks>
        string Parse(string value);

        /// <summary>
        /// Sets an special char array to this target.
        /// </summary>
        /// <param name="value">Special chars array.</param>
        void SetSpecialChars(IEnumerable<char> value);

        /// <summary>
        /// Creates the XML source file from.
        /// </summary>
        void CreateInputXml();
    }
}
