using System;
using System.Collections.Generic;
using Chartboost.Logging;
using Chartboost.Mediation.GoogleBidding;
using Chartboost.Tests.Runtime;
using NUnit.Framework;

namespace Chartboost.Tests
{
    internal class GoogleBiddingAdapterTests
    {
        [SetUp]
        public void SetUp()
            => LogController.LoggingLevel = LogLevel.Debug;

        [Test]
        public void AdapterNativeVersion()
            => TestUtilities.TestStringGetter(() => GoogleBiddingAdapter.AdapterNativeVersion);

        [Test]
        public void PartnerSDKVersion()
            => TestUtilities.TestStringGetter(() => GoogleBiddingAdapter.PartnerSDKVersion);

        [Test]
        public void PartnerIdentifier()
            => TestUtilities.TestStringGetter(() => GoogleBiddingAdapter.PartnerIdentifier);

        [Test]
        public void PartnerDisplayName()
            => TestUtilities.TestStringGetter(() => GoogleBiddingAdapter.PartnerDisplayName);

        [Test]
        public void TestDeviceIds()
        {
            Assert.AreEqual(Array.Empty<string>(), GoogleBiddingAdapter.TestDeviceIds);

            var testDeviceIds = new List<string>
            {
                "33BE2250B43518CCDA7DE426D04EE231",
                "33BE2250B43518CCDA7DE426D04EE232",
                "33BE2250B43518CCDA7DE426D04EE233"
            };

            GoogleBiddingAdapter.TestDeviceIds = testDeviceIds;
            Assert.AreEqual(testDeviceIds ,GoogleBiddingAdapter.TestDeviceIds);
            LogController.Log($"Test Device Ids: {Json.JsonTools.SerializeObject(GoogleBiddingAdapter.TestDeviceIds)}", LogLevel.Debug);
            GoogleBiddingAdapter.TestDeviceIds = null;
            Assert.AreEqual(Array.Empty<string>(), GoogleBiddingAdapter.TestDeviceIds);
        }
    }
}
