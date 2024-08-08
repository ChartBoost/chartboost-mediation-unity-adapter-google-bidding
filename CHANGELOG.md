# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.0 *(2024-08-08)*

First version of the Chartboost Mediation Unity SDK - Google Bidding Adapter.

#Added 
- Support for the following `Google Bidding` dependencies. Notice adapter dependencies are optimistic and any patches and hot-fixes will be automatically picked up.:
    * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
    * iOS: `ChartboostMediationAdapterGoogleBidding ~> 5.11.5.0`
    
- `GoogleBiddingAdapter.cs` with Configuration Properties for `Google Bidding`.
- The following properties have been added in `GoogleBiddingAdapter.cs`
    * `string AdapterUnityVersion`
    * `string AdapterNativeVersion`
    * `string PartnerSDKVersion`
    * `string PartnerIdentifier`
    * `string PartnerDisplayName`
    * `IReadOnlyCollection<string> TestDeviceIds`