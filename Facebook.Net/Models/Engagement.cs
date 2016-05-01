using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Engagement
    {
        public int Count;
        [JsonProperty("count_string")]
        public string CountString;
        [JsonProperty("count_string_with_like")]
        public string CountStringWithLike;
        [JsonProperty("count_string_without_like")]
        public string CountStringWithoutLike;
        [JsonProperty("social_sentence")]
        public string SocialSentence;
        [JsonProperty("social_sentence_with_like")]
        public string SocialSentenceWithLike;
        [JsonProperty("social_sentence_without_like")]
        public string SocialSentenceWithoutLike;
    }
}
