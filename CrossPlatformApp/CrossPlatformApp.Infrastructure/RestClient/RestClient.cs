using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CrossPlatformApp.Infrastructure.RestClient
{
    public class RestClient<T>
    {
       // 

        public async Task <List<T>> GetListAsync(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<List<T>>(json);
            }
        }

        public async Task<T> GetAsync(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                var json = await httpClient.GetStringAsync(uri);
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
}
