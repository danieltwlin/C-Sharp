//建立 json object
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;

jobject = new JObject()
          {
             new JProperty("DeviceId",DeviceId),
             new JProperty("Message",sendMessage)
          };

//JSON 轉 String
jobject .ToString()

//String to JObject
JObject data = JObject.Parse(str);

Console.WriteLine(data["DeviceId"]);    // key


//或是建立 json 字串，再反序列化為 json Object
//Newtonsoft.Json反序列化
   string json = @"{ 'Name':'C#','Age':'3000','ID':'1','Sex':'女'}";
   
   Student descJsonStu = JsonConvert.DeserializeObject<Student>(json);//反序列化

   Console.WriteLine(string.Format("反序列化： ID={0},Name={1},Sex={2},Sex={3}", descJsonStu.ID, descJsonStu.Name, descJsonStu.Age, descJsonStu.Sex));
   
