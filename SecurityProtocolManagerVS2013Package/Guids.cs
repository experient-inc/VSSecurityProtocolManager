// Guids.cs
// MUST match guids.h
using System;

namespace ExperientInc.SecurityProtocolManagerVS2013Package
{
    static class GuidList
    {
        public const string guidSecurityProtocolManagerVS2013PackagePkgString = "b02dae82-9024-4b4b-a2a1-ae9c4559aee2";
        public const string guidSecurityProtocolManagerVS2013PackageCmdSetString = "24dc2a56-8611-44f5-bea8-a24abfe250ae";

        public static readonly Guid guidSecurityProtocolManagerVS2013PackageCmdSet = new Guid(guidSecurityProtocolManagerVS2013PackageCmdSetString);
    };
}