using Cliente.model;
using System.Text.Json;

namespace Cliente
{
    public class Program
    {
        public static Client DeserializedJsonClient { get; set; } = default!;

        public static void Main()
        {
            Console.WriteLine("---------- Reading JSON file");
            var jsonStr = File.ReadAllText("data/cliente.json");

            Console.WriteLine();

            Console.WriteLine("---------- Deserialize using Generic System.Text.Json");
            DeserializedJsonClient = JsonSerializer.Deserialize<Client>(jsonStr)!;

            Console.WriteLine("End of execution");
        }
    }
}
