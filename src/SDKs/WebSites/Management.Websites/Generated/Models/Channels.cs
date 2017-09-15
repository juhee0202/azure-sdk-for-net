// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.WebSites;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Channels.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Channels
    {
        [EnumMember(Value = "Notification")]
        Notification,
        [EnumMember(Value = "Api")]
        Api,
        [EnumMember(Value = "Email")]
        Email,
        [EnumMember(Value = "Webhook")]
        Webhook,
        [EnumMember(Value = "All")]
        All
    }
    internal static class ChannelsEnumExtension
    {
        internal static string ToSerializedValue(this Channels? value)  =>
            value == null ? null : ((Channels)value).ToSerializedValue();

        internal static string ToSerializedValue(this Channels value)
        {
            switch( value )
            {
                case Channels.Notification:
                    return "Notification";
                case Channels.Api:
                    return "Api";
                case Channels.Email:
                    return "Email";
                case Channels.Webhook:
                    return "Webhook";
                case Channels.All:
                    return "All";
            }
            return null;
        }

        internal static Channels? ParseChannels(this string value)
        {
            switch( value )
            {
                case "Notification":
                    return Channels.Notification;
                case "Api":
                    return Channels.Api;
                case "Email":
                    return Channels.Email;
                case "Webhook":
                    return Channels.Webhook;
                case "All":
                    return Channels.All;
            }
            return null;
        }
    }
}