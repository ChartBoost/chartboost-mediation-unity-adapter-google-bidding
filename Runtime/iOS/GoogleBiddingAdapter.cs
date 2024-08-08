using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using Chartboost.Constants;
using Chartboost.Mediation.GoogleBidding.Common;
using Chartboost.Mediation.Utilities;
using UnityEngine;

namespace Chartboost.Mediation.GoogleBidding.IOS
{
    internal sealed class GoogleBiddingAdapter : IGoogleBiddingAdapter
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            GoogleBidding.GoogleBiddingAdapter.Instance = new GoogleBiddingAdapter();
        }

        /// <inheritdoc/>
        public string AdapterNativeVersion => _CBMGoogleBiddingAdapterAdapterVersion();
        
        /// <inheritdoc/>
        public string PartnerSDKVersion => _CBMGoogleBiddingAdapterPartnerSDKVersion();
        
        /// <inheritdoc/>
        public string PartnerIdentifier => _CBMGoogleBiddingAdapterPartnerId();
        
        /// <inheritdoc/>
        public string PartnerDisplayName => _CBMGoogleBiddingAdapterPartnerDisplayName();

        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds
        {
            get
            {
                var testDeviceIds = _CBMGoogleBiddingAdapterGetTestDeviceIds();
                return string.IsNullOrEmpty(testDeviceIds) ? Array.Empty<string>() : testDeviceIds.ToList();
            }
            set
            {
                if (value == null || value.Count == 0)
                {
                    _CBMGoogleBiddingAdapterSetTestDeviceIds(Array.Empty<string>(), 0);
                    return;
                }
                
                _CBMGoogleBiddingAdapterSetTestDeviceIds(value.ToArray(), value.Count);
            }
        }

        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMGoogleBiddingAdapterAdapterVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMGoogleBiddingAdapterPartnerSDKVersion();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMGoogleBiddingAdapterPartnerId();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMGoogleBiddingAdapterPartnerDisplayName();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern string _CBMGoogleBiddingAdapterGetTestDeviceIds();
        [DllImport(SharedIOSConstants.DLLImport)] private static extern void _CBMGoogleBiddingAdapterSetTestDeviceIds(string[] testDeviceIds, int testDeviceIdsSize);
    }
}
