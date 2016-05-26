using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Video
    {
        [JsonProperty("backdated_time")]
        public DateTime BackdatedTime;
        [JsonProperty("backdated_time_granularity")]
        public string BackdatedTimeGranularity; // Enum
        [JsonProperty("created_time")]
        public DateTime CreatedTime;
        public string Description;
        [JsonProperty("embed_html")]
        public string EmbedHtml;
        public bool? Embeddable;
        public Event Event;
        public List<VideoFormat> Format;
        public object From; // No object in the API Docs?
        public string Icon;
        public string ID;
        [JsonProperty("content_category")]
        public string ContentCategory; // Enum
        [JsonProperty("content_tags")]
        public List<string> ContentTags;
        [JsonProperty("is_crossposting_eligible")]
        public bool? IsCrossPostingEligible;
        [JsonProperty("is_instagram_eligible")]
        public bool? IsInstagramEligible;
        [JsonProperty("is_reference_only")]
        public bool? IsReferenceOnly;
        public float Length;
        [JsonProperty("live_audience_count")]
        public int LiveAudienceCount;
        [JsonProperty("live_status")]
        public string LiveStatus; // Enum
        [JsonProperty("permalink_url")]
        public string PermalinkUrl;
        public string Picture;
        public Place Place;
        public Privacy Privacy;
        public bool? Published;
        [JsonProperty("scheduled_publish_time")]
        public DateTime ScheduledPublishTime;
        public string Source;
        public VideoStatus Status;
        public string Title;
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
    }
}
