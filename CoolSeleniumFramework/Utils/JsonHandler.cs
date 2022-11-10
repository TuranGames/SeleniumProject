using CoolSmFramework.CoolSeleniumFramework.Utils;
using Newtonsoft.Json;

namespace CoolSmFramework.Utils
{
    public static class JsonHandler
    {
        public static string Tojson(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static void WriteToJson<T>(this List<T> objs)
        {
            List<T> ob =  new List<T>();
            if (GetAll<T>() != null && GetAll<T>().Count != 0)
            {
                ob = GetAll<T>();
            }
            foreach (T obj in objs)
            {
                ob.Add(obj);
            }
            String path = Directories.ConfigDirectory + "UserData.json";
            File.WriteAllText(path, Tojson(ob));
        }

        public static void WriteToJson<T>(this T obj)
        {
            List<T> ob = new List<T>();
            if (GetAll<T>() != null)
            {
                ob = GetAll<T>();
                ob.Add(obj);
            }
            else
            {
                ob.Add(obj);
            }
            String path = Directories.ConfigDirectory + "UserData.json";
            File.WriteAllText(path, Tojson(ob));
        }

        public static List<T> GetAll<T>()
        {
            String path = Directories.ConfigDirectory + "UserData.json";
            string jsonText = File.ReadAllText(path);
            return JsonToObject<List<T>>(jsonText);
        }

        public static T JsonToObject<T>(string str)
        {
            return JsonConvert.DeserializeObject<T>(str);
        }
    }
}
