/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchAssistantOptions
    /// </summary>
    public class FetchAssistantOptions : IOptions<AssistantResource> 
    {
        /// <summary>
        /// A 34-character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchAssistantOptions
        /// </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this resource. </param>
        public FetchAssistantOptions(string pathSid)
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadAssistantOptions
    /// </summary>
    public class ReadAssistantOptions : ReadOptions<AssistantResource> 
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
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// CreateAssistantOptions
    /// </summary>
    public class CreateAssistantOptions : IOptions<AssistantResource> 
    {
        /// <summary>
        /// A text description for the Assistant. It is non-unique and can be up to 255 characters long.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A boolean that specifies whether queries should be logged for 30 days past training. If `false`, no queries will be stored. If `true`, queries will be stored for 30 days and deleted thereafter. Defaults to `true` if no value is provided.
        /// </summary>
        public bool? LogQueries { get; set; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The callback_url
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// A space-separated list of callback events that will trigger callbacks
        /// </summary>
        public string CallbackEvents { get; set; }
        /// <summary>
        /// A JSON object that defines the assistant [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet)
        /// </summary>
        public object StyleSheet { get; set; }
        /// <summary>
        /// A JSON object that defines the assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios
        /// </summary>
        public object Defaults { get; set; }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (LogQueries != null)
            {
                p.Add(new KeyValuePair<string, string>("LogQueries", LogQueries.Value.ToString().ToLower()));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (CallbackEvents != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackEvents", CallbackEvents));
            }

            if (StyleSheet != null)
            {
                p.Add(new KeyValuePair<string, string>("StyleSheet", Serializers.JsonObject(StyleSheet)));
            }

            if (Defaults != null)
            {
                p.Add(new KeyValuePair<string, string>("Defaults", Serializers.JsonObject(Defaults)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateAssistantOptions
    /// </summary>
    public class UpdateAssistantOptions : IOptions<AssistantResource> 
    {
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A text description for the Assistant. It is non-unique and can be up to 255 characters long.
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// A boolean that specifies whether queries should be logged for 30 days past training. If `false`, no queries will be stored. If `true`, queries will be stored for 30 days and deleted thereafter. Defaults to `true` if no value is provided.
        /// </summary>
        public bool? LogQueries { get; set; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long.
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// The callback_url
        /// </summary>
        public Uri CallbackUrl { get; set; }
        /// <summary>
        /// A space-separated list of callback events that will trigger callbacks
        /// </summary>
        public string CallbackEvents { get; set; }
        /// <summary>
        /// A JSON object that defines the assistant [style sheet](https://www.twilio.com/docs/autopilot/api/assistant/stylesheet)
        /// </summary>
        public object StyleSheet { get; set; }
        /// <summary>
        /// A JSON object that defines the assistant's [default tasks](https://www.twilio.com/docs/autopilot/api/assistant/defaults) for various scenarios
        /// </summary>
        public object Defaults { get; set; }

        /// <summary>
        /// Construct a new UpdateAssistantOptions
        /// </summary>
        /// <param name="pathSid"> The sid </param>
        public UpdateAssistantOptions(string pathSid)
        {
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (FriendlyName != null)
            {
                p.Add(new KeyValuePair<string, string>("FriendlyName", FriendlyName));
            }

            if (LogQueries != null)
            {
                p.Add(new KeyValuePair<string, string>("LogQueries", LogQueries.Value.ToString().ToLower()));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", Serializers.Url(CallbackUrl)));
            }

            if (CallbackEvents != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackEvents", CallbackEvents));
            }

            if (StyleSheet != null)
            {
                p.Add(new KeyValuePair<string, string>("StyleSheet", Serializers.JsonObject(StyleSheet)));
            }

            if (Defaults != null)
            {
                p.Add(new KeyValuePair<string, string>("Defaults", Serializers.JsonObject(Defaults)));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteAssistantOptions
    /// </summary>
    public class DeleteAssistantOptions : IOptions<AssistantResource> 
    {
        /// <summary>
        /// A 34-character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteAssistantOptions
        /// </summary>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this resource. </param>
        public DeleteAssistantOptions(string pathSid)
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