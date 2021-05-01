using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WebPrac
{
    class BikeService
    {

        public static async Task<List<BSite>> GetBikeDataAsync() 
        {
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage() {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://data.ntpc.gov.tw/api/datasets/71CD1490-A2DF-4198-BEF1-318479775E8A/json")
            })
            {
                var response = await client.SendAsync(request);
                var responseBody = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<BSite>>(responseBody);
                return result;
            }


        }

    }
}
