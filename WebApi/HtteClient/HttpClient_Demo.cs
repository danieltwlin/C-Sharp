using System;
using System.Net.Http;
using System.Threading.Tasks;

static readonly HttpClient client = new HttpClient();

static async Task Main()
{
  try	
  {
     HttpResponseMessage response = await client.GetAsync("http://www.google.com/");
     response.EnsureSuccessStatusCode();
     string responseBody = await response.Content.ReadAsStringAsync();
     
     Console.WriteLine(responseBody);
  }
  catch(HttpRequestException e)
  {
     Console.WriteLine("\nException Caught!");	
     Console.WriteLine("Message :{0} ",e.Message);
  }
}
