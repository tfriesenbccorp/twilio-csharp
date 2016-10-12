using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Preview.Sync.Service {

    public class DocumentCreator : Creator<DocumentResource> {
        private string serviceSid;
        private string uniqueName;
        private Object data;
    
        /**
         * Construct a new DocumentCreator
         * 
         * @param serviceSid The service_sid
         */
        public DocumentCreator(string serviceSid) {
            this.serviceSid = serviceSid;
        }
    
        /**
         * The unique_name
         * 
         * @param uniqueName The unique_name
         * @return this
         */
        public DocumentCreator setUniqueName(string uniqueName) {
            this.uniqueName = uniqueName;
            return this;
        }
    
        /**
         * The data
         * 
         * @param data The data
         * @return this
         */
        public DocumentCreator setData(Object data) {
            this.data = data;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created DocumentResource
         */
        public override async Task<DocumentResource> CreateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.PREVIEW,
                "/Sync/Services/" + this.serviceSid + "/Documents"
            );
            
            addPostParams(request);
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("DocumentResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DocumentResource.FromJson(response.Content);
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created DocumentResource
         */
        public override DocumentResource Create(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.PREVIEW,
                "/Sync/Services/" + this.serviceSid + "/Documents"
            );
            
            addPostParams(request);
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("DocumentResource creation failed: Unable to connect to server");
            }
            
            if (response.StatusCode < System.Net.HttpStatusCode.OK || response.StatusCode > System.Net.HttpStatusCode.NoContent)
            {
                var restException = RestException.FromJson(response.Content);
                if (restException == null)
                {
                    throw new ApiException("Server Error, no content");
                }
            
                throw new ApiException(
                    restException.Code,
                    (int)response.StatusCode,
                    restException.Message ?? "Unable to create record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DocumentResource.FromJson(response.Content);
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (uniqueName != null) {
                request.AddPostParam("UniqueName", uniqueName);
            }
            
            if (data != null) {
                request.AddPostParam("Data", data.ToString());
            }
        }
    }
}