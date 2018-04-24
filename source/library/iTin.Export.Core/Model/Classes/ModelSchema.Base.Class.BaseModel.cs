
namespace iTin.Export.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml;
    using System.Xml.Serialization;

    using Helper;

    /// <summary>
    /// Base class for model elements. 
    /// Implements functionality to record and read configuration files.
    /// </summary>
    /// <typeparam name="T">Represents a model node type</typeparam>
    [Serializable]
    public class BaseModel<T>
    {
        #region private static field memebrs
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static XmlSerializer serializer;
        #endregion

        #region private field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertiesModel properties;
        #endregion

        #region public properties

        #region [public] (PropertiesModel) Properties: Gets or sets a reference to user-defined property list for this element
        /// <summary>
        /// Gets or sets a reference to user-defined property list for this element.
        /// </summary>
        /// <value>
        /// List of user-defined properties available for this element.
        /// </value>
        [XmlIgnore]
        [XmlArrayItem("Property", typeof(PropertyModel), IsNullable = false)]
        public PropertiesModel Properties
        {
            get
            {
                if (properties == null)
                {
                    properties = new PropertiesModel();
                }

                foreach (var property in properties)
                {
                    property.SetOwner(properties);
                }

                return properties;
            }
            set => properties = value;
        }
        #endregion

        #endregion

        #region public virtual properties

        #region [public] {virtual} (bool) IsDefault: When overridden in a derived class, gets a value indicating whether this instance contains the default
        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether this instance contains the default.
        /// </summary>
        /// <value>
        /// <strong>true</strong> if this instance contains the default; otherwise, <strong>false</strong>.
        /// </value>
        [Browsable(false)]
        public virtual bool IsDefault => true;
        #endregion

        #endregion

        #region private static properties

        #region [private] {static} (XmlSerializer) Serializer: Gets the serializer reference
        /// <summary>
        /// Gets the serializer reference.
        /// </summary>
        /// <value>
        /// Serializer reference.
        /// </value>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static XmlSerializer Serializer => serializer ?? (serializer = new XmlSerializer(typeof(T)));
        #endregion

        #endregion

        #region public static methods

        #region [public] {static} (T) Deserialize(string): Deserializes the specified Xml
        /// <summary>
        /// Deserializes the specified Xml.
        /// </summary>
        /// <param name="xml">The Xml.</param>
        /// <returns>
        /// T object
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
        public static T Deserialize(string xml)
        {
            SentinelHelper.ArgumentNull(xml);
            
            StringReader reader = null;
            try
            {
                reader = new StringReader(xml);
                return (T)Serializer.Deserialize(XmlReader.Create(reader));
            }
            finally
            {
                if (reader != null)
                {
                    reader.Dispose();
                }
            }
        }
        #endregion

        #region [public] {static} (T) Deserialize(Stream): Deserializes the specified stream
        /// <summary>
        /// Deserializes the specified stream.
        /// </summary>
        /// <param name="stream">Stream to deserialize.</param>
        /// <returns>
        /// T object
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
        public static T Deserialize(Stream stream)
        {
            return (T)Serializer.Deserialize(stream);
        }
        #endregion

        #region [public] {static} (bool) Deserialize(string, out T): Deserializes the specified Xml
        /// <summary>
        /// Deserializes the specified Xml.
        /// </summary>
        /// <param name="xml">Xml to deserialize.</param>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// T object
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes"), SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
        public static bool Deserialize(string xml, out T obj)
        {
            SentinelHelper.ArgumentNull(xml);
            
            Exception exception;
            return Deserialize(xml, out obj, out exception);
        }
        #endregion

        #region [public] {static} (bool) Deserialize(string, out T, out Exception): Deserializes workflow markup into an BaseModel object
        /// <summary>
        /// Deserializes workflow markup into an BaseModel object
        /// </summary>
        /// <param name="xml">string workflow markup to deserialize</param>
        /// <param name="obj">Output BaseModel object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>
        /// <strong>true</strong> if this XmlSerializer can deserialize the object; otherwise, <strong>false</strong>
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes"), SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes"), SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#"), SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#")]
        public static bool Deserialize(string xml, out T obj, out Exception exception)
        {
            SentinelHelper.ArgumentNull(xml);
            
            exception = null;
            obj = default(T);
            try
            {
                obj = Deserialize(xml);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        #endregion

        #region [public] {static} (T) LoadFromFile(string): Loads from file
        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// T object
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
        public static T LoadFromFile(string fileName)
        {
            SentinelHelper.ArgumentNull(fileName);

            FileStream file = null;
            try
            {
                string xmlString;
                file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                using (var reader = new StreamReader(file))
                {
                    file = null;
                    xmlString = reader.ReadToEnd();
                }

                return Deserialize(xmlString);
            }
            finally
            {
                file?.Dispose();
            }
        }
        #endregion

        #region [public] {static} (T) LoadFromUri(Uri): Loads from file
        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="pathUri">Name of the file.</param>
        /// <returns>
        /// T object
        /// </returns>
        public static T LoadFromUri(Uri pathUri)
        {
            SentinelHelper.ArgumentNull(pathUri);

            return LoadFromFile(pathUri.LocalPath);
        }
        #endregion

        #region [public] {static} (bool) LoadFromFile(string, out T): Loads from file
        /// <summary>
        /// Loads from file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <param name="obj">The object.</param>
        /// <returns>
        /// T object
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes")]
        public static bool LoadFromFile(string fileName, out T obj)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            Exception exception;
            return LoadFromFile(fileName, out obj, out exception);
        }
        #endregion

        #region [public] {static} (bool) LoadFromFile(string, out T obj, out Exception): Deserializes xml markup from file into an BaseModel object
        /// <summary>
        /// Deserializes xml markup from file into an BaseModel object
        /// </summary>
        /// <param name="fileName">string xml file to load and deserialize</param>
        /// <param name="obj">Output BaseModel object</param>
        /// <param name="exception">output Exception value if deserialize failed</param>
        /// <returns>
        /// <strong>true</strong> if this XmlSerializer can deserialize the object; otherwise, <strong>false</strong>.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1000:DoNotDeclareStaticMembersOnGenericTypes"), SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes")]
        [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
        [SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "2#")]
        public static bool LoadFromFile(string fileName, out T obj, out Exception exception)
        {
            SentinelHelper.IsTrue(string.IsNullOrEmpty(fileName));

            exception = null;
            obj = default(T);
            try
            {
                obj = LoadFromFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        #endregion

        #endregion

        #region public virtual methods

        #region [public] {virtual} (void) SaveToFile(string): Serializes current BaseModel object into an Xml document
        /// <summary>
        /// Saves to file.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        public virtual void SaveToFile(string fileName)
        {
            SentinelHelper.ArgumentNull(fileName);
            
            try
            {
                var xmlString = Serialize();
                xmlString =
                    xmlString
                        .Replace("<References />", string.Empty)
                        .Replace("<Properties />", string.Empty)
                        .Replace("<Font />", string.Empty)
                        .Replace("<Text />", string.Empty)
                        .Replace("<Lines />", string.Empty)
                        .Replace("<Images />", string.Empty)
                        .Replace("<Margins />", string.Empty)
                        .Replace("<Alignment />", string.Empty)
                        .Replace("<Fixed />", string.Empty)
                        .Replace("<Styles />", string.Empty)
                        .Replace("<Groups />", string.Empty)
                        .Replace("<Negative />", string.Empty)
                        .Replace("<Pattern />", string.Empty)
                        .Replace("<Borders />", string.Empty)
                        .Replace("<Filter />", string.Empty)
                        .Replace("<BlockLines />", string.Empty)
                        .Replace("<Header />", string.Empty)
                        .Replace("<Headers />", string.Empty)
                        .Replace("<Footer />", string.Empty)
                        .Replace("<Charts />", string.Empty)
                        .Replace("<Plots />", string.Empty)
                        .Replace("<Series />", string.Empty)
                        .Replace("<Behaviors />", string.Empty)
                        .Replace("<Aggregate />", string.Empty);
                var xmlFile = new FileInfo(fileName);
                using (var stream = xmlFile.CreateText())
                {
                    stream.Write(xmlString);
                    stream.Flush();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion

        #region [public] {virtual} (bool) SaveToFile(string, out Exception): Serializes current BaseModel object into file
        /// <summary>
        /// Serializes current BaseModel object into file
        /// </summary>
        /// <param name="fileName">Full path of output Xml file</param>
        /// <param name="exception">Output Exception value if failed</param>
        /// <returns>
        /// <strong>true</strong> if can serialize and save into file; otherwise, <strong>false</strong>.
        /// </returns>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes"), SuppressMessage("Microsoft.Design", "CA1021:AvoidOutParameters", MessageId = "1#")]
        public virtual bool SaveToFile(string fileName, out Exception exception)
        {
            SentinelHelper.ArgumentNull(fileName);
            
            exception = null;

            try
            {
                SaveToFile(fileName);
                return true;
            }
            catch (Exception ex)
            {
                exception = ex;
                return false;
            }
        }
        #endregion

        #region [public] {virtual} (string) Serialize(): Serializes current BaseModel object into an Xml document
        /// <summary>
        /// Serializes current BaseModel object into an Xml document.
        /// </summary>
        /// <returns>
        /// string Xml value.
        /// </returns>
        public virtual string Serialize()
        {
            MemoryStream stream = null;
            try
            {
                string xml;
                stream = new MemoryStream();

                Serializer.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);

                using (var streamReader = new StreamReader(stream))
                {
                    stream = null;
                    xml = streamReader.ReadToEnd();
                }

                return xml;
            }
            finally
            {
                if (stream != null)
                {
                    stream.Dispose();
                }
            }
        }
        #endregion

        #endregion

        #region public overrides methods

        #region [public] {override} (string) ToString(): Returns a string that represents the current object
        /// <summary>
        /// Returns a string that represents the current object.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.String" /> that represents the current object.
        /// </returns>
        public override string ToString()
        {
            return !IsDefault 
                ? "Modified" 
                : "Default";
        }

        #endregion

        #endregion

        #region [protected] {virtual} (string) GetValueByReflection(ExportsModel, string): Gets the value by reflection
        /// <summary>
        /// Gets the value by reflection.
        /// </summary>
        /// <param name="model">The model.</param>
        /// <param name="value">The value.</param>
        /// <returns>
        /// A <see cref="T:System.String" /> that contains property, method or raw value.
        /// </returns>
        protected virtual string GetValueByReflection(ExportModel model, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            var isValidStaticResource = RegularExpressionHelper.IsValidStaticResource(value);
            if (!isValidStaticResource)
            {
                return value;
            }


            var assemblies = new List<Assembly>(); // { this.GetType().Assembly };
            var references =  model.Owner.References;
            foreach (var reference in references)
            {
                var assemblyName = reference.Assembly.ToUpperInvariant();
                var hasExtension = assemblyName.EndsWith(".DLL");
                if (!hasExtension)
                {
                    assemblyName = string.Concat(assemblyName, ".DLL");
                }

                var assemblyRelativePath = reference.Path;
                var qualifiedAssemblyPath = string.Concat(assemblyRelativePath, assemblyName);
                var qualifiedAssemblyPathParsed = model.ParseRelativeFilePath(qualifiedAssemblyPath);
                var assembly = Assembly.LoadFile(qualifiedAssemblyPathParsed);
                assemblies.Add(assembly);
            }

            object returnValue;
            var targetValue = value.Replace("{", string.Empty).Replace("}", string.Empty).Trim();
            var bindParts = targetValue.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            var qualifiedFunctionName = bindParts[1].Trim();

            string functionName;
            var classType = this.GetType();
            var qualifiedFunctionParts = qualifiedFunctionName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if (qualifiedFunctionParts.Count() == 1)
            {
                functionName = qualifiedFunctionParts[0].Trim();
            }
            else
            {
                var className = qualifiedFunctionParts[0].Trim();
                functionName = qualifiedFunctionParts[1].Trim();
                var casm = assemblies.Count == 1 ? assemblies.First() : assemblies.Last();
                var assemblyTypes = casm.GetExportedTypes();
                classType = assemblyTypes.FirstOrDefault(cls => cls.Name == className);
            }

            var instanceMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Instance);
            if (instanceMethodInfo != null)
            {
                returnValue = instanceMethodInfo.Invoke(this, null);
            }
            else
            {
                var staticMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Static);
                if (staticMethodInfo != null)
                {
                    returnValue = staticMethodInfo.Invoke(null, null);
                }
                else
                {
                    var instancePropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
                    if (instancePropertyInfo != null)
                    {
                        var instancePropertyGetMethod = instancePropertyInfo.GetGetMethod(true);
                        returnValue = instancePropertyGetMethod.Invoke(this, null);
                    }
                    else
                    {
                        var staticPropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Static | BindingFlags.FlattenHierarchy);
                        var staticPropertyGetMethod = staticPropertyInfo.GetGetMethod(true);
                        returnValue = staticPropertyGetMethod.Invoke(null, null);
                    }
                }
            }

            return returnValue.ToString();
        }
        #endregion
    }
}

