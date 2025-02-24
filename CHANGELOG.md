# Changelog
All notable changes to this project will be documented in this file using the standards as defined at [Keep a Changelog](https://keepachangelog.com/en/1.0.0/). This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0).

### Version 5.0.10 *(2025-02-14)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.6.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.11.0`

### Version 5.0.9 *(2025-02-14)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.5.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.11.0`

### Version 5.0.8 *(2025-02-14)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.5.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.10.0`

### Version 5.0.7 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.10.0`

### Version 5.0.6 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.9.0`

### Version 5.0.5 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.8.0`

### Version 5.0.4 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.7.0`

### Version 5.0.3 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.4.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.5.0`

### Version 5.0.2 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.2.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.6.0`

### Version 5.0.1 *(2024-10-17)*
This version of the Google Bidding Adapter supports the following native SDK dependencies:
  * Android: `com.chartboost:chartboost-mediation-adapter-google-bidding:5.23.3.+`
  * iOS: `ChartboostMediationAdapterGoogleBidding: ~> 5.11.5.0`

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