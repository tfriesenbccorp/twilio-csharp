/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Serverless.V1.Service 
{

    /// <summary>
    /// PLEASE NOTE that this class contains preview products that are subject to change. Use them with caution. If you
    /// currently do not have developer preview access, please contact help@twilio.com.
    /// 
    /// ReadBuildOptions
    /// </summary>
    public class ReadBuildOptions : ReadOptions<BuildResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }

        /// <summary>
        /// Construct a new ReadBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        public ReadBuildOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// FetchBuildOptions
    /// </summary>
    public class FetchBuildOptions : IOptions<BuildResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchBuildOptions(string pathServiceSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
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
    /// CreateBuildOptions
    /// </summary>
    public class CreateBuildOptions : IOptions<BuildResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The asset_versions
        /// </summary>
        public List<string> AssetVersions { get; set; }
        /// <summary>
        /// The function_versions
        /// </summary>
        public List<string> FunctionVersions { get; set; }
        /// <summary>
        /// The dependencies
        /// </summary>
        public string Dependencies { get; set; }

        /// <summary>
        /// Construct a new CreateBuildOptions
        /// </summary>
        /// <param name="pathServiceSid"> The service_sid </param>
        public CreateBuildOptions(string pathServiceSid)
        {
            PathServiceSid = pathServiceSid;
            AssetVersions = new List<string>();
            FunctionVersions = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (AssetVersions != null)
            {
                p.AddRange(AssetVersions.Select(prop => new KeyValuePair<string, string>("AssetVersions", prop.ToString())));
            }

            if (FunctionVersions != null)
            {
                p.AddRange(FunctionVersions.Select(prop => new KeyValuePair<string, string>("FunctionVersions", prop.ToString())));
            }

            if (Dependencies != null)
            {
                p.Add(new KeyValuePair<string, string>("Dependencies", Dependencies));
            }

            return p;
        }
    }

}