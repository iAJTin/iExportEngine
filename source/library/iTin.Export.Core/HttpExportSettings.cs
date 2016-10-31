using System.Diagnostics.CodeAnalysis;
using System.Web;
using System.Web.UI;

using iTin.Export.Helper;

namespace iTin.Export
{
    /// <summary>
    /// Specifies a set of features supported on the object" />.
    /// </summary>
    public sealed class HttpExportSettings : ExportSettings
    {
        #region Constructor/s

            #region [public] HttpExportSettings(Page, ExportSettings): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="HttpExportSettings" /> class.
            /// </summary>
            /// <param name="page">Caller page.</param>
            /// <param name="settings">The web display file export.</param>
            [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "0")]
            [SuppressMessage("Microsoft.Design", "CA1062:Validar argumentos de métodos públicos", MessageId = "1")]
            public HttpExportSettings(Page page, ExportSettings settings)
            {
                SentinelHelper.ArgumentNull(page);
                SentinelHelper.ArgumentNull(settings);

                Page = page;
                Settings = settings;
                Response = page.Response;
                BasePath = page.Server.MapPath("~/").ToUpperInvariant();
            }
            #endregion

        #endregion

        #region Public Properties
        
            #region [public] (Page) Page: Gets reference to page caller.
            /// <summary>
            /// Gets reference to page caller.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.Web.UI.Page" /> than represents the page caller.
            /// </value>
            public Page Page { get; private set; }
            #endregion

            #region [public] (HttpResponse) Response: Gets a reference to object used to send Http output to the client.
            /// <summary>
            /// Gets a reference to object used to send Http output to the client.
            /// </summary>
            /// <value>
            /// Used to send Http output to the client.
            /// </value>
            public HttpResponse Response { get; private set; }
            #endregion

            #region [public] (ExportSettings) Settings: Gets a reference to object which contains export settings.
            /// <summary>
            /// Gets a reference to object which contains export settings.
            /// </summary>
            /// <value>
            /// Reference to object which contains export settings.
            /// </value>
            public ExportSettings Settings { get; private set; }
            #endregion
        
        #endregion

        #region Internal properties

            #region [internal] (string) BasePath: Gets root web path.
            /// <summary>
            /// Gets root web path.
            /// </summary>
            /// <value>
            /// A <see cref="T:System.String" /> than contains the root web path.
            /// </value>
            internal string BasePath { get; private set; }
            #endregion

        #endregion
    }
}
