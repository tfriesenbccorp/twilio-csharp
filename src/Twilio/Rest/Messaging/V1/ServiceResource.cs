using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;
using Twilio.Types;

namespace Twilio.Rest.Messaging.V1 
{

    /// <summary>
    /// ServiceResource
    /// </summary>
    public class ServiceResource : Resource 
    {
        public sealed class ScanMessageContentEnum : StringEnum 
        {
            private ScanMessageContentEnum(string value) : base(value) {}
            public ScanMessageContentEnum() {}

            public static readonly ScanMessageContentEnum Inherit = new ScanMessageContentEnum("inherit");
            public static readonly ScanMessageContentEnum Enable = new ScanMessageContentEnum("enable");
            public static readonly ScanMessageContentEnum Disable = new ScanMessageContentEnum("disable");
        }

        private static Request BuildCreateRequest(CreateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/Services",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="options"> Create Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(CreateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildCreateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="inboundRequestUrl"> The inbound_request_url </param>
        /// <param name="inboundMethod"> The inbound_method </param>
        /// <param name="fallbackUrl"> The fallback_url </param>
        /// <param name="fallbackMethod"> The fallback_method </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="stickySender"> The sticky_sender </param>
        /// <param name="mmsConverter"> The mms_converter </param>
        /// <param name="smartEncoding"> The smart_encoding </param>
        /// <param name="scanMessageContent"> The scan_message_content </param>
        /// <param name="fallbackToLongCode"> The fallback_to_long_code </param>
        /// <param name="areaCodeGeomatch"> The area_code_geomatch </param>
        /// <param name="validityPeriod"> The validity_period </param>
        /// <param name="synchronousValidation"> The synchronous_validation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Create(string friendlyName, Uri inboundRequestUrl = null, Twilio.Http.HttpMethod inboundMethod = null, Uri fallbackUrl = null, Twilio.Http.HttpMethod fallbackMethod = null, Uri statusCallback = null, bool? stickySender = null, bool? mmsConverter = null, bool? smartEncoding = null, ServiceResource.ScanMessageContentEnum scanMessageContent = null, bool? fallbackToLongCode = null, bool? areaCodeGeomatch = null, int? validityPeriod = null, bool? synchronousValidation = null, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName){InboundRequestUrl = inboundRequestUrl, InboundMethod = inboundMethod, FallbackUrl = fallbackUrl, FallbackMethod = fallbackMethod, StatusCallback = statusCallback, StickySender = stickySender, MmsConverter = mmsConverter, SmartEncoding = smartEncoding, ScanMessageContent = scanMessageContent, FallbackToLongCode = fallbackToLongCode, AreaCodeGeomatch = areaCodeGeomatch, ValidityPeriod = validityPeriod, SynchronousValidation = synchronousValidation};
            return Create(options, client);
        }

        #if !NET35
        /// <summary>
        /// create
        /// </summary>
        ///
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="inboundRequestUrl"> The inbound_request_url </param>
        /// <param name="inboundMethod"> The inbound_method </param>
        /// <param name="fallbackUrl"> The fallback_url </param>
        /// <param name="fallbackMethod"> The fallback_method </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="stickySender"> The sticky_sender </param>
        /// <param name="mmsConverter"> The mms_converter </param>
        /// <param name="smartEncoding"> The smart_encoding </param>
        /// <param name="scanMessageContent"> The scan_message_content </param>
        /// <param name="fallbackToLongCode"> The fallback_to_long_code </param>
        /// <param name="areaCodeGeomatch"> The area_code_geomatch </param>
        /// <param name="validityPeriod"> The validity_period </param>
        /// <param name="synchronousValidation"> The synchronous_validation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> CreateAsync(string friendlyName, Uri inboundRequestUrl = null, Twilio.Http.HttpMethod inboundMethod = null, Uri fallbackUrl = null, Twilio.Http.HttpMethod fallbackMethod = null, Uri statusCallback = null, bool? stickySender = null, bool? mmsConverter = null, bool? smartEncoding = null, ServiceResource.ScanMessageContentEnum scanMessageContent = null, bool? fallbackToLongCode = null, bool? areaCodeGeomatch = null, int? validityPeriod = null, bool? synchronousValidation = null, ITwilioRestClient client = null)
        {
            var options = new CreateServiceOptions(friendlyName){InboundRequestUrl = inboundRequestUrl, InboundMethod = inboundMethod, FallbackUrl = fallbackUrl, FallbackMethod = fallbackMethod, StatusCallback = statusCallback, StickySender = stickySender, MmsConverter = mmsConverter, SmartEncoding = smartEncoding, ScanMessageContent = scanMessageContent, FallbackToLongCode = fallbackToLongCode, AreaCodeGeomatch = areaCodeGeomatch, ValidityPeriod = validityPeriod, SynchronousValidation = synchronousValidation};
            return await CreateAsync(options, client);
        }
        #endif

