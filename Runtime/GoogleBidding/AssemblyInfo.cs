using System.Runtime.CompilerServices;
using Chartboost.Mediation.GoogleBidding;
using UnityEngine.Scripting;

[assembly: AlwaysLinkAssembly]
[assembly: InternalsVisibleTo(AssemblyInfo.GoogleBiddingAssemblyInfoAndroid)]
[assembly: InternalsVisibleTo(AssemblyInfo.GoogleBiddingAssemblyInfoIOS)]

namespace Chartboost.Mediation.GoogleBidding
{
    internal class AssemblyInfo
    {
        public const string GoogleBiddingAssemblyInfoAndroid = "Chartboost.Mediation.GoogleBidding.Android";
        public const string GoogleBiddingAssemblyInfoIOS = "Chartboost.Mediation.GoogleBidding.IOS";
    }
}
