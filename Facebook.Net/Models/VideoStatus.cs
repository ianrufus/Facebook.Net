using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class VideoStatus
    {
        [JsonProperty("processing_progress")]
        public int ProcessingProgress;
        [JsonProperty("video_status")]
        public VideoStatusEnum Status;
    }
}
