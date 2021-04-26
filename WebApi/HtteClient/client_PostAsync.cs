using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net;
 

namespace HttpClient_Async
{
    class Program
    {
        static async Task <JObject> SendPost(String url)
        {
            // Post Data
            JObject jobject = new JObject()
            {
                new JProperty("DeviceId",1),
                new JProperty("Message",2)
            };
            //var json = JsonConvert.SerializeObject(jobject);
            var json = String.Empty;
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            //String url = "https://httpbin.org/post";
            using var client = new HttpClient();

            // PostAsync 
            var response = await client.PostAsync(url, data);

            // Get Response 
            string result = response.Content.ReadAsStringAsync().Result;           
            
            //Console.WriteLine(result);
            JObject job2  = (JObject)  JsonConvert.DeserializeObject(result);

            return job2;
        }

        static async Task Main()
        {
            String url = "http://httpbin.org/post";           
            
            JObject jb =  await SendPost(url);
            Console.WriteLine(jb);

            Console.ReadKey();
        }
    }
}
