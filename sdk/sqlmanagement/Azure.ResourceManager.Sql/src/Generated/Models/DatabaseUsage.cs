// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The database usages. </summary>
    public partial class DatabaseUsage
    {
        /// <summary> Initializes a new instance of DatabaseUsage. </summary>
        internal DatabaseUsage()
        {
        }

        /// <summary> Initializes a new instance of DatabaseUsage. </summary>
        /// <param name="name"> The name of the usage metric. </param>
        /// <param name="resourceName"> The name of the resource. </param>
        /// <param name="displayName"> The usage metric display name. </param>
        /// <param name="currentValue"> The current value of the usage metric. </param>
        /// <param name="limit"> The current limit of the usage metric. </param>
        /// <param name="unit"> The units of the usage metric. </param>
        /// <param name="nextResetTime"> The next reset time for the usage metric (ISO8601 format). </param>
        internal DatabaseUsage(string name, string resourceName, string displayName, double? currentValue, double? limit, string unit, DateTimeOffset? nextResetTime)
        {
            Name = name;
            ResourceName = resourceName;
            DisplayName = displayName;
            CurrentValue = currentValue;
            Limit = limit;
            Unit = unit;
            NextResetTime = nextResetTime;
        }

        /// <summary> The name of the usage metric. </summary>
        public string Name { get; }
        /// <summary> The name of the resource. </summary>
        public string ResourceName { get; }
        /// <summary> The usage metric display name. </summary>
        public string DisplayName { get; }
        /// <summary> The current value of the usage metric. </summary>
        public double? CurrentValue { get; }
        /// <summary> The current limit of the usage metric. </summary>
        public double? Limit { get; }
        /// <summary> The units of the usage metric. </summary>
        public string Unit { get; }
        /// <summary> The next reset time for the usage metric (ISO8601 format). </summary>
        public DateTimeOffset? NextResetTime { get; }
    }
}
