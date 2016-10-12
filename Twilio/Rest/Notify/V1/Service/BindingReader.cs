using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Notify.V1.Service {

    public class BindingReader : Reader<BindingResource> {
        private string serviceSid;
        private DateTime? startDate;
        private DateTime? endDate;
        private List<string> identity;
        private List<string> tag;
    
        /**
         * Construct a new BindingReader
         * 
         * @param serviceSid The service_sid
         */
        public BindingReader(string serviceSid) {
            this.serviceSid = serviceSid;
        }
    
        /**
         * The start_date
         * 
         * @param startDate The start_date
         * @return this
         */
        public BindingReader ByStartDate(DateTime? startDate) {
            this.startDate = startDate;
            return this;
        }
    
        /**
         * The end_date
         * 
         * @param endDate The end_date
         * @return this
         */
        public BindingReader ByEndDate(DateTime? endDate) {
            this.endDate = endDate;
            return this;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public BindingReader ByIdentity(List<string> identity) {
            this.identity = identity;
            return this;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public BindingReader ByIdentity(string identity) {
            return ByIdentity(Promoter.ListOfOne(identity));
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public BindingReader ByTag(List<string> tag) {
            this.tag = tag;
            return this;
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public BindingReader ByTag(string tag) {
            return ByTag(Promoter.ListOfOne(tag));
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return BindingResource ResourceSet
         */
        public override Task<ResourceSet<BindingResource>> ReadAsync(ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                Domains.NOTIFY,
                "/v1/Services/" + this.serviceSid + "/Bindings"
            );
            AddQueryParams(request);
            
            var page = PageForRequest(client, request);
            
            return System.Threading.Tasks.Task.FromResult(new ResourceSet<BindingResource>(this, client, page));
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the read
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return BindingResource ResourceSet
         */
        public override ResourceSet<BindingResource> Read(ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                Domains.NOTIFY,
                "/v1/Services/" + this.serviceSid + "/Bindings"
            );
            
            AddQueryParams(request);
            var page = PageForRequest(client, request);
            
            return new ResourceSet<BindingResource>(this, client, page);
        }
    
        /**
         * Retrieve the next page from the Twilio API
         * 
         * @param nextPageUri URI from which to retrieve the next page
         * @param client ITwilioRestClient with which to make the request
         * @return Next Page
         */
        public override Page<BindingResource> NextPage(Page<BindingResource> page, ITwilioRestClient client) {
            var request = new Request(
                HttpMethod.GET,
                page.GetNextPageUrl(
                    Domains.NOTIFY
                )
            );
            
            return PageForRequest(client, request);
        }
    
        /**
         * Generate a Page of BindingResource Resources for a given request
         * 
         * @param client ITwilioRestClient with which to make the request
         * @param request Request to generate a page for
         * @return Page for the Request
         */
        protected Page<BindingResource> PageForRequest(ITwilioRestClient client, Request request) {
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("BindingResource read failed: Unable to connect to server");
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
                    restException.Message ?? "Unable to read records, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return Page<BindingResource>.FromJson("bindings", response.Content);
        }
    
        /**
         * Add the requested query string arguments to the Request
         * 
         * @param request Request to add query string arguments to
         */
        private void AddQueryParams(Request request) {
            if (startDate != null) {
                request.AddQueryParam("StartDate", startDate.ToString());
            }
            
            if (endDate != null) {
                request.AddQueryParam("EndDate", endDate.ToString());
            }
            
            if (identity != null) {
                request.AddQueryParam("Identity", identity.ToString());
            }
            
            if (tag != null) {
                request.AddQueryParam("Tag", tag.ToString());
            }
            
            request.AddQueryParam("PageSize", PageSize.ToString());
        }
    }
}