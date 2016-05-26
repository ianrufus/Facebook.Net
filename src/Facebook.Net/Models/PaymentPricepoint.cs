using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class PaymentPricepoint
    {
        public float Credits;
        [JsonProperty("local_currency")]
        public string LocalCurrency;
        [JsonProperty("user_price")]
        public string UserPrice;
    }
}
