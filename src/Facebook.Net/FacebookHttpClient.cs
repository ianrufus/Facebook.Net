using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FacebookDotNet
{
    public class FacebookHttpClient
    {
        // Separate functions for GET, PUT and POST?
        // Or a switch statement like below?
        public async Task<T> GetObject<T>(string url, HttpContent data = null)
        {
            // Would look something like this...
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(responseJson);
                    //do something with the response here. Typically use JSON.net to deserialise it and work with it
                }
                else
                {
                    // Error?
                }
            }
            return default(T);
        }

        public async Task<T> PostObject<T>(string url, byte[] data)
        {
            using (var client = new HttpClient())
            {
                using (var uploadContent = new MultipartFormDataContent())
                {
                    uploadContent.Add(new System.Net.Http.StreamContent(new System.IO.MemoryStream(data)), "source");

                    client.BaseAddress = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Clear();
                    HttpResponseMessage response = await client.PostAsync(url, uploadContent);

                    if (response.IsSuccessStatusCode)
                    {
                        var responseJson = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<T>(responseJson);
                        //do something with the response here. Typically use JSON.net to deserialise it and work with it
                    }
                    else
                    {
                        // Error?
                    }
                }
            }
            return default(T);
        }

        public async Task<T> PutAsync<T>(string url, HttpContent data)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                HttpResponseMessage response = await client.PutAsync(url, data);

                if (response.IsSuccessStatusCode)
                {
                    var responseJson = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(responseJson);
                    //do something with the response here. Typically use JSON.net to deserialise it and work with it
                }
                else
                {
                    // Error?
                }
            }
            return default(T);
        }
    }
}
