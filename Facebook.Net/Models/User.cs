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
        public int id;
        public string ageRange; // Object
        public string bio;
        public string birthday;
        public string context; // Object
        public string cover; // Object
        public string currency; // Object
        public List<string> devices; // Object
        public List<string> education; // Object
        public string email;
        public List<Experience> favorite_athletes;
        public List<Experience> favorite_teams;
        public string first_name;
        public string gender;
        public string hometown; //Object
        public List<Experience> inspirational_people;
        public string install_type; // Enum
        public bool? installed;
        public List<string> interested_in;
        public bool? is_shared_login;
        public bool? is_verified;
        public List<Experience> languages;
        public string last_name;
        public string link;
        public string locale;
        public string location; // Object
        public List<string> meeting_for; // Object
        public string middle_name;
        public string name;
        public string name_format;
        public string payment_pricepoints; // Object
        public string political;
        public string public_key;
        public string quotes;
        public string relationship_status;
        public string religion;
        public string security_settings; // Object
        public string shared_login_upgrade_required_by; // DateTime
        public string significant_other; // Object
        public List<Experience> sports;
        public int test_group;
        public string third_party_id;
        public float timezone;
        public string token_for_business;
        public DateTime updated_time;
        public bool? verified;
        public string video_upload_limits; // Object
        public bool? viewer_can_send_gift;
        public string website;
        public List<string> work; // Object
    }
}
