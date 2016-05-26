using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class AppLinks
    {
        public string ID;
        public List<AndroidAppLink> Android;
        public List<IOSAppLink> IOS;
        public List<IOSAppLink> IPad;
        public List<IOSAppLink> IPhone;
        public WebAppLink Web;
        public List<WindowsAppLink> Windows;
        [JsonProperty("windows_phone")]
        public List<WindowsPhoneAppLink> WindowsPhone;
        [JsonProperty("windows_universal")]
        public List<WindowsAppLink> WindowsUniversal;
    }
}
