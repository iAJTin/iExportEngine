using System.Collections.Generic;
using System.Diagnostics;

using iTin.Export.Model;

namespace iTin.Export.ComponentModel
{
    /// <summary>
    /// La clase <see cref="FieldValueInformationCache"/> representa la caché de descripciones disponibles por claves.
    /// </summary>
    class FieldValueInformationCache
    {
        #region field members
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly object Padlock = new object();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static volatile FieldValueInformationCache _cacheInstance;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IDictionary<BaseDataFieldModel, FieldValueInformation> _fieldValueDictionary;
        #endregion

        #region constructor/s

            #region [private] FieldValueInformationCache(): Inicializa una nueva instancia de la clase.
            /// <summary>
            /// Inicializa una nueva instancia de la clase <see cref="FieldValueInformationCache"/>.
            /// </summary>
            private FieldValueInformationCache()
            {
                _fieldValueDictionary = new Dictionary<BaseDataFieldModel, FieldValueInformation>();
            }
            #endregion

        #endregion

        #region public methods

            public FieldValueInformation Get(BaseDataFieldModel field, IEnumerable<char> specialChars)
            {
                if (!_fieldValueDictionary.ContainsKey(field))
                {
                    _fieldValueDictionary.Add(field, FieldValueInformationFactory.Create(field, specialChars));
                }

                return _fieldValueDictionary[field];
            }

        #endregion

        #region public static methods

            #region [public] {static} (FieldValueInformationCache) Cache: Obtiene una referencia a la caché de descripciones disponibles.
            /// <summary>
            /// Obtiene una referencia a la caché de descripciones disponibles.
            /// </summary>
            /// <value>Colección de descripciones disponibles.</value>
            public static FieldValueInformationCache Cache
            {
                get
                {
                    if (_cacheInstance != null)
                    {
                        return _cacheInstance;
                    }

                    lock (Padlock)
                    {
                        if (_cacheInstance == null)
                        {
                            _cacheInstance = new FieldValueInformationCache();
                        }
                    }

                    return _cacheInstance;                    
                }
            }
            #endregion

        #endregion
    }
}
