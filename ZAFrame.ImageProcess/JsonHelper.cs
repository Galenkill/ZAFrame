using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
namespace ZAFrame.ImageProcess
{
    public class JsonHelper
    {
        public static string SerializeObject(object Data)
        {
            return JsonConvert.SerializeObject(Data, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
        }
        public static object Deserialize(string str)
        {
            return JsonConvert.DeserializeObject(str, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.All });
        }

    }
}
