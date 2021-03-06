// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProbeProtocol.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProbeProtocol
    {
        [EnumMember(Value = "NotSet")]
        NotSet,
        [EnumMember(Value = "Http")]
        Http,
        [EnumMember(Value = "Https")]
        Https
    }
    internal static class ProbeProtocolEnumExtension
    {
        internal static string ToSerializedValue(this ProbeProtocol? value)
        {
            return value == null ? null : ((ProbeProtocol)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProbeProtocol value)
        {
            switch( value )
            {
                case ProbeProtocol.NotSet:
                    return "NotSet";
                case ProbeProtocol.Http:
                    return "Http";
                case ProbeProtocol.Https:
                    return "Https";
            }
            return null;
        }

        internal static ProbeProtocol? ParseProbeProtocol(this string value)
        {
            switch( value )
            {
                case "NotSet":
                    return ProbeProtocol.NotSet;
                case "Http":
                    return ProbeProtocol.Http;
                case "Https":
                    return ProbeProtocol.Https;
            }
            return null;
        }
    }
}
