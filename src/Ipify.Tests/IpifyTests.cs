/*
    Copyright © 2015 David Musgrove.
    Licensed under the terms of the MIT License.
*/

using System.Net;

using NUnit.Framework;

namespace Ipify.Tests
{
    [TestFixture]
    public class IpifyTests
    {
        [Test]
        public void GetAddress_ReturnsStringContainingAnIPAddress()
        {
            string ip = Ipify.GetPublicAddress();
            IPAddress ipAddress;
            Assert.IsTrue(IPAddress.TryParse(ip, out ipAddress));
        }

        [Test]
        public void GetAddress_ReturnsStringContainingAnIPAddressUsingHttps()
        {
            string ip = Ipify.GetPublicAddress(true);
            IPAddress ipAddress;
            Assert.IsTrue(IPAddress.TryParse(ip, out ipAddress));
        }

        [Test]
        public void GetIPAddress_ReturnsIPAddressInstance()
        {
            IPAddress ipAddress = Ipify.GetPublicIPAddress();
            Assert.IsNotNull(ipAddress);
            Assert.AreNotEqual(IPAddress.None, ipAddress);
        }

        [Test]
        public void GetIPAddress_ReturnsIPAddressInstanceUsingHttps()
        {
            IPAddress ipAddress = Ipify.GetPublicIPAddress(true);
            Assert.IsNotNull(ipAddress);
            Assert.AreNotEqual(IPAddress.None, ipAddress);
        }
    }
}
