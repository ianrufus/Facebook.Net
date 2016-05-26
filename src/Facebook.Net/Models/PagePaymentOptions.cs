using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class PagePaymentOptions
    {
        public int Amex;
        [JsonProperty("cash_only")]
        public int CashOnly;
        public int Discover;
        public int MasterCard;
        public int Visa;
    }
}
