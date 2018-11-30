/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using System;
using System.Collections.Generic;
using System.Linq;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Chat.V2.Service.Channel 
{

    /// <summary>
    /// FetchMemberOptions
    /// </summary>
    public class FetchMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// Sid of the Service this member belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this member belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the member to fetch.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this member belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this member belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the member to fetch. </param>
        public FetchMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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
    /// CreateMemberOptions
    /// </summary>
    public class CreateMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// Sid of the Service this member belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this member belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// A unique string identifier for this User in this Service. See the access tokens docs for more details.
        /// </summary>
        public string Identity { get; }
        /// <summary>
        /// The role to be assigned to this member. Defaults to the roles specified on the Service.
        /// </summary>
        public string RoleSid { get; set; }
        /// <summary>
        /// Field used to specify the last consumed Message index for the Channel for this Member.  Should only be used when recreating a Member from a backup/separate source.
        /// </summary>
        public int? LastConsumedMessageIndex { get; set; }
        /// <summary>
        /// ISO8601 time indicating the last datetime the Member consumed a Message in the Channel.  Should only be used when recreating a Member from a backup/separate source
        /// </summary>
        public DateTime? LastConsumptionTimestamp { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Members should be set as being created.  Will be set to the current time by the Chat service if not specified.  Note that this should only be used in cases where a Member is being recreated from a backup/separate source
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Member should be set as having been last updated.  Will be set to the null by the Chat service if not specified.  Note that this should only be used in cases where a Member is being recreated from a backup/separate source  and where a Member was previously updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new CreateMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this member belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this member belongs to. </param>
        /// <param name="identity"> A unique string identifier for this User in this Service. See the access tokens docs for
        ///                more details. </param>
        public CreateMemberOptions(string pathServiceSid, string pathChannelSid, string identity)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = identity;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.Add(new KeyValuePair<string, string>("Identity", Identity));
            }

            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }

            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

    /// <summary>
    /// ReadMemberOptions
    /// </summary>
    public class ReadMemberOptions : ReadOptions<MemberResource> 
    {
        /// <summary>
        /// Sid of the Service this member belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this member belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// A unique string identifier for this User in this Service. See the access tokens docs for more details.
        /// </summary>
        public List<string> Identity { get; set; }

        /// <summary>
        /// Construct a new ReadMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this member belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this member belongs to. </param>
        public ReadMemberOptions(string pathServiceSid, string pathChannelSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            Identity = new List<string>();
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Identity != null)
            {
                p.AddRange(Identity.Select(prop => new KeyValuePair<string, string>("Identity", prop)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

    /// <summary>
    /// DeleteMemberOptions
    /// </summary>
    public class DeleteMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// Sid of the Service this member belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this member belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the member to delete.
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new DeleteMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this member belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this member belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the member to delete. </param>
        public DeleteMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
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
    /// UpdateMemberOptions
    /// </summary>
    public class UpdateMemberOptions : IOptions<MemberResource> 
    {
        /// <summary>
        /// Sid of the Service this member belongs to.
        /// </summary>
        public string PathServiceSid { get; }
        /// <summary>
        /// Key that uniquely defines the channel this member belongs to.
        /// </summary>
        public string PathChannelSid { get; }
        /// <summary>
        /// Key that uniquely defines the member to update.
        /// </summary>
        public string PathSid { get; }
        /// <summary>
        /// The role to be assigned to this member.
        /// </summary>
        public string RoleSid { get; set; }
        /// <summary>
        /// Field used to specify the last consumed Message index for the Channel for this Member.
        /// </summary>
        public int? LastConsumedMessageIndex { get; set; }
        /// <summary>
        /// ISO8601 time indicating the last datetime the Member consumed a Message in the Channel.
        /// </summary>
        public DateTime? LastConsumptionTimestamp { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Members should be set as being created.
        /// </summary>
        public DateTime? DateCreated { get; set; }
        /// <summary>
        /// The ISO8601 time specifying the datetime the Member should be set as having been last updated.
        /// </summary>
        public DateTime? DateUpdated { get; set; }
        /// <summary>
        /// An optional string metadata field you can use to store any data you wish.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        /// Construct a new UpdateMemberOptions
        /// </summary>
        /// <param name="pathServiceSid"> Sid of the Service this member belongs to. </param>
        /// <param name="pathChannelSid"> Key that uniquely defines the channel this member belongs to. </param>
        /// <param name="pathSid"> Key that uniquely defines the member to update. </param>
        public UpdateMemberOptions(string pathServiceSid, string pathChannelSid, string pathSid)
        {
            PathServiceSid = pathServiceSid;
            PathChannelSid = pathChannelSid;
            PathSid = pathSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (RoleSid != null)
            {
                p.Add(new KeyValuePair<string, string>("RoleSid", RoleSid.ToString()));
            }

            if (LastConsumedMessageIndex != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumedMessageIndex", LastConsumedMessageIndex.ToString()));
            }

            if (LastConsumptionTimestamp != null)
            {
                p.Add(new KeyValuePair<string, string>("LastConsumptionTimestamp", Serializers.DateTimeIso8601(LastConsumptionTimestamp)));
            }

            if (DateCreated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreated", Serializers.DateTimeIso8601(DateCreated)));
            }

            if (DateUpdated != null)
            {
                p.Add(new KeyValuePair<string, string>("DateUpdated", Serializers.DateTimeIso8601(DateUpdated)));
            }

            if (Attributes != null)
            {
                p.Add(new KeyValuePair<string, string>("Attributes", Attributes));
            }

            return p;
        }
    }

}