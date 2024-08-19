using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TOP4HoneyChains.Domain.Helpers
{
    public static class RequestHelper
    {
        public static async Task PostAsync<T>(string url, string value)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.Timeout = TimeSpan.FromSeconds(3);

                var httpResponse = await httpClient.PostAsync(url, new StringContent(value, Encoding.UTF8, "application/json"));
            }
        }

        public static async Task<T> GetAsync<T>(string requestUri)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    httpClient.Timeout = TimeSpan.FromMinutes(3);
                    HttpResponseMessage httpResponseMessageawait = await httpClient.GetAsync(requestUri);
                    return JsonConvert.DeserializeObject<T>(await httpResponseMessageawait.Content.ReadAsStringAsync());
                }
            }
            catch
            {
                return default(T);
            }
        }
    }
}
