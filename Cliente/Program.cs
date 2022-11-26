using Cliente.model;
using Cliente.data;
using System.Text.Json;

namespace DeserializeJsonToPocoClass
{
    public class Program
    {
        private static readonly ClientsList _clientList = new();
        public static int OutputResult = 0;

        public static void Main()
        {
            Console.WriteLine("-------------------- Deserializing complex JSON object");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("---------- Reading JSON file");
            var json = ReadJsonFile();

            Console.WriteLine();

            Console.WriteLine("---------- Deserialize using Generic System.Text.Json");
            var clientGenericSystemText = _clientList.DeserializerUsingGenericSystemTextJson(json);

            Console.WriteLine("End of execution");

            OutputResult = 1;
        }
        public static string ReadJsonFile()
        {
            return clientes.json;
        }
    }
}
