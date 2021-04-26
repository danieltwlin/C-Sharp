using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.Json;

namespace HttpClient_DingMsg
{
    class Program
    {    
        static async Task <String> DingMsg(String url,String msg)
        {
            // Post Data            
            string json = @"{
                                msgtype: 'text',
                                text: {
                                    content: '"+msg+ @"' },
                                at: {
                                    atMobiles: [
                                        '156xxxx8827',
                                        '189xxxx8325'
                                    ],
                                    isAtAll: false
                                }
                            }";
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            using var client = new HttpClient();

            // PostAsync 
            var response = await client.PostAsync(url, data);

            // Get Response 
            string result = response.Content.ReadAsStringAsync().Result;

            //Console.WriteLine(result);
          
            return result;
        }


        static async Task Main()
        {
            String url = "http://httpbin.org/post";
            url = "https://oapi.dingtalk.com/robot/send?access_token=";


            String msg = "hell world";
            String ret  = await DingMsg(url, msg);


            Console.ReadKey();
        }
    }
}

