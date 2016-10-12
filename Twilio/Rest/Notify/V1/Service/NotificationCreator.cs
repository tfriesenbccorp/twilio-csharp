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

    public class NotificationCreator : Creator<NotificationResource> {
        private string serviceSid;
        private List<string> identity;
        private List<string> tag;
        private string body;
        private NotificationResource.Priority priority;
        private int? ttl;
        private string title;
        private string sound;
        private string action;
        private string data;
        private string apn;
        private string gcm;
        private string sms;
        private Object facebookMessenger;
    
        /**
         * Construct a new NotificationCreator
         * 
         * @param serviceSid The service_sid
         */
        public NotificationCreator(string serviceSid) {
            this.serviceSid = serviceSid;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public NotificationCreator setIdentity(List<string> identity) {
            this.identity = identity;
            return this;
        }
    
        /**
         * The identity
         * 
         * @param identity The identity
         * @return this
         */
        public NotificationCreator setIdentity(string identity) {
            return setIdentity(Promoter.ListOfOne(identity));
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public NotificationCreator setTag(List<string> tag) {
            this.tag = tag;
            return this;
        }
    
        /**
         * The tag
         * 
         * @param tag The tag
         * @return this
         */
        public NotificationCreator setTag(string tag) {
            return setTag(Promoter.ListOfOne(tag));
        }
    
        /**
         * The body
         * 
         * @param body The body
         * @return this
         */
        public NotificationCreator setBody(string body) {
            this.body = body;
            return this;
        }
    
        /**
         * The priority
         * 
         * @param priority The priority
         * @return this
         */
        public NotificationCreator setPriority(NotificationResource.Priority priority) {
            this.priority = priority;
            return this;
        }
    
        /**
         * The ttl
         * 
         * @param ttl The ttl
         * @return this
         */
        public NotificationCreator setTtl(int? ttl) {
            this.ttl = ttl;
            return this;
        }
    
        /**
         * The title
         * 
         * @param title The title
         * @return this
         */
        public NotificationCreator setTitle(string title) {
            this.title = title;
            return this;
        }
    
        /**
         * The sound
         * 
         * @param sound The sound
         * @return this
         */
        public NotificationCreator setSound(string sound) {
            this.sound = sound;
            return this;
        }
    
        /**
         * The action
         * 
         * @param action The action
         * @return this
         */
        public NotificationCreator setAction(string action) {
            this.action = action;
            return this;
        }
    
        /**
         * The data
         * 
         * @param data The data
         * @return this
         */
        public NotificationCreator setData(string data) {
            this.data = data;
            return this;
        }
    
        /**
         * The apn
         * 
         * @param apn The apn
         * @return this
         */
        public NotificationCreator setApn(string apn) {
            this.apn = apn;
            return this;
        }
    
        /**
         * The gcm
         * 
         * @param gcm The gcm
         * @return this
         */
        public NotificationCreator setGcm(string gcm) {
            this.gcm = gcm;
            return this;
        }
    
        /**
         * The sms
         * 
         * @param sms The sms
         * @return this
         */
        public NotificationCreator setSms(string sms) {
            this.sms = sms;
            return this;
        }
    
        /**
         * The facebook_messenger
         * 
         * @param facebookMessenger The facebook_messenger
         * @return this
         */
        public NotificationCreator setFacebookMessenger(Object facebookMessenger) {
            this.facebookMessenger = facebookMessenger;
            return this;
        }
    
        #if NET40
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created NotificationResource
         */
        public override async Task<NotificationResource> CreateAsync(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.NOTIFY,
                "/v1/Services/" + this.serviceSid + "/Notifications"
            );
            
            addPostParams(request);
            var response = await client.RequestAsync(request);
            if (response == null)
            {
                throw new ApiConnectionException("NotificationResource creation failed: Unable to connect to server");
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
            
            return NotificationResource.FromJson(response.Content);
        }
        #endif
    
        /**
         * Make the request to the Twilio API to perform the create
         * 
         * @param client ITwilioRestClient with which to make the request
         * @return Created NotificationResource
         */
        public override NotificationResource Create(ITwilioRestClient client) {
            var request = new Request(
                Twilio.Http.HttpMethod.POST,
                Domains.NOTIFY,
                "/v1/Services/" + this.serviceSid + "/Notifications"
            );
            
            addPostParams(request);
            var response = client.Request(request);
            if (response == null)
            {
                throw new ApiConnectionException("NotificationResource creation failed: Unable to connect to server");
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
            
            return NotificationResource.FromJson(response.Content);
        }
    
        /**
         * Add the requested post parameters to the Request
         * 
         * @param request Request to add post params to
         */
        private void addPostParams(Request request) {
            if (identity != null) {
                request.AddPostParam("Identity", identity.ToString());
            }
            
            if (tag != null) {
                request.AddPostParam("Tag", tag.ToString());
            }
            
            if (body != null) {
                request.AddPostParam("Body", body);
            }
            
            if (priority != null) {
                request.AddPostParam("Priority", priority.ToString());
            }
            
            if (ttl != null) {
                request.AddPostParam("Ttl", ttl.ToString());
            }
            
            if (title != null) {
                request.AddPostParam("Title", title);
            }
            
            if (sound != null) {
                request.AddPostParam("Sound", sound);
            }
            
            if (action != null) {
                request.AddPostParam("Action", action);
            }
            
            if (data != null) {
                request.AddPostParam("Data", data);
            }
            
            if (apn != null) {
                request.AddPostParam("Apn", apn);
            }
            
            if (gcm != null) {
                request.AddPostParam("Gcm", gcm);
            }
            
            if (sms != null) {
                request.AddPostParam("Sms", sms);
            }
            
            if (facebookMessenger != null) {
                request.AddPostParam("FacebookMessenger", facebookMessenger.ToString());
            }
        }
    }
}