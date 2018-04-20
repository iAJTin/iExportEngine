
namespace iTin.Export.Helper
{
    using System.Text.RegularExpressions;

    /// <summary> 
    /// Static class than contains methods for regular expressions. http://regexhero.net/tester/
    /// </summary>
    public static class RegularExpressionHelper
    {
        /// <summary>
        /// Determines whether <paramref name="value" /> is valid ip address.
        /// </summary>
        /// <param name="value">Ip address to check.</param>
        /// <returns>
        /// <strong>true</strong> if ip address is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidIpAddress(string value)
        {
            SentinelHelper.ArgumentNull(value);
            SentinelHelper.IsTrue(value.Length > 15);

            var val = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");

            return val.IsMatch(value);
        }

        /// <summary>
        /// Determines whether <paramref name="value" /> is valid mail address.
        /// </summary>
        /// <param name="value">Mail address to check.</param>
        /// <returns>
        /// <strong>true</strong> if mail address is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidMailAddress(string value)
        {
            SentinelHelper.ArgumentNull(value);

            var val = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");

            return val.IsMatch(value);
        }

        /// <summary>
        /// Determines whether <paramref name="value" /> is valid path.
        /// </summary>
        /// <param name="value">Path to check.</param>
        /// <returns>
        /// <strong>true</strong> if path is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidPath(string value)
        {
            SentinelHelper.ArgumentNull(value);

            var val = new Regex(@"^(.*/)?(?:$|(.+?)(?:(\.[^.]*$)|$))");

            return val.IsMatch(value);
        }

        /// <summary>
        /// Determines whether <paramref name="value" /> is valid identifier.
        /// </summary>
        /// <param name="value">Identifier to check.</param>
        /// <returns>
        /// <strong>true</strong> if identifier is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidIdentifier(string value)
        {
            SentinelHelper.ArgumentNull(value);

            var val = new Regex(@"^[a-zA-Z0-9_%@#-]+");
            return val.IsMatch(value);
        }

        /// <summary>
        /// Determines whether <paramref name="value" /> is valid field name.
        /// </summary>
        /// <param name="value">Field to check.</param>
        /// <returns>
        /// <strong>true</strong> if field name is valid; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidFieldName(string value)
        {
            SentinelHelper.ArgumentNull(value);

            var val = new Regex(@"^[a-zA-Z0-9_*%@#-]+");

            return val.IsMatch(value);
        }

        /// <summary>
        /// Determines whether <paramref name="value" /> is valid static resource.
        /// </summary>
        /// <param name="value">String to check.</param>
        /// <returns>
        /// <strong>true</strong> if string is a valid static resource; otherwise, <strong>false</strong>.
        /// </returns>
        public static bool IsValidStaticResource(string value)
        {
            SentinelHelper.ArgumentNull(value);

            var val = new Regex(@"^(\s)*\{(\s)*bind(\s)*:[\s|\w]*[.]*(\w)*}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            //var val = new Regex(@"^(\s)*\{(\s)*bind(\s)*:(\s)*\w+(\s)*}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);

            return val.IsMatch(value);
        }
    }
}
