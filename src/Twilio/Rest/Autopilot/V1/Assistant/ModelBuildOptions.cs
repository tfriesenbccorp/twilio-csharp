/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Autopilot.V1.Assistant 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// FetchModelBuildOptions
    /// </summary>
    public class FetchModelBuildOptions : IOptions<ModelBuildResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// A 34-character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchModelBuildOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this resource. </param>
        public FetchModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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
    /// ReadModelBuildOptions
    /// </summary>
    public class ReadModelBuildOptions : ReadOptions<ModelBuildResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }

        /// <summary>
        /// Construct a new ReadModelBuildOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        public ReadModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

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
    /// CreateModelBuildOptions
    /// </summary>
    public class CreateModelBuildOptions : IOptions<ModelBuildResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// The status_callback
        /// </summary>
        public Uri StatusCallback { get; set; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. For example: v0.1
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new CreateModelBuildOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        public CreateModelBuildOptions(string pathAssistantSid)
        {
            PathAssistantSid = pathAssistantSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (StatusCallback != null)
            {
                p.Add(new KeyValuePair<string, string>("StatusCallback", Serializers.Url(StatusCallback)));
            }

            if (UniqueName != null)
            {
                p.Add(new KeyValuePair<string, string>("UniqueName", UniqueName));
            }

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// UpdateModelBuildOptions
    /// </summary>
    public class UpdateModelBuildOptions : IOptions<ModelBuildResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// A 34-character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A user-provided string that uniquely identifies this resource as an alternative to the sid. Unique up to 64 characters long. For example: v0.1
        /// </summary>
        public string UniqueName { get; set; }

        /// <summary>
        /// Construct a new UpdateModelBuildOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this resource. </param>
        public UpdateModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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

            return p;
        }
    }

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// DeleteModelBuildOptions
    /// </summary>
    public class DeleteModelBuildOptions : IOptions<ModelBuildResource> 
    {
        /// <summary>
        /// The unique ID of the parent Assistant.
        /// </summary>
        public string PathAssistantSid { get; }
        /// <summary>
        /// A 34-character string that uniquely identifies this resource.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteModelBuildOptions
        /// </summary>
        /// <param name="pathAssistantSid"> The unique ID of the parent Assistant. </param>
        /// <param name="pathSid"> A 34-character string that uniquely identifies this resource. </param>
        public DeleteModelBuildOptions(string pathAssistantSid, string pathSid)
        {
            PathAssistantSid = pathAssistantSid;
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