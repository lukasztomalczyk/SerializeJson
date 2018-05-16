using System;
using Newtonsoft.Json;

namespace SerializeJson
{
    static class ConverterJsonBothSide
    {
        public static string SerializeObject(this object item)
        {
            return JsonConvert.SerializeObject(item);
        }

        public static object DesializeObject(string item, Type typeOfObject)
        {
            return JsonConvert.DeserializeObject(item, typeOfObject);
        }
    }
}