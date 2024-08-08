using System;
using System.Collections.Generic;
using Chartboost.Mediation.GoogleBidding.Common;

namespace Chartboost.Mediation.GoogleBidding.Default
{
    internal class GoogleBiddingDefault : IGoogleBiddingAdapter
    {
        /// <inheritdoc/>
        public string AdapterNativeVersion => GoogleBiddingAdapter.AdapterUnityVersion;

        /// <inheritdoc/>
        public string PartnerSDKVersion => GoogleBiddingAdapter.AdapterUnityVersion;
        
        /// <inheritdoc/>
        public string PartnerIdentifier => "google_googlebidding";
        
        /// <inheritdoc/>
        public string PartnerDisplayName => "Google Bidding";
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds {
            get => _testDeviceIds;
            set
            {
                if (value == null || value.Count == 0)
                    _testDeviceIds = Array.Empty<string>();
                else
                    _testDeviceIds = value;
            }
        }

        private IReadOnlyCollection<string> _testDeviceIds = Array.Empty<string>();
    }
}