        private static Request BuildUpdateRequest(UpdateServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Post,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                postParams: options.GetParams()
            );
        }

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="options"> Update Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(UpdateServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildUpdateRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="inboundRequestUrl"> The inbound_request_url </param>
        /// <param name="inboundMethod"> The inbound_method </param>
        /// <param name="fallbackUrl"> The fallback_url </param>
        /// <param name="fallbackMethod"> The fallback_method </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="stickySender"> The sticky_sender </param>
        /// <param name="mmsConverter"> The mms_converter </param>
        /// <param name="smartEncoding"> The smart_encoding </param>
        /// <param name="scanMessageContent"> The scan_message_content </param>
        /// <param name="fallbackToLongCode"> The fallback_to_long_code </param>
        /// <param name="areaCodeGeomatch"> The area_code_geomatch </param>
        /// <param name="validityPeriod"> The validity_period </param>
        /// <param name="synchronousValidation"> The synchronous_validation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Update(string pathSid, string friendlyName = null, Uri inboundRequestUrl = null, Twilio.Http.HttpMethod inboundMethod = null, Uri fallbackUrl = null, Twilio.Http.HttpMethod fallbackMethod = null, Uri statusCallback = null, bool? stickySender = null, bool? mmsConverter = null, bool? smartEncoding = null, ServiceResource.ScanMessageContentEnum scanMessageContent = null, bool? fallbackToLongCode = null, bool? areaCodeGeomatch = null, int? validityPeriod = null, bool? synchronousValidation = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, InboundRequestUrl = inboundRequestUrl, InboundMethod = inboundMethod, FallbackUrl = fallbackUrl, FallbackMethod = fallbackMethod, StatusCallback = statusCallback, StickySender = stickySender, MmsConverter = mmsConverter, SmartEncoding = smartEncoding, ScanMessageContent = scanMessageContent, FallbackToLongCode = fallbackToLongCode, AreaCodeGeomatch = areaCodeGeomatch, ValidityPeriod = validityPeriod, SynchronousValidation = synchronousValidation};
            return Update(options, client);
        }

        #if !NET35
        /// <summary>
        /// update
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="friendlyName"> The friendly_name </param>
        /// <param name="inboundRequestUrl"> The inbound_request_url </param>
        /// <param name="inboundMethod"> The inbound_method </param>
        /// <param name="fallbackUrl"> The fallback_url </param>
        /// <param name="fallbackMethod"> The fallback_method </param>
        /// <param name="statusCallback"> The status_callback </param>
        /// <param name="stickySender"> The sticky_sender </param>
        /// <param name="mmsConverter"> The mms_converter </param>
        /// <param name="smartEncoding"> The smart_encoding </param>
        /// <param name="scanMessageContent"> The scan_message_content </param>
        /// <param name="fallbackToLongCode"> The fallback_to_long_code </param>
        /// <param name="areaCodeGeomatch"> The area_code_geomatch </param>
        /// <param name="validityPeriod"> The validity_period </param>
        /// <param name="synchronousValidation"> The synchronous_validation </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> UpdateAsync(string pathSid, string friendlyName = null, Uri inboundRequestUrl = null, Twilio.Http.HttpMethod inboundMethod = null, Uri fallbackUrl = null, Twilio.Http.HttpMethod fallbackMethod = null, Uri statusCallback = null, bool? stickySender = null, bool? mmsConverter = null, bool? smartEncoding = null, ServiceResource.ScanMessageContentEnum scanMessageContent = null, bool? fallbackToLongCode = null, bool? areaCodeGeomatch = null, int? validityPeriod = null, bool? synchronousValidation = null, ITwilioRestClient client = null)
        {
            var options = new UpdateServiceOptions(pathSid){FriendlyName = friendlyName, InboundRequestUrl = inboundRequestUrl, InboundMethod = inboundMethod, FallbackUrl = fallbackUrl, FallbackMethod = fallbackMethod, StatusCallback = statusCallback, StickySender = stickySender, MmsConverter = mmsConverter, SmartEncoding = smartEncoding, ScanMessageContent = scanMessageContent, FallbackToLongCode = fallbackToLongCode, AreaCodeGeomatch = areaCodeGeomatch, ValidityPeriod = validityPeriod, SynchronousValidation = synchronousValidation};
            return await UpdateAsync(options, client);
        }
        #endif

