using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Models
{
    public class Page
    {
        public string ID;
        public string About;
        [JsonProperty("access_token")]
        public string AccessToken;
        [JsonProperty("ad_campaign")]
        public AdCampaign AdCampaign;
        public string Affiliation;
        [JsonProperty("app_id")]
        public string AppID;
        [JsonProperty("app_links")]
        public AppLinks AppLinks;
        [JsonProperty("artists_we_like")]
        public string ArtistsWeLike;
        public string Attire;
        [JsonProperty("band_interests")]
        public string BandInterests;
        [JsonProperty("band_members")]
        public string BandMembers;
        [JsonProperty("best_page")]
        public Page BestPage;
        public string Bio;
        public string Birthday;
        [JsonProperty("booking_agent")]
        public string BookingAgent;
        public string Built;
        public BusinessManager Business; // No object type given in docs - assuming same as BusinessOwner
        [JsonProperty("can_checkin")]
        public bool? CanCheckin;
        [JsonProperty("can_post")]
        public bool? CanPost;
        public string Category;
        [JsonProperty("category_list")]
        public List<PageCategory> CategoryList;
        public int checkins;
        [JsonProperty("company_overview")]
        public string CompanyOverview;
        [JsonProperty("contact_address")]
        public MailingAddress ContactAddress;
        public OpenGraphContext Context;
        [JsonProperty("country_page_likes")]
        public int CountryPageLikes;
        public CoverPhoto cover;
        [JsonProperty("culinary_item")]
        public string CulinaryItem;
        [JsonProperty("current_location")]
        public string CurrentLocation;
        public string Description;
        [JsonProperty("description_html")]
        public string DescriptionHtml;
        [JsonProperty("directed_by")]
        public string DirectedBy;
        [JsonProperty("display_subtext")]
        public string DisplaySubtext;
        public List<string> Emails;
        public Engagement Engagement;
        [JsonProperty("fan_count")]
        public int FanCount;
        [JsonProperty("featured_video")]
        public Video FeaturedVideo;
        public string Features;
        [JsonProperty("food_styles")]
        public List<string> FoodStyles;
        public string Founded;
        [JsonProperty("general_info")]
        public string GeneralInfo;
        [JsonProperty("general_manager")]
        public string GeneralManager;
        public string Genre;
        [JsonProperty("global_brand_page_name")]
        public string GlobalBrandPageName;
        [JsonProperty("global_brand_root_id")]
        public string GlobalBrandRootID;
        [JsonProperty("has_added_app")]
        public bool? HasAddedApp;
        public string Hometown;
        public Tuple<string, string> Hours; // Will a tuple work for this one?
        public string Impressum;
        public string Influences;
        [JsonProperty("is_always_open")]
        public bool? IsAlwaysOpen;
        [JsonProperty("is_community_page")]
        public bool? IsCommunityPage;
        [JsonProperty("is_permanently_closed")]
        public bool? IsPermanentlyClosed;
        [JsonProperty("is_published")]
        public bool? IsPublished;
        [JsonProperty("is_unclaimed")]
        public bool? IsUnclaimed;
        [JsonProperty("is_verified")]
        public bool? IsVerified;
        [JsonProperty("last_used_time")]
        public DateTime LastUsedTime;
        [JsonProperty("leadgen_tos_accepted")]
        public bool? LeadGenTOSAccepted;
        public string Link;
        public Location Location;
        public string Members;
        public string Mission;
        public string MPG;
        public string Name;
        [JsonProperty("name_with_location_descriptor")]
        public string NameWithLocationDescriptor;
        public string Network;
        [JsonProperty("new_like_count")]
        public int NewLikeCount;
        [JsonProperty("offer_eligible")]
        public bool? OfferEligible;
        [JsonProperty("owner_business")]
        public BusinessManager OwnerBusiness;
        [JsonProperty("parent_page")]
        public Page ParentPage;
        public PageParking Parking;
        [JsonProperty("payment_options")]
        public PagePaymentOptions PaymentOptions;
        [JsonProperty("personal_info")]
        public string PersonalInfo;
        [JsonProperty("personal_interests")]
        public string PersonalInterests;
        [JsonProperty("pharma_safety_info")]
        public string PharmaSafetyInfo;
        public string Phone;
        [JsonProperty("place_type")]
        public string PlaceType; // Enum
        [JsonProperty("plot_outline")]
        public string PlotOutline;
        [JsonProperty("press_contact")]
        public string PressContact;
        [JsonProperty("price_range")]
        public string PriceRange;
        [JsonProperty("produced_by")]
        public string ProducedBy;
        public string Products;
        [JsonProperty("promotion_eligible")]
        public bool? PromotionEligible;
        [JsonProperty("promotion_ineligible_reason")]
        public string PromotionIneligibleReason;
        [JsonProperty("public_transit")]
        public string PublicTransit;
        [JsonProperty("record_label")]
        public string RecordLabel;
        [JsonProperty("release_date")]
        public string ReleaseDate;
        [JsonProperty("restaurant_services")]
        public PageRestaurantServices RestaurantServices;
        [JsonProperty("restaurant_specialties")]
        public PageRestaurantSpecialties RestaurantSpecialties;
        public string Schedule;
        [JsonProperty("screenplay_by")]
        public string ScreenplayBy;
        public string Season;
        [JsonProperty("single_line_address")]
        public string SingleLineAddress;
        public string Starring;
        [JsonProperty("start_info")]
        public PageStartInfo StartInfo;
        [JsonProperty("store_location_descriptor")]
        public string StoreLocationDescriptor;
        [JsonProperty("store_number")]
        public int StoreNumber;
        public string Studio;
        [JsonProperty("supports_instant_articles")]
        public bool? SupportsInstantArticles;
        [JsonProperty("talking_about_count")]
        public int TalkingAboutCount;
        [JsonProperty("unread_message_count")]
        public int UnreadMessageCount;
        [JsonProperty("unread_notif_count")]
        public int UnreadNotificationCount;
        [JsonProperty("unseen_message_count")]
        public int UnseenMessageCount;
        public string Username;
        [JsonProperty("verification_status")]
        public string VerificationStatus;
        [JsonProperty("voip_info")]
        public VoipInfo VoipInfo;
        public string Website;
        [JsonProperty("were_here_count")]
        public int WereHereCount;
        [JsonProperty("written_by")]
        public string WrittenBy;
    }
}
