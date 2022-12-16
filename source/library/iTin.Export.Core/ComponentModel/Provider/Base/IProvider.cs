﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

namespace iTin.Export.ComponentModel.Provider
{
    using Input;

    /// <summary>
    /// Declares a generic provider.
    /// </summary>
    public interface IProvider
    {        
        /// <summary>
        /// Gets a value indicating whether you can create an <strong>Xml</strong> file from the current instance of the object.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if you can create an <strong>Xml</strong>; otherwise, <strong>false</strong>.
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
        /// Gets a reference to the input data model.
        /// </summary>
        /// <value>
        /// Reference to data model.
        /// </value>
        InputDataModel Input { get; }

        /// <summary>
        /// Gets a reference that contains the metadata information of this provider.
        /// </summary>
        /// <value>
        /// A <see cref="T:iTin.Export.ComponentModel.Provider.ProviderOptionsMetadata"/> that contains the metadata information about this provider.
        /// </value>
        ProviderOptionsMetadata ProviderMetadata { get; }

        /// <summary>
        /// Gets the input Uri.
        /// </summary>
        /// <value>
        /// Reference to the input file.
        /// </value>
        Uri InputUri { get; }

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
        /// Add an input data model to this adapter.
        /// </summary>
        /// <param name="model">Data model.</param>
        void SetInputDataModel(InputDataModel model);

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
        /// Sets an special char array to this provider.
        /// </summary>
        /// <param name="value">Special chars array.</param>
        void SetSpecialChars(IEnumerable<char> value);

        /// <summary>
        /// Creates the <b>Xml</b> source file from.
        /// </summary>
        void CreateInputXml();
    }
}
