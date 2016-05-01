using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Event
    {
        public string ID;
        [JsonProperty("attending_count")]
        public int AttendingCount;
        [JsonProperty("can_guests_invite")]
        public bool? CanGuestsInvite;
        public string Category; // Enum
        public CoverPhoto Cover;
        [JsonProperty("declined_count")]
        public int DeclinedCount;
        public string Description;
        [JsonProperty("end_time")]
        public string EndTime;
        [JsonProperty("guest_list_enabled")]
        public bool? GuestListEnabled;
        [JsonProperty("interested_count")]
        public int InterestedCount;
        [JsonProperty("is_page_owned")]
        public bool? IsPageOwned;
        [JsonProperty("is_viewer_admin")]
        public bool? IsViewerAdmin;
        [JsonProperty("maybe_count")]
        public int MaybeCount;
        public string Name;
        [JsonProperty("noreply_count")]
        public int NoReplyCount;
        public object Owner; // No object type given in the API Docs?
        [JsonProperty("parent_group")]
        public Group ParentGroup;
        public Place Place;
        [JsonProperty("start_time")]
        public string StartTime;
        [JsonProperty("ticket_url")]
        public string TicketUrl;
        public string Timezone; // Enum
        public string Type; // Enum
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
    }
}
