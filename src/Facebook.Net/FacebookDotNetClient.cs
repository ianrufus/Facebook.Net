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
            // Resolve the client with an IoC container?
            _httpClient = new FacebookHttpClient();
            // Get the long life token here
        }

        public async Task<Feed> GetUserFeed()
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }

            string apiUrl = Endpoints.MY_FEED + "?access_token=" + _accessToken;

            Feed userFeed = await _httpClient.GetObject<Feed>(apiUrl);

            return userFeed;
        }

        // Should this handle links as well? Or should I make that a separate method?
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
            string postId = await _httpClient.PostObject<string>(apiUrl, null);

            return postId;
        }

        public async Task<User> GetUserProfile(Options.UserProfileOptions profileOptions = null)
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }
            // Is it worth separating out generating the API Url along with appending options into a separate method?
            // Or would that grow too complex?
            string apiUrl = Endpoints.MY_PROFILE + "?access_token=" + _accessToken;
            if (profileOptions != null)
            {
                apiUrl = AppendFields(apiUrl, profileOptions);
            }
            User userProfile = await _httpClient.GetObject<User>(apiUrl);

            return userProfile;
        }

        public async Task<string> CreateAlbum()
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }
            // Replace with actual url
            string apiUrl = Endpoints.MY_PROFILE + "?access_token=" + _accessToken;
            // Options file?

            // What object type will be returned? What call type is this one?
            var result = await _httpClient.PostObject<string>(apiUrl, null);
            return result;
        }

        // Do we expect a specific video format to be passed in?
        // How does Facebook expect the video to be sent?
        public async Task<string> PostVideoToFeed()
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }
            // Replace with actual url
            string apiUrl = Endpoints.MY_PROFILE + "?access_token=" + _accessToken;
            // Options file?

            // What object type will be returned? Guessing the data to be appended will be the video file?
            var result = await _httpClient.PostObject<string>(apiUrl, null);
            return result;
        }

        /// <summary>
        /// Allows posting of one photo to the users feed
        /// </summary>
        /// <param name="photo">Byte array of the image to be uploaded</param>
        /// <returns></returns>
        public async Task<string> PostPhotoToFeed(byte[] photo)
        {
            if (String.IsNullOrWhiteSpace(_accessToken))
            {
                // Exception? How are we going to do error handling for something like this?
            }
            // Replace with actual url
            string apiUrl = Endpoints.MY_PHOTOS + "?access_token=" + _accessToken;
            // Options file?

            // Returns struct with an id and a postid
            // Needs to differentiate between posting data, and passing in a url
            var result = await _httpClient.PostObject<string>(apiUrl, photo);
            return result;
        }

        // This might be better moved to a Utility class? - To try and keep this class smaller
        private string AppendFields(string url, object options)
        {
            if (options == null)
            {
                return String.Empty;
            }
            // Not happy with this check...
            if (options.GetType().GetRuntimeFields().Count() > 0)
            {
                url += "&fields=";
            }
            foreach (FieldInfo fi in options.GetType().GetRuntimeFields())
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
