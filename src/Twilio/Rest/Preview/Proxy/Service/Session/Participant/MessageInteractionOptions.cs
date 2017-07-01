using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;

namespace Twilio.Rest.Preview.Proxy.Service.Session.Participant 
{

    /// <summary>
    /// Fetch a specific Interaction.
    /// </summary>
    public class CreateMessageInteractionOptions : IOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// The service_sid
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// The session_sid
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// The participant_sid
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// The body of the message. Up to 1600 characters long.
        /// </summary>
        public string Body { get; set; }
        /// <summary>
        /// The url of an image or video.
        /// </summary>
        public List<Uri> MediaUrl { get; set; }

        /// <summary>
        /// Construct a new CreateMessageInteractionOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> The service_sid </param>
        /// <param name="pathSessionSid"> The session_sid </param>
        /// <param name="pathParticipantSid"> The participant_sid </param>
        public CreateMessageInteractionOptions(string pathServiceSid, string pathSessionSid, string pathParticipantSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
            MediaUrl = new List<Uri>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Body != null)
            {
                p.Add(new KeyValuePair<string, string>("Body", Body));
            }

            if (MediaUrl != null)
            {
                p.AddRange(MediaUrl.Select(prop => new KeyValuePair<string, string>("MediaUrl", prop.AbsoluteUri)));
            }

            return p;
        }
    }

    /// <summary>
    /// Fetch a specific Message Interaction.
    /// </summary>
    public class FetchMessageInteractionOptions : IOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        public string PathParticipantSid { get; }
        /// <summary>
        /// A string that uniquely identifies this Interaction.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMessageInteractionOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        /// <param name="pathSid"> A string that uniquely identifies this Interaction. </param>
        public FetchMessageInteractionOptions(string pathServiceSid, string pathSessionSid, string pathParticipantSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
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
    /// Retrieve a list of all Message Interactions for a Participant.
    /// </summary>
    public class ReadMessageInteractionOptions : ReadOptions<MessageInteractionResource> 
    {
        /// <summary>
        /// Service Sid.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Session Sid.
        /// </summary>
        public string PathSessionSid { get; }
        /// <summary>
        /// Participant Sid.
        /// </summary>
        public string PathParticipantSid { get; }

        /// <summary>
        /// Construct a new ReadMessageInteractionOptions
        /// </summary>
        ///
        /// <param name="pathServiceSid"> Service Sid. </param>
        /// <param name="pathSessionSid"> Session Sid. </param>
        /// <param name="pathParticipantSid"> Participant Sid. </param>
        public ReadMessageInteractionOptions(string pathServiceSid, string pathSessionSid, string pathParticipantSid)
        {
            PathServiceSid = pathServiceSid;
            PathSessionSid = pathSessionSid;
            PathParticipantSid = pathParticipantSid;
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

}