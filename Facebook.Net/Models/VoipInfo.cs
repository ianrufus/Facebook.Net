using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class VoipInfo
    {
        [JsonProperty("has_mobile_app")]
        public bool? HasMobileApp;
        [JsonProperty("has_permission")]
        public bool? HasPermission;
        [JsonProperty("is_callable")]
        public bool? IsCallable;
        [JsonProperty("is_callable_webrtc")]
        public bool? IsCallableWebRTC;
        [JsonProperty("is_pushable")]
        public bool? IsPushable;
        [JsonProperty("reason_code")]
        public int ReasonCode;
        [JsonProperty("reason_description")]
        public string ReasonDescription;
    }
}
