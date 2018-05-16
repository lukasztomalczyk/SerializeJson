using Newtonsoft.Json;

namespace SerializeJson
{
    static class ConverterJsonBothSide
    {
        public static string SerializeObject(this object item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public static object DesializeObject(object item, typeof(type))
        {
            return JsonConvert.DeserializeObject<type>(item);
        }
    }
}