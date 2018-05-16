using Newtonsoft.Json;

namespace SerializeJson
{
    static class ConverterJsonBothSide<T> where T : class
    {
        public static string SerializeObject(T item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public static T DesializeObject(string item)
        {
            return (T)JsonConvert.DeserializeObject(item, typeof(T));
        }
    }
}