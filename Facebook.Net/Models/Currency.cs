using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Currency
    {
        [JsonProperty("currency_offset")]
        public int CurrencyOffset;
        [JsonProperty("usd_exchange")]
        public float USDExchange;
        [JsonProperty("usd_exchange_inverse")]
        public float USDExchangeInverse;
        [JsonProperty("user_currency")]
        public string UserCurrency;
    }
}
