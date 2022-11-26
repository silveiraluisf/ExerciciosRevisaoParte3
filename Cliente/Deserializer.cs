using System;
using System.Text.Json;

namespace Cliente
{
    public class Deserializer
    {
        public Deserializer? DeserializerUsingGenericSystemTextJson(string json)
        {
            var clients = JsonSerializer.Deserialize<Deserializer>(json, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
            return clients;
        }
    }
}
