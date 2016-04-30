using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    // Would it be better to use proper names, with known names for deserializing? Or are we not bothered?
    // Also need to consider folder structures for models - might make sense to base this based on which nodes are used where
    public class User
    {
        // This is based on a user profile - different for other profile types? e.g. pages etc
        public string ID;
        [JsonProperty("age_range")]
        public string AgeRange; // Object
        public string Bio;
        public string Birthday;
        public string Context; // Object
        public string Cover; // Object
        public string Currency; // Object
        public List<string> Devices; // Object
        public List<string> Education; // Object
        public string Email;
        [JsonProperty("favorite_athletes")]
        public List<Experience> FavoriteAthletes;
        [JsonProperty("favorite_teams")]
        public List<Experience> FavoriteTeams;
        [JsonProperty("first_name")]
        public string FirstName;
        public string Gender;
        public string Hometown; //Object
        [JsonProperty("inspirational_people")]
        public List<Experience> InspirationalPeople;
        [JsonProperty("install_type")]
        public string InstallType; // Enum
        public bool? Installed;
        [JsonProperty("interested_in")]
        public List<string> InterestedIn;
        [JsonProperty("is_shared_login")]
        public bool? IsSharedLogin;
        [JsonProperty("is_verified")]
        public bool? IsVerified;
        public List<Experience> Languages;
        [JsonProperty("last_name")]
        public string LastName;
        public string Link;
        public string Locale;
        public string Location; // Object
        [JsonProperty("meeting_for")]
        public List<string> MeetingFor; // Object
        [JsonProperty("middle_name")]
        public string MiddleName;
        public string Name;
        [JsonProperty("name_format")]
        public string NameFormat;
        [JsonProperty("payment_pricepoints")]
        public string PaymentPricepoints; // Object
        public string Political;
        [JsonProperty("public_key")]
        public string PublicKey;
        public string Quotes;
        [JsonProperty("relationship_status")]
        public string RelationshipStatus;
        public string Religion;
        [JsonProperty("security_settings")]
        public string SecuritySettings; // Object
        [JsonProperty("shared_login_upgrade_required_by")]
        public string SharedLoginUpgradeRequiredBy; // DateTime
        [JsonProperty("significant_other")]
        public string SignificantOther; // Object
        public List<Experience> Sports;
        [JsonProperty("test_group")]
        public int TestGroup;
        [JsonProperty("third_party_id")]
        public string ThirdPartyId;
        public float Timezone;
        [JsonProperty("token_for_business")]
        public string TokenForBusiness;
        [JsonProperty("updated_time")]
        public DateTime UpdatedTime;
        public bool? Verified;
        [JsonProperty("video_upload_limits")]
        public string VideoUploadLimits; // Object
        [JsonProperty("viewer_can_send_gift")]
        public bool? ViewerCanSendGift;
        public string Website;
        public List<string> Work; // Object
    }
}
