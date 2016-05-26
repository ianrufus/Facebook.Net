using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class User
    {
        public string ID;
        [JsonProperty("age_range")]
        public AgeRange AgeRange;
        public string Bio;
        public string Birthday;
        public UserContext Context;
        public CoverPhoto Cover;
        public Currency Currency;
        public List<UserDevice> Devices;
        public List<EducationExperience> Education;
        public string Email;
        [JsonProperty("favorite_athletes")]
        public List<Experience> FavoriteAthletes;
        [JsonProperty("favorite_teams")]
        public List<Experience> FavoriteTeams;
        [JsonProperty("first_name")]
        public string FirstName;
        public string Gender;
        public Page Hometown;
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
        public Page Location;
        [JsonProperty("meeting_for")]
        public List<string> MeetingFor;
        [JsonProperty("middle_name")]
        public string MiddleName;
        public string Name;
        [JsonProperty("name_format")]
        public string NameFormat;
        [JsonProperty("payment_pricepoints")]
        public PaymentPricepoints PaymentPricepoints;
        public string Political;
        [JsonProperty("public_key")]
        public string PublicKey;
        public string Quotes;
        [JsonProperty("relationship_status")]
        public string RelationshipStatus;
        public string Religion;
        [JsonProperty("security_settings")]
        public SecuritySettings SecuritySettings;
        [JsonProperty("shared_login_upgrade_required_by")]
        public DateTime SharedLoginUpgradeRequiredBy;
        [JsonProperty("significant_other")]
        public User SignificantOther;
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
        public VideoUploadLimits VideoUploadLimits;
        [JsonProperty("viewer_can_send_gift")]
        public bool? ViewerCanSendGift;
        public string Website;
        public List<WorkExperience> Work;
    }
}
