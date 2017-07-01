using System;
using System.Collections.Generic;
using Twilio.Base;

namespace Twilio.Rest.Preview.Proxy 
{

    /// <summary>
    /// Fetch a specific Service.
    /// </summary>
    public class FetchServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public FetchServiceOptions(string pathSid)
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
    /// Retrieve a list of all your Services.
    /// </summary>
    public class ReadServiceOptions : ReadOptions<ServiceResource> 
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
    /// Create a new Service to hold the number pool and configuration.
    /// </summary>
    public class CreateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Boolean flag specifying whether to auto-create threads.
        /// </summary>
        public bool? AutoCreate { get; set; }
        /// <summary>
        /// URL Twilio will request for callbacks.
        /// </summary>
        public Uri CallbackUrl { get; set; }

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

            if (AutoCreate != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreate", AutoCreate.Value.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.AbsoluteUri));
            }

            return p;
        }
    }

    /// <summary>
    /// Delete a specific Service.
    /// </summary>
    public class DeleteServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public DeleteServiceOptions(string pathSid)
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
    /// Update an s access to a specific Sync List.
    /// </summary>
    public class UpdateServiceOptions : IOptions<ServiceResource> 
    {
        /// <summary>
        /// A string that uniquely identifies this Service.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// A human readable description of this resource
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// Boolean flag specifying whether to auto-create threads.
        /// </summary>
        public bool? AutoCreate { get; set; }
        /// <summary>
        /// URL Twilio will request for callbacks.
        /// </summary>
        public Uri CallbackUrl { get; set; }

        /// <summary>
        /// Construct a new UpdateServiceOptions
        /// </summary>
        ///
        /// <param name="pathSid"> A string that uniquely identifies this Service. </param>
        public UpdateServiceOptions(string pathSid)
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

            if (AutoCreate != null)
            {
                p.Add(new KeyValuePair<string, string>("AutoCreate", AutoCreate.Value.ToString()));
            }

            if (CallbackUrl != null)
            {
                p.Add(new KeyValuePair<string, string>("CallbackUrl", CallbackUrl.AbsoluteUri));
            }

            return p;
        }
    }

}