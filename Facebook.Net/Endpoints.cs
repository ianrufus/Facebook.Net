using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookDotNet
{
    /// <summary>
    /// Class for storing readonly strings for all available endpoints for the Graph API.
    /// All strings are stored as statics so they're easy to access throughout the SDK
    /// </summary>
    public class Endpoints
    {
        // Keep root endpoint separate, but used in other endpoints
        // This simplifies creating the URLs for each call (rather than appending every time it's used)
        // And gives a single update place to use for changing the address
        // Actually - will that work given we need to insert the access token...?
        //      - looks like that's appended along with parameters, so root should be fine
        public static readonly string ROOT_API = @"https://graph.facebook.com";
        public static readonly string OAUTH_ROOT = @"https://www.facebook.com/v2.2/dialog/oauth";
        public static readonly string MY_PROFILE = ROOT_API + @"/me";
        public static readonly string MY_FEED = MY_PROFILE + @"/feed";
    }
}
