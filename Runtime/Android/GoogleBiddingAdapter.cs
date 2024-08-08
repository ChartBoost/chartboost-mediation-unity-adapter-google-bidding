using System.Collections.Generic;
using Chartboost.Constants;
using Chartboost.Mediation.GoogleBidding.Common;
using UnityEngine;

namespace Chartboost.Mediation.GoogleBidding.Android
{
    internal sealed class GoogleBiddingAdapter : IGoogleBiddingAdapter
    {
        private const string GoogleBiddingAdapterConfiguration = "com.chartboost.mediation.googlebiddingadapter.GoogleBiddingAdapterConfiguration";
        
        [RuntimeInitializeOnLoadMethod]
        private static void RegisterInstance()
        {
            if (Application.isEditor)
                return;
            GoogleBidding.GoogleBiddingAdapter.Instance = new GoogleBiddingAdapter();
        }
        
        /// <inheritdoc/>
        public string AdapterNativeVersion
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetAdapterVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerSDKVersion 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerSdkVersion);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerIdentifier
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerId);
            }
        }
        
        /// <inheritdoc/>
        public string PartnerDisplayName 
        {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                return adapterConfiguration.Call<string>(SharedAndroidConstants.FunctionGetPartnerDisplayName);
            }
        }
        
        /// <inheritdoc/>
        public IReadOnlyCollection<string> TestDeviceIds {
            get
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                using var nativeTestDeviceIds = adapterConfiguration.Call<AndroidJavaObject>(SharedAndroidConstants.FunctionGetTestDeviceIds);
                return nativeTestDeviceIds.NativeListToList();
            }
            set
            {
                using var adapterConfiguration = new AndroidJavaObject(GoogleBiddingAdapterConfiguration);
                using var nativeList = value.EnumerableToNativeList();
                adapterConfiguration.Call(SharedAndroidConstants.FunctionSetTestDeviceIds, nativeList);
            }
        }
    }
}
