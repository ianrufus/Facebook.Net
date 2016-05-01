using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class VideoFormat
    {
        [JsonProperty("embed_html")]
        public string EmbedHtml;
        public string Filter;
        public int Height;
        public string Picture;
        public int Width;
    }
}
