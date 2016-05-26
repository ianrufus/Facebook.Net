using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class ProfilePictureSource
    {
        public int Height;
        [JsonProperty("is_silhouette")]
        public bool IsSilhouette;
        public string Url;
        public int Width;
    }
}
