using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace IntelipostMiddleware.Integrations.External
{
    public class HttpRequestHelper
    {
        public HttpMethod method = null;
        public string requestUri = "";
        public HttpContent content = null;
        public string acceptHeader = "application/json";

        public async Task<HttpResponseMessage> SendAsync()
        {
            var request = new HttpRequestMessage
            {
                Method = this.method,
                RequestUri = new Uri(this.requestUri)
            };

            if (this.content != null)
                request.Content = this.content;
            
            request.Headers.Accept.Clear();
            if (!string.IsNullOrEmpty(this.acceptHeader))
                request.Headers.Accept.Add(
                   new MediaTypeWithQualityHeaderValue(this.acceptHeader));
            
            var client = new System.Net.Http.HttpClient();

            return await client.SendAsync(request);
        }

        public static async Task<HttpResponseMessage> Post(
           string requestUri, object value)
        {
            var builder = new HttpRequestHelper();
            builder.method = HttpMethod.Post;
            builder.requestUri = requestUri;
            builder.content = new JsonContent(value);

            return await builder.SendAsync();
        }

    }

    public class JsonContent : StringContent
    {
        public JsonContent(object value)
            : base(JsonConvert.SerializeObject(value), Encoding.UTF8,
            "application/json")
        {
        }

        public JsonContent(object value, string mediaType)
            : base(JsonConvert.SerializeObject(value), Encoding.UTF8, mediaType)
        {
        }
    }


    public static class HttpResponseExtensions
    {
        public static T ContentAsType<T>(this HttpRequestHelper response)
        {
            var data = response.content.ReadAsStringAsync().Result;
            return string.IsNullOrEmpty(data) ?
                            default(T) :
                            JsonConvert.DeserializeObject<T>(data);
        }

        public static string ContentAsJson(this HttpRequestHelper response)
        {
            var data = response.content.ReadAsStringAsync().Result;
            return JsonConvert.SerializeObject(data);
        }

        public static string ContentAsString(this HttpRequestHelper response)
        {
            return response.content.ReadAsStringAsync().Result;
        }
    }

}
