using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Wireless.V1.Sim 
{

    /// <summary>
    /// ReadUsageRecordOptions
    /// </summary>
    public class ReadUsageRecordOptions : ReadOptions<UsageRecordResource> 
    {
        /// <summary>
        /// The sim_sid
        /// </summary>
        public string PathSimSid { get; }
        /// <summary>
        /// The end
        /// </summary>
        public DateTime? End { get; set; }
        /// <summary>
        /// The start
        /// </summary>
        public DateTime? Start { get; set; }
        /// <summary>
        /// The granularity
        /// </summary>
        public UsageRecordResource.GranularityEnum Granularity { get; set; }

        /// <summary>
        /// Construct a new ReadUsageRecordOptions
        /// </summary>
        ///
        /// <param name="pathSimSid"> The sim_sid </param>
        public ReadUsageRecordOptions(string pathSimSid)
        {
            PathSimSid = pathSimSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (End != null)
            {
                p.Add(new KeyValuePair<string, string>("End", Serializers.DateTimeIso8601(End)));
            }

            if (Start != null)
            {
                p.Add(new KeyValuePair<string, string>("Start", Serializers.DateTimeIso8601(Start)));
            }

            if (Granularity != null)
            {
                p.Add(new KeyValuePair<string, string>("Granularity", Granularity.ToString()));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}