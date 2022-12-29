using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace TT2203E.session5
{
    public class CallAPI
    {
        public CallAPI() { }
        public async Task<Product> FetchData()//xử lí bất đồng bộ 
        {
            string url = "https://dummyjson.com/products/1";
            HttpClient client= new HttpClient();
            var rs = await client.GetAsync(url);
            if(rs.StatusCode == HttpStatusCode.OK)
            {
                string responseText = await rs.Content.ReadAsStringAsync();
                
            }

            return null;
        }
    }
}
