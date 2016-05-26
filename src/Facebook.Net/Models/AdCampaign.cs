using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    // Marketing API Docs aren't very clear - come back to this
    public class AdCampaign
    {
        [JsonProperty("account_id")]
        public string AccountID;
        public List<AdLabel> AdLabels;
        [JsonProperty("adset_schedule")]
        public List<string> AdSetSchedule; // DayPart object
        [JsonProperty("bid_amount")]
        public int BidAmount;
        [JsonProperty("bid_info")]
        public Tuple<string, int> BidInfo;
        [JsonProperty("billing_event")]
        public string BillingEvent; // Enum
        [JsonProperty("budget_remaining")]
        public string BudgetRemaining;
        public string Campaign; // AdCampaignGroup object
        [JsonProperty("campaign_id")]
        public string CampaignID;
        [JsonProperty("configured_status")]
        public string ConfiguredStatus; // Enum
        [JsonProperty("created_time")]
        public DateTime CreatedTime;
        [JsonProperty("creative_sequence")]
        public List<string> CreativeSequence;
        [JsonProperty("daily_budget")]
        public string DailyBudget;
        [JsonProperty("effective_status")]
        public string EffectiveStatus; // Enum
        [JsonProperty("end_time")]
        public DateTime EndTime;
        [JsonProperty("frequency_cap_reset_period")]
        public int FrequencyCapResetPeriod;
        [JsonProperty("frequency_control_specs")]
        public List<string> FrequencyControlSpecs; // AdCampaignFrequencyControlSpecs object
        public string ID;
        [JsonProperty("frequency_cap")]
        public int FrequencyCap;
        [JsonProperty("is_autobid")]
        public bool? IsAutoBid;
        [JsonProperty("lifetime_budget")]
        public string LifetimeBudget;
        [JsonProperty("lifetime_frequency_cap")]
        public int LifetimeFrequencyCap;
        [JsonProperty("lifetime_imps")]
        public int LifetimeImpressions;
        public string Name;
        [JsonProperty("optimization_goal")]
        public string OptimizationGoal; // Enum
        [JsonProperty("pacing_type")]
        public List<string> PacingType;
        [JsonProperty("promoted_object")]
        public string PromotedObject; // AdPromotedObject object
        public List<string> Recommendations; // AdRecommendations object
        [JsonProperty("rf_prediction_id")]
        public string RFPredictionID;
        [JsonProperty("rtb_flag")]
        public bool? RTBFlag;
        [JsonProperty("start_time")]
        public DateTime StartTime;
        public string Status; // Enum
        public string Targeting; // Targeting object
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
        [JsonProperty("use_new_app_click")]
        public bool? UseNewAppClick;
    }
}
