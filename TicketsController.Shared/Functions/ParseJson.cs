using Newtonsoft.Json;
using System.Collections.Generic;


namespace TicketsController.Shared.Functions
{
    public static class ParseJson
    {
        public static List<T> JsonToObject<T>(string data)
        {
            return JsonConvert.DeserializeObject<List<T>>(data) ?? new List<T>();
        }
    }
}
