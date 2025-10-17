using System.Collections.Generic;
using Chartboost.Mediation.Adapters;
using Chartboost.Mediation.GoogleBidding.Common;
using Chartboost.Mediation.GoogleBidding.Default;

namespace Chartboost.Mediation.GoogleBidding
{
    /// <inheritdoc cref="IGoogleBiddingAdapter"/>
    public static class GoogleBiddingAdapter 
    {
        internal static IGoogleBiddingAdapter Instance = new GoogleBiddingDefault();
        
        /// <summary>
        /// The partner adapter Unity version.
        /// </summary>
        public const string AdapterUnityVersion = "5.2.6";
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.AdapterNativeVersion"/>
        public static string AdapterNativeVersion => Instance.AdapterNativeVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerSDKVersion"/>
        public static string PartnerSDKVersion => Instance.PartnerSDKVersion;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerIdentifier"/>
        public static string PartnerIdentifier => Instance.PartnerIdentifier;
        
        /// <inheritdoc cref="IPartnerAdapterConfiguration.PartnerDisplayName"/>
        public static string PartnerDisplayName => Instance.PartnerDisplayName;

        /// <inheritdoc cref="IGoogleBiddingAdapter.TestDeviceIds"/>
        public static IReadOnlyCollection<string> TestDeviceIds
        {
            get => Instance.TestDeviceIds;
            set => Instance.TestDeviceIds = value;
        }
    }
}
