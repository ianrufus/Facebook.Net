using FacebookDotNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;

namespace FacebookDotNet
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class FacebookDotNetClient
    {
        private string _accessToken = String.Empty;
        // AppId and AppSecret needed here? Or are they just used for OAuth?
        private string _appId = String.Empty;
        private string _appSecret = String.Empty;
        private FacebookHttpClient _httpClient;
        // Just need to figure out how to structure my SDK - needs to be ridiculously easy to plug in to another project
        // Something like - create instance of FacebookDotNet passing in the access token, then call a function on it to get the object you want
        public FacebookDotNetClient(string token)
        {
            // Also needs to take in appId and appSecret as parameters??
            _accessToken = token;
            _httpClient = new FacebookHttpClient();
            // From user persepective:
            // Wants to create instance of the SDK, passing in the access token
            // And from there just call to get whatever info from a call that they want

            // So one class as an entry point, and from there methods to get what we want.
        }

        public FacebookDotNetClient(string appId, string appSecret)
        {
            _appId = appId;
            _appSecret = appSecret;
            _httpClient = new FacebookHttpClient();
        }

        public async Task<Feed> GetUserFeed()
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }

            string apiUrl = Endpoints.MY_FEED + "?access_token=" + _accessToken;

            Feed userFeed = await _httpClient.GetObject<Feed>(apiUrl, FacebookRequestType.GET);

            return userFeed;
        }

        public async Task<string> PublishPost(string message)
        {
            // Should we handle spaces in the message?
            // Or require this to be done by the user and error out on spaces?
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }

            string apiUrl = Endpoints.MY_FEED + "?access_token=" + _accessToken + ",message=" + message;
            // should there be an object that's returned from this call?
            // as far as I'm aware it's only ever the id - if successful, but what if it fails?
            string postId = await _httpClient.GetObject<string>(apiUrl, FacebookRequestType.POST);

            return postId;
        }

        public async Task<User> GetUserProfile(Options.UserProfileOptions profileOptions = null)
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }

            string apiUrl = Endpoints.MY_PROFILE + "?access_token=" + _accessToken;
            if (profileOptions != null)
            {
                apiUrl = AppendFields(apiUrl, profileOptions);
            }
            User userProfile = await _httpClient.GetObject<User>(apiUrl, FacebookRequestType.GET);

            return userProfile;
        }

        private string AppendFields(string url, object options)
        {
            if (options == null)
            {
                return String.Empty;
            }
            // Not happy with this check...
            if (options.GetType().GetFields().Length > 0)
            {
                url += "&fields=";
            }
            foreach (FieldInfo fi in options.GetType().GetFields())
            {
                if (fi.FieldType == typeof(Boolean))
                {
                    if ((fi.GetValue(options) as bool?) == true)
                    {
                        url += fi.Name + ",";
                    }
                }
            }
            return url.TrimEnd(',');
        }
    }
}
