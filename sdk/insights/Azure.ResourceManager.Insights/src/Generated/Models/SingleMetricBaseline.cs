// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The baseline results of a single metric. </summary>
    public partial class SingleMetricBaseline
    {
        /// <summary> Initializes a new instance of SingleMetricBaseline. </summary>
        /// <param name="id"> The metric baseline Id. </param>
        /// <param name="type"> The resource type of the metric baseline resource. </param>
        /// <param name="name"> The name of the metric for which the baselines were retrieved. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="baselines"> The baseline for each time series that was queried. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="type"/>, <paramref name="name"/>, <paramref name="timespan"/>, or <paramref name="baselines"/> is null. </exception>
        internal SingleMetricBaseline(string id, string type, string name, string timespan, TimeSpan interval, IEnumerable<TimeSeriesBaseline> baselines)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (timespan == null)
            {
                throw new ArgumentNullException(nameof(timespan));
            }
            if (baselines == null)
            {
                throw new ArgumentNullException(nameof(baselines));
            }

            Id = id;
            Type = type;
            Name = name;
            Timespan = timespan;
            Interval = interval;
            Baselines = baselines.ToList();
        }

        /// <summary> Initializes a new instance of SingleMetricBaseline. </summary>
        /// <param name="id"> The metric baseline Id. </param>
        /// <param name="type"> The resource type of the metric baseline resource. </param>
        /// <param name="name"> The name of the metric for which the baselines were retrieved. </param>
        /// <param name="timespan"> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </param>
        /// <param name="interval"> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </param>
        /// <param name="namespace"> The namespace of the metrics been queried. </param>
        /// <param name="baselines"> The baseline for each time series that was queried. </param>
        internal SingleMetricBaseline(string id, string type, string name, string timespan, TimeSpan interval, string @namespace, IReadOnlyList<TimeSeriesBaseline> baselines)
        {
            Id = id;
            Type = type;
            Name = name;
            Timespan = timespan;
            Interval = interval;
            Namespace = @namespace;
            Baselines = baselines;
        }

        /// <summary> The metric baseline Id. </summary>
        public string Id { get; }
        /// <summary> The resource type of the metric baseline resource. </summary>
        public string Type { get; }
        /// <summary> The name of the metric for which the baselines were retrieved. </summary>
        public string Name { get; }
        /// <summary> The timespan for which the data was retrieved. Its value consists of two datetimes concatenated, separated by &apos;/&apos;.  This may be adjusted in the future and returned back from what was originally requested. </summary>
        public string Timespan { get; }
        /// <summary> The interval (window size) for which the metric data was returned in.  This may be adjusted in the future and returned back from what was originally requested.  This is not present if a metadata request was made. </summary>
        public TimeSpan Interval { get; }
        /// <summary> The namespace of the metrics been queried. </summary>
        public string Namespace { get; }
        /// <summary> The baseline for each time series that was queried. </summary>
        public IReadOnlyList<TimeSeriesBaseline> Baselines { get; }
    }
}
