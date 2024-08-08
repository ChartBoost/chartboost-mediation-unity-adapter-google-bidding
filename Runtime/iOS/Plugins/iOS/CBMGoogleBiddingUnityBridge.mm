#import "CBMDelegates.h"
#import "ChartboostUnityUtilities.h"
#import <ChartboostMediationAdapterGoogleBidding/ChartboostMediationAdapterGoogleBidding-Swift.h>

extern "C" {

    const char * _CBMGoogleBiddingAdapterAdapterVersion(){
        return toCStringOrNull([GoogleBiddingAdapterConfiguration adapterVersion]);
    }

    const char * _CBMGoogleBiddingAdapterPartnerSDKVersion(){
        return toCStringOrNull([GoogleBiddingAdapterConfiguration partnerSDKVersion]);
    }

    const char * _CBMGoogleBiddingAdapterPartnerId(){
        return toCStringOrNull([GoogleBiddingAdapterConfiguration partnerID]);
    }

    const char * _CBMGoogleBiddingAdapterPartnerDisplayName(){
        return toCStringOrNull([GoogleBiddingAdapterConfiguration partnerDisplayName]);
    }

    const char * _CBMGoogleBiddingAdapterGetTestDeviceIds(){
        return toJSON([GoogleBiddingAdapterConfiguration testDeviceIdentifiers]);
    }

    void _CBMGoogleBiddingAdapterSetTestDeviceIds(const char** testDeviceIds, int testDeviceIdsSize){
        if (testDeviceIdsSize > 0)
            [GoogleBiddingAdapterConfiguration setTestDeviceIdentifiers:toNSMutableArray(testDeviceIds, testDeviceIdsSize)];
        else
            [GoogleBiddingAdapterConfiguration setTestDeviceIdentifiers:nil];
    }
}
