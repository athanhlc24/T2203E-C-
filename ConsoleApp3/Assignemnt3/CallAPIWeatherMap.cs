using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TT2203E.session5;

namespace TT2203E.Assignemnt3
{
    public class CallAPIWeatherMap
    {
        public CallAPIWeatherMap() { }
        public async Task<Product> FetchDataWeather()
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=Hanoi,vietnam&appid=09a71427c59d38d6a34f89b47d75975c&units=metric";
            HttpClient client = new HttpClient();
            var rs = await client.GetAsync(url);
            if (rs.StatusCode == HttpStatusCode.OK)
            {
                string responseTextWeather = await rs.Content.ReadAsStringAsync();
                Product p = JsonConvert.DeserializeObject<Product>(responseTextWeather);
                return p;

            }

            return null;
        }
    }
}