        private static Request BuildReadRequest(ReadServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="options"> Read Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(ReadServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildReadRequest(options, client));

            var page = Page<ServiceResource>.FromJson("services", response.Content);
            return new ResourceSet<ServiceResource>(page, options, client);
        }
        #endif

        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ResourceSet<ServiceResource> Read(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return Read(options, client);
        }

        #if !NET35
        /// <summary>
        /// read
        /// </summary>
        ///
        /// <param name="pageSize"> Page size </param>
        /// <param name="limit"> Record limit </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ResourceSet<ServiceResource>> ReadAsync(int? pageSize = null, long? limit = null, ITwilioRestClient client = null)
        {
            var options = new ReadServiceOptions{PageSize = pageSize, Limit = limit};
            return await ReadAsync(options, client);
        }
        #endif

        /// <summary>
        /// Fetch the target page of records
        /// </summary>
        ///
        /// <param name="targetUrl"> API-generated URL for the requested results page </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The target page of records </returns> 
        public static Page<ServiceResource> GetPage(string targetUrl, ITwilioRestClient client)
        {
            client = client ?? TwilioClient.GetRestClient();

            var request = new Request(
                HttpMethod.Get,
                targetUrl
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the next page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The next page of records </returns> 
        public static Page<ServiceResource> NextPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetNextPageUrl(
                    Rest.Domain.Messaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        /// <summary>
        /// Fetch the previous page of records
        /// </summary>
        ///
        /// <param name="page"> current page of records </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> The previous page of records </returns> 
        public static Page<ServiceResource> PreviousPage(Page<ServiceResource> page, ITwilioRestClient client)
        {
            var request = new Request(
                HttpMethod.Get,
                page.GetPreviousPageUrl(
                    Rest.Domain.Messaging,
                    client.Region
                )
            );

            var response = client.Request(request);
            return Page<ServiceResource>.FromJson("services", response.Content);
        }

        private static Request BuildFetchRequest(FetchServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Get,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="options"> Fetch Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(FetchServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildFetchRequest(options, client));
            return FromJson(response.Content);
        }
        #endif

        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static ServiceResource Fetch(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return Fetch(options, client);
        }

        #if !NET35
        /// <summary>
        /// fetch
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<ServiceResource> FetchAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new FetchServiceOptions(pathSid);
            return await FetchAsync(options, client);
        }
        #endif

        private static Request BuildDeleteRequest(DeleteServiceOptions options, ITwilioRestClient client)
        {
            return new Request(
                HttpMethod.Delete,
                Rest.Domain.Messaging,
                "/v1/Services/" + options.PathSid + "",
                client.Region,
                queryParams: options.GetParams()
            );
        }

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = client.Request(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="options"> Delete Service parameters </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(DeleteServiceOptions options, ITwilioRestClient client = null)
        {
            client = client ?? TwilioClient.GetRestClient();
            var response = await client.RequestAsync(BuildDeleteRequest(options, client));
            return response.StatusCode == System.Net.HttpStatusCode.NoContent;
        }
        #endif

        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> A single instance of Service </returns> 
        public static bool Delete(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return Delete(options, client);
        }

        #if !NET35
        /// <summary>
        /// delete
        /// </summary>
        ///
        /// <param name="pathSid"> The sid </param>
        /// <param name="client"> Client to make requests to Twilio </param>
        /// <returns> Task that resolves to A single instance of Service </returns> 
        public static async System.Threading.Tasks.Task<bool> DeleteAsync(string pathSid, ITwilioRestClient client = null)
        {
            var options = new DeleteServiceOptions(pathSid);
            return await DeleteAsync(options, client);
        }
        #endif

        /// <summary>
        /// Converts a JSON string into a ServiceResource object
        /// </summary>
        ///
        /// <param name="json"> Raw JSON string </param>
        /// <returns> ServiceResource object represented by the provided JSON </returns> 
        public static ServiceResource FromJson(string json)
        {
            // Convert all checked exceptions to Runtime
            try
            {
                return JsonConvert.DeserializeObject<ServiceResource>(json);
            }
            catch (JsonException e)
            {
                throw new ApiException(e.Message, e);
            }
        }

        /// <summary>
        /// The sid
        /// </summary>
        [JsonProperty("sid")]
        public string Sid { get; private set; }
        /// <summary>
        /// The account_sid
        /// </summary>
        [JsonProperty("account_sid")]
        public string AccountSid { get; private set; }
        /// <summary>
        /// The friendly_name
        /// </summary>
        [JsonProperty("friendly_name")]
        public string FriendlyName { get; private set; }
        /// <summary>
        /// The date_created
        /// </summary>
        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; private set; }
        /// <summary>
        /// The date_updated
        /// </summary>
        [JsonProperty("date_updated")]
        public DateTime? DateUpdated { get; private set; }
        /// <summary>
        /// The inbound_request_url
        /// </summary>
        [JsonProperty("inbound_request_url")]
        public Uri InboundRequestUrl { get; private set; }
        /// <summary>
        /// The inbound_method
        /// </summary>
        [JsonProperty("inbound_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod InboundMethod { get; private set; }
        /// <summary>
        /// The fallback_url
        /// </summary>
        [JsonProperty("fallback_url")]
        public Uri FallbackUrl { get; private set; }
        /// <summary>
        /// The fallback_method
        /// </summary>
        [JsonProperty("fallback_method")]
        [JsonConverter(typeof(HttpMethodConverter))]
        public Twilio.Http.HttpMethod FallbackMethod { get; private set; }
        /// <summary>
        /// The status_callback
        /// </summary>
        [JsonProperty("status_callback")]
        public Uri StatusCallback { get; private set; }
        /// <summary>
        /// The sticky_sender
        /// </summary>
        [JsonProperty("sticky_sender")]
        public bool? StickySender { get; private set; }
        /// <summary>
        /// The mms_converter
        /// </summary>
        [JsonProperty("mms_converter")]
        public bool? MmsConverter { get; private set; }
        /// <summary>
        /// The smart_encoding
        /// </summary>
        [JsonProperty("smart_encoding")]
        public bool? SmartEncoding { get; private set; }
        /// <summary>
        /// The scan_message_content
        /// </summary>
        [JsonProperty("scan_message_content")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ServiceResource.ScanMessageContentEnum ScanMessageContent { get; private set; }
        /// <summary>
        /// The fallback_to_long_code
        /// </summary>
        [JsonProperty("fallback_to_long_code")]
        public bool? FallbackToLongCode { get; private set; }
        /// <summary>
        /// The area_code_geomatch
        /// </summary>
        [JsonProperty("area_code_geomatch")]
        public bool? AreaCodeGeomatch { get; private set; }
        /// <summary>
        /// The synchronous_validation
        /// </summary>
        [JsonProperty("synchronous_validation")]
        public bool? SynchronousValidation { get; private set; }
        /// <summary>
        /// The validity_period
        /// </summary>
        [JsonProperty("validity_period")]
        public int? ValidityPeriod { get; private set; }
        /// <summary>
        /// The url
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; private set; }
        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("links")]
        public Dictionary<string, string> Links { get; private set; }

        private ServiceResource()
        {

        }
    }

}