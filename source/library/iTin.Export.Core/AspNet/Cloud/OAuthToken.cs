
namespace iTin.Export.AspNet.Cloud
{
    /// <summary>
    /// Class that encapsulates an authorized token for a valid session in a cloud service.
    /// </summary>
    public class OAuthToken
    {
        #region Constrctor/s

            #region [public] OAuthToken(string, string): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="OAuthToken"/> class.
            /// </summary>
            /// <param name="token">The token.</param>
            /// <param name="secret">The secret.</param>
            public OAuthToken(string token, string secret)
            {
                Token = token;
                Secret = secret;
            }
            #endregion

        #endregion

        #region Public Properties

            #region [public] (string) Token: Gets the token.
            /// <summary>
            /// Gets the token.
            /// </summary>
            /// <value>
            /// The token.
            /// </value>
            public string Token { get; private set; }
            #endregion

            #region [public] (string) Secret: Gets the secret.
            /// <summary>
            /// Gets the secret.
            /// </summary>
            /// <value>
            /// The secret.
            /// </value>
            public string Secret { get; private set; }            
            #endregion

        #endregion
    }
}
