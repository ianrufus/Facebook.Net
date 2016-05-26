using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class MailingAddress
    {
        public string ID;
        public string City;
        [JsonProperty("city_page")]
        public Page CityPage;
        public string Country;
        [JsonProperty("postal_code")]
        public string PostalCode;
        public string Region;
        public string Street1;
        public string Street2;
    }
}
