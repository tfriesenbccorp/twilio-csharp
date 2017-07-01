using System;
using System.Collections.Generic;
using Twilio.Base;
using Twilio.Converters;

namespace Twilio.Rest.Video.V1.Room 
{

    /// <summary>
    /// FetchRoomRecordingOptions
    /// </summary>
    public class FetchRoomRecordingOptions : IOptions<RoomRecordingResource> 
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The sid
        /// </summary>
        public string PathSid { get; }

        /// <summary>
        /// Construct a new FetchRoomRecordingOptions
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        /// <param name="pathSid"> The sid </param>
        public FetchRoomRecordingOptions(string pathRoomSid, string pathSid)
        {
            PathRoomSid = pathRoomSid;
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
    /// ReadRoomRecordingOptions
    /// </summary>
    public class ReadRoomRecordingOptions : ReadOptions<RoomRecordingResource> 
    {
        /// <summary>
        /// The room_sid
        /// </summary>
        public string PathRoomSid { get; }
        /// <summary>
        /// The status
        /// </summary>
        public RoomRecordingResource.StatusEnum Status { get; set; }
        /// <summary>
        /// The source_sid
        /// </summary>
        public string SourceSid { get; set; }
        /// <summary>
        /// The date_created_after
        /// </summary>
        public DateTime? DateCreatedAfter { get; set; }
        /// <summary>
        /// The date_created_before
        /// </summary>
        public DateTime? DateCreatedBefore { get; set; }

        /// <summary>
        /// Construct a new ReadRoomRecordingOptions
        /// </summary>
        ///
        /// <param name="pathRoomSid"> The room_sid </param>
        public ReadRoomRecordingOptions(string pathRoomSid)
        {
            PathRoomSid = pathRoomSid;
        }

        /// <summary>
        /// Generate the necessary parameters
        /// </summary>
        public override List<KeyValuePair<string, string>> GetParams()
        {
            var p = new List<KeyValuePair<string, string>>();
            if (Status != null)
            {
                p.Add(new KeyValuePair<string, string>("Status", Status.ToString()));
            }

            if (SourceSid != null)
            {
                p.Add(new KeyValuePair<string, string>("SourceSid", SourceSid.ToString()));
            }

            if (DateCreatedAfter != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedAfter", Serializers.DateTimeIso8601(DateCreatedAfter)));
            }

            if (DateCreatedBefore != null)
            {
                p.Add(new KeyValuePair<string, string>("DateCreatedBefore", Serializers.DateTimeIso8601(DateCreatedBefore)));
            }

            if (PageSize != null)
            {
                p.Add(new KeyValuePair<string, string>("PageSize", PageSize.ToString()));
            }

            return p;
        }
    }

}