//protected virtual string GetValueByReflection(string value)
//{
//    if (string.IsNullOrEmpty(value))
//    {
//        return string.Empty;
//    }

//    var isValidStaticResource = RegularExpressionHelper.IsValidStaticResource(value);
//    if (!isValidStaticResource)
//    {
//        return value;
//    }


//    var assemblies = new List<Assembly>();
//    var references = model.Owner.References;
//    foreach (var reference in references)
//    {
//        var assemblyName = reference.Assembly.ToUpperInvariant();
//        var hasExtension = assemblyName.EndsWith(".DLL");
//        if (!hasExtension)
//        {
//            assemblyName = string.Concat(assemblyName, ".DLL");
//        }

//        var assemblyRelativePath = reference.Path;
//        var qualifiedAssemblyPath = string.Concat(assemblyRelativePath, assemblyName);
//        var qualifiedAssemblyPathParsed = model.ParseRelativeFilePath(qualifiedAssemblyPath);
//        var assembly = Assembly.LoadFile(qualifiedAssemblyPathParsed);
//        assemblies.Add(assembly);
//    }

//    object returnValue;
//    var targetValue = value.Replace("{", string.Empty).Replace("}", string.Empty).Trim();
//    var bindParts = targetValue.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
//    var qualifiedFunctionName = bindParts[1].Trim();

