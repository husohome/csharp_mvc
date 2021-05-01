using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PM25
{
    class PM25Service
    {

        public static async Task<PM25> GetDataAsync() {

            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://data.epa.gov.tw/api/v1/aqx_p_02?limit=1000&api_key=9be7b239-557b-4c10-9775-78cadfc555e9&format=json")
            }) {

                var response = await client.SendAsync(request);
                var responseText = await response.Content.ReadAsStringAsync();
                // responseText = responseText.Replace("__", "");
                var result = JsonConvert.DeserializeObject<PM25>(responseText);
                return result;

            }

        }

        public static List<Record> Filter(PM25 pm25Data, double thresh)
        {
            var filtered = from r in pm25Data.records
                           where double.Parse(r.PM25) >= thresh
                           select r;
            return filtered.ToList();
        }
    }
}
