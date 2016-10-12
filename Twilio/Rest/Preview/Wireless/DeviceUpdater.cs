using System;
using Twilio.Base;
using Twilio.Clients;
using Twilio.Converters;
using Twilio.Exceptions;
using Twilio.Http;

#if NET40
using System.Threading.Tasks;
#endif

namespace Twilio.Rest.Preview.Wireless {

    public class DeviceUpdater : Updater<DeviceResource> {
        private string sid;
        private string alias;
        private string callbackMethod;
        private Uri callbackUrl;
        private string friendlyName;
        private string ratePlan;
        private string simIdentifier;
        private string status;
        private string commandsCallbackMethod;
        private Uri commandsCallbackUrl;
    
        /**
         * Construct a new DeviceUpdater
         * 
         * @param sid The sid
         */
        public DeviceUpdater(string sid) {
            this.sid = sid;
        }
    
        /**
         * The alias
         * 
         * @param alias The alias
         * @return this
         */
        public DeviceUpdater setAlias(string alias) {
            this.alias = alias;
            return this;
        }
    
        /**
         * The callback_method
         * 
         * @param callbackMethod The callback_method
         * @return this
         */
        public DeviceUpdater setCallbackMethod(string callbackMethod) {
            this.callbackMethod = callbackMethod;
            return this;
        }
    
        /**
         * The callback_url
         * 
         * @param callbackUrl The callback_url
         * @return this
         */
        public DeviceUpdater setCallbackUrl(Uri callbackUrl) {
            this.callbackUrl = callbackUrl;
            return this;
        }
    
        /**
         * The callback_url
         * 
         * @param callbackUrl The callback_url
         * @return this
         */
        public DeviceUpdater setCallbackUrl(string callbackUrl) {
            return setCallbackUrl(Promoter.UriFromString(callbackUrl));
        }
    
        /**
         * The friendly_name
         * 
         * @param friendlyName The friendly_name
         * @return this
         */
        public DeviceUpdater setFriendlyName(string friendlyName) {
            this.friendlyName = friendlyName;
            return this;
        }
    
        /**
         * The rate_plan
         * 
         * @param ratePlan The rate_plan
         * @return this
         */
        public DeviceUpdater setRatePlan(string ratePlan) {
            this.ratePlan = ratePlan;
            return this;
        }
    
        /**
         * The sim_identifier
         * 
         * @param simIdentifier The sim_identifier
         * @return this
         */
        public DeviceUpdater setSimIdentifier(string simIdentifier) {
            this.simIdentifier = simIdentifier;
            return this;
        }
    
        /**
         * The status
         * 
         * @param status The status
         * @return this
         */
        public DeviceUpdater setStatus(string status) {
            this.status = status;
            return this;
        }
    
        /**
         * The commands_callback_method
         * 
         * @param commandsCallbackMethod The commands_callback_method
         * @return this
         */
        public DeviceUpdater setCommandsCallbackMethod(string commandsCallbackMethod) {
            this.commandsCallbackMethod = commandsCallbackMethod;
            return this;
        }
    
        /**
         * The commands_callback_url
         * 
         * @param commandsCallbackUrl The commands_callback_url
         * @return this
         */
        public DeviceUpdater setCommandsCallbackUrl(Uri commandsCallbackUrl) {
            this.commandsCallbackUrl = commandsCallbackUrl;
            return this;
        }
    
        /**
         * The commands_callback_url
         * 
         * @param commandsCallbackUrl The commands_callback_url
         * @return this
         */
        public DeviceUpdater setCommandsCallbackUrl(string commandsCallbackUrl) {
            return setCommandsCallbackUrl(Promoter.UriFromString(commandsCallbackUrl));
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the update
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Updated DeviceResource
         */
        public override async Task<DeviceResource> UpdateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.PREVIEW,
                "/wireless/Devices/" + this.sid + ""
            );
            addPostParams(request);
            
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("DeviceResource update failed: Unable to connect to server");
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
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DeviceResource.FromJson(response.Content);
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the update
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Updated DeviceResource
         */
        public override DeviceResource Update(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.PREVIEW,
                "/wireless/Devices/" + this.sid + ""
            );
            addPostParams(request);
            
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("DeviceResource update failed: Unable to connect to server");
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
                    restException.Message ?? "Unable to update record, " + response.StatusCode,
                    restException.MoreInfo
                );
            }
            
            return DeviceResource.FromJson(response.Content);
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (alias != null) {
                request.AddPostParam("Alias", alias);
            }
            
            if (callbackMethod != null) {
                request.AddPostParam("CallbackMethod", callbackMethod);
            }
            
            if (callbackUrl != null) {
                request.AddPostParam("CallbackUrl", callbackUrl.ToString());
            }
            
            if (friendlyName != null) {
                request.AddPostParam("FriendlyName", friendlyName);
            }
            
            if (ratePlan != null) {
                request.AddPostParam("RatePlan", ratePlan);
            }
            
            if (simIdentifier != null) {
                request.AddPostParam("SimIdentifier", simIdentifier);
            }
            
            if (status != null) {
                request.AddPostParam("Status", status);
            }
            
            if (commandsCallbackMethod != null) {
                request.AddPostParam("CommandsCallbackMethod", commandsCallbackMethod);
            }
            
            if (commandsCallbackUrl != null) {
                request.AddPostParam("CommandsCallbackUrl", commandsCallbackUrl.ToString());
            }
        }
    }
}