//    string functionName;
//    var classType = this.GetType();
//    var qualifiedFunctionParts = qualifiedFunctionName.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
//    if (qualifiedFunctionParts.Count() == 1)
//    {
//        functionName = qualifiedFunctionParts[0].Trim();
//    }
//    else
//    {
//        var className = qualifiedFunctionParts[0].Trim();
//        functionName = qualifiedFunctionParts[1].Trim();
//        var casm = assemblies.Count == 1 ? assemblies.First() : assemblies.Last();
//        var assemblyTypes = casm.GetExportedTypes();
//        classType = assemblyTypes.FirstOrDefault(cls => cls.Name == className);
//    }

//    var instanceMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Instance);
//    if (instanceMethodInfo != null)
//    {
//        returnValue = instanceMethodInfo.Invoke(this, null);
//    }
//    else
//    {
//        var staticMethodInfo = classType.GetMethod(functionName, BindingFlags.Public | BindingFlags.Static);
//        if (staticMethodInfo != null)
//        {
//            returnValue = staticMethodInfo.Invoke(null, null);
//        }
//        else
//        {
//            var instancePropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Instance);
//            if (instancePropertyInfo != null)
//            {
//                var instancePropertyGetMethod = instancePropertyInfo.GetGetMethod(true);
//                returnValue = instancePropertyGetMethod.Invoke(this, null);
//            }
//            else
//            {
//                var staticPropertyInfo = classType.GetProperty(functionName, BindingFlags.Public | BindingFlags.GetProperty | BindingFlags.Static | BindingFlags.FlattenHierarchy);
//                var staticPropertyGetMethod = staticPropertyInfo.GetGetMethod(true);
//                returnValue = staticPropertyGetMethod.Invoke(null, null);
//            }
//        }
//    }

//    return returnValue.ToString();
//}
