using Cliente.model;
using System.Text.Json;

namespace Cliente
{
    public class Program
    {
        static void Main(string[] args)
        {

            var path = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\Cliente\\data\\clientes.json";

            string jsonString;
            _ = new Root();

            jsonString = File.ReadAllText(path); //GetType().Name = String

            //Console.WriteLine(jsonString); //WORKS           

            var clients = JsonSerializer.Deserialize<List<Root>>(jsonString);
            Root? client = clients?.First();
            foreach (Root c in clients)
                {
                Console.WriteLine($"Nome: {c.Nome}");
            }
            
        }
    }
}
