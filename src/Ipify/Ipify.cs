/*
    Copyright © 2015 David Musgrove.
    Licensed under the terms of the MIT License.
*/

using System.Net;

namespace Ipify
{
    /// <summary>
    /// Static utility class exposing methods to facilitate resolving a client's
    /// public IP address on the Internet by querying the service at ipify.org.
    /// </summary>
    public static class Ipify
    {
        /// <summary>
        /// Resolves the public IP address and returns it as a string.
        /// </summary>
        /// <param name="useHttps">
        /// Specifies whether to use HTTPS to talk to ipify.org (defaults to
        /// <b>false</b> if omitted).
        /// </param>
        /// <returns>
        /// A string containing the IP address, or an empty string if an error is
        /// encountered.
        /// </returns>
        public static string GetPublicAddress(bool useHttps = false)
        {
            var endpoint = useHttps ? "https://api.ipify.org" : "http://api.ipify.org";
            WebClient client = new WebClient();
            try
            {
                return client.DownloadString(endpoint);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Resolves the public IP address and returns it as an instance of
        /// <see cref="IPAddress" />.
        /// </summary>
        /// <param name="useHttps">
        /// Specifies whether to use HTTPS to talk to ipify.org (defaults to
        /// <b>false</b> if omitted).
        /// </param>
        /// <returns>
        /// An instance of <see cref="IPAddress" />. If an error occures, then
        /// <see cref="IPAddress.None" /> is returned.
        /// encountered.
        /// </returns>
        public static IPAddress GetPublicIPAddress(bool useHttps = false)
        {
            string address = GetPublicAddress(useHttps);
            IPAddress ipAddress;
            if (!IPAddress.TryParse(address, out ipAddress))
            {
                return IPAddress.None;
            }
            return ipAddress;
        }
    }
}