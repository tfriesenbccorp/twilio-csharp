using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;

namespace Twilio.Rest.Wireless.V1 
{

    /// <summary>
    /// ReadRatePlanOptions
    /// </summary>
    public class ReadRatePlanOptions : ReadOptions<RatePlanResource> 
    {
        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// FetchRatePlanOptions
    /// </summary>
    public class FetchRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRatePlanOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public FetchRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

    /// <summary>
    /// CreateRatePlanOptions
    /// </summary>
    public class CreateRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// The data_enabled
        /// </summary>
        public bool? DataEnabled { get; set; }
        /// <summary>
        /// The data_limit
        /// </summary>
        public int? DataLimit { get; set; }
        /// <summary>
        /// The data_metering
        /// </summary>
        public string DataMetering { get; set; }
        /// <summary>
        /// The messaging_enabled
        /// </summary>
        public bool? MessagingEnabled { get; set; }
        /// <summary>
        /// The voice_enabled
        /// </summary>
        public bool? VoiceEnabled { get; set; }
        /// <summary>
        /// The national_roaming_enabled
        /// </summary>
        public bool? NationalRoamingEnabled { get; set; }
        /// <summary>
        /// The international_roaming
        /// </summary>
        public List<string> InternationalRoaming { get; set; }
        /// <summary>
        /// The national_roaming_data_limit
        /// </summary>
        public int? NationalRoamingDataLimit { get; set; }
        /// <summary>
        /// The international_roaming_data_limit
        /// </summary>
        public int? InternationalRoamingDataLimit { get; set; }

        /// <summary>
        /// Construct a new CreateRatePlanOptions
        /// </summary>
        public CreateRatePlanOptions()
        {
            InternationalRoaming = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (DataEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("DataEnabled", DataEnabled.Value.ToString()));
            }

            if (DataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("DataLimit", DataLimit.Value.ToString()));
            }

            if (DataMetering != null)
            {
                p.Add(new KeyValuePair<string, string>("DataMetering", DataMetering));
            }

            if (MessagingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("MessagingEnabled", MessagingEnabled.Value.ToString()));
            }

            if (VoiceEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("VoiceEnabled", VoiceEnabled.Value.ToString()));
            }

            if (NationalRoamingEnabled != null)
            {
                p.Add(new KeyValuePair<string, string>("NationalRoamingEnabled", NationalRoamingEnabled.Value.ToString()));
            }

            if (InternationalRoaming != null)
            {
                p.AddRange(InternationalRoaming.Select(prop => new KeyValuePair<string, string>("InternationalRoaming", prop)));
            }

            if (NationalRoamingDataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("NationalRoamingDataLimit", NationalRoamingDataLimit.Value.ToString()));
            }

            if (InternationalRoamingDataLimit != null)
            {
                p.Add(new KeyValuePair<string, string>("InternationalRoamingDataLimit", InternationalRoamingDataLimit.Value.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// UpdateRatePlanOptions
    /// </summary>
    public class UpdateRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The unique_name
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        public string FriendlyName { get; set; }

        /// <summary>
        /// Construct a new UpdateRatePlanOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public UpdateRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteRatePlanOptions
    /// </summary>
    public class DeleteRatePlanOptions : IOptions<RatePlanResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteRatePlanOptions
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        public DeleteRatePlanOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            return p;
        }
    }

}