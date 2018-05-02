
namespace iTin.Export.AspNet.Cloud
{
    using System;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Web;

    /// <summary>
    /// Class that encapsules use with <strong><c>OAuth</c></strong> library.
    /// </summary>
    public class OAuth
    {
        #region Field Members
        private readonly OAuthBase authBase;
        #endregion

        #region Constructor/s

            #region [public] OAuth(): Initializes a new instance of the class.
            /// <summary>
            /// Initializes a new instance of the <see cref="iTin.Export.Web.Cloud.OAuth" /> class.
            /// </summary>
            public OAuth()
            {
                authBase = new OAuthBase();
            }

            #endregion

        #endregion

        #region Public Static Methods

            #region [public] (Uri) GetAuthorizeUri(Uri, OAuthToken): Gets the authorize URI.
            /// <summary>
            /// Gets the authorize URI.
            /// </summary>
            /// <param name="baseUri">The base URI.</param>
            /// <param name="requestToken">The request token.</param>
            /// <returns>
            /// A <see cref="T:System.Uri" /> that constains the authorized uri.
            /// </returns>
            public static Uri GetAuthorizeUri(Uri baseUri, OAuthToken requestToken)
            {
                // var queryString = string.Format("oauth_token={0}&oauth_callback={1}", requestToken.Token, DropboxRestApi.DefaultDropboxCallBackUri);
                var queryString = string.Format(CultureInfo.InvariantCulture, "oauth_token={0}", requestToken.Token);
                var authorizeUri = string.Format(CultureInfo.InvariantCulture, "{0}{1}?{2}", baseUri, "oauth/authorize", queryString);
                return new Uri(authorizeUri);
            }
        #endregion

            #region [public] (Uri) GetAuthorizeUriWithCallBack(Uri, OAuthTokenstring string): Gets the authorize URI with callback uri.
            /// <summary>
            /// Gets the authorize URI.
            /// </summary>
            /// <param name="baseUri">The base URI.</param>
            /// <param name="requestToken">The request token.</param>
            /// <param name="callbackUri">The call back URI.</param>
            /// <returns>
            /// A <see cref="T:System.Uri" /> that constains the authorized uri.
            /// </returns>
            public static Uri GetAuthorizeUriWithCallBack(Uri baseUri, OAuthToken requestToken, string callbackUri)
            {
                var queryString = string.Format(CultureInfo.InvariantCulture, "oauth_token={0}&oauth_callback={1}", requestToken.Token, callbackUri);
                var authorizeUri = string.Format(CultureInfo.InvariantCulture, "{0}{1}?{2}", baseUri, "oauth/authorize", queryString);
                return new Uri(authorizeUri);
            }
            #endregion

        #endregion

        #region Public Methods

            #region [public] (OAuthToken) GetRequestToken(Uri, string, string): Returns a new token for a request.
            /// <summary>
            /// Returns a new token for a request.
            /// </summary>
            /// <param name="baseUri">The base URI.</param>
            /// <param name="consumerKey">The consumer key.</param>
            /// <param name="consumerSecret">The consumer secret.</param>
            /// <returns>
            /// Returns a new <see cref="T:iTin.Export.Web.OAuthToken" /> for a request.
            /// </returns>
            public OAuthToken GetRequestToken(Uri baseUri, string consumerKey, string consumerSecret)
            {
                var uri = new Uri(baseUri, new Uri("oauth/request_token", UriKind.Relative));
                uri = SignRequest(uri, consumerKey, consumerSecret);

                var request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Http.Get;

                var response = request.GetResponse();
                var queryString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                var parts = queryString.Split('&');
                var token = parts[1].Substring(parts[1].IndexOf('=') + 1);
                var secret = parts[0].Substring(parts[0].IndexOf('=') + 1);

                return new OAuthToken(token, secret);
            }
            #endregion

            public OAuthToken GetAccessToken(Uri baseUri, string consumerKey, string consumerSecret, OAuthToken requestToken)
            {
                if (requestToken == null)
                {
                    return null;
                }

                var oauthUriPart = new Uri(baseUri, new Uri("oauth/access_token", UriKind.Relative));
                var uri = SignRequest(oauthUriPart, consumerKey, consumerSecret, requestToken);

                var request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = WebRequestMethods.Http.Get;

                var response = request.GetResponse();
                var reader = new StreamReader(response.GetResponseStream());
                var accessToken = reader.ReadToEnd();

                var parts = accessToken.Split('&');
                var token = parts[1].Substring(parts[1].IndexOf('=') + 1);
                var secret = parts[0].Substring(parts[0].IndexOf('=') + 1);

                return new OAuthToken(token, secret);
            }

            public Uri SignRequest(Uri uri, string consumerKey, string consumerSecret, OAuthToken token, string httpMethod)
            {
                var nonce = authBase.GenerateNonce();
                var timestamp = authBase.GenerateTimeStamp();
                string parameters;
                string normalizedUrl;

                var requestToken = token == null ? string.Empty : token.Token;
                var tokenSecret = token == null ? string.Empty : token.Secret;

                var signature = authBase.GenerateSignature(
                    uri,
                    consumerKey,
                    consumerSecret,
                    requestToken,
                    tokenSecret,
                    httpMethod,
                    timestamp,
                    nonce,
                    OAuthBase.SignatureTypes.HMACSHA1,
                    out normalizedUrl,
                    out parameters);

                var requestUri = string.Format(CultureInfo.InvariantCulture, "{0}?{1}&oauth_signature={2}", normalizedUrl, parameters, HttpUtility.UrlEncode(signature));

                return new Uri(requestUri);
            }

        #endregion

        #region Private Methods

            private Uri SignRequest(Uri uri, string consumerKey, string consumerSecret)
            {
                return SignRequest(uri, consumerKey, consumerSecret, null, "GET");
            }

            private Uri SignRequest(Uri uri, string consumerKey, string consumerSecret, OAuthToken token)
            {
                return SignRequest(uri, consumerKey, consumerSecret, token, "GET");
            }

        #endregion
    }
}
