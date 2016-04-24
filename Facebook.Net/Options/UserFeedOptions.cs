using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet.Options
{
    /// <summary>
    /// Field options when retrieving user's feed.
    /// If no fields are provided, returns with id, created_time and description.
    /// </summary>
    public class UserFeedOptions
    {
        public bool id;
        public bool admin_creator;
        public bool application;
        public bool call_to_action;
        public bool caption;
        public bool created_time;
        public bool description;
        public bool feed_targeting;
        public bool from;
        public bool icon;
        public bool is_hidden;
        public bool is_published;
        public bool link;
        public bool message;
        public bool message_tags;
        public bool name;
        public bool object_id;
        public bool parent_id;
        public bool picture;
        public bool place;
        public bool privacy;
        public bool properties;
        public bool shares;
        public bool source;
        public bool status_type;
        public bool story;
        public bool story_tags;
        public bool targeting;
        public bool to;
        public bool type;
        public bool updated_time;
        public bool with_tags;
    }
}
