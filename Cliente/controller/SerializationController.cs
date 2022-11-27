using Cliente.model;
using Cliente.view;
using System.Text.Json;

namespace Cliente.controller
{
    public class SerializationController
    {
        public static void DeserializeClientsJson()
        {
            Interface a = new();
            Client c = new();
            Erro e = new();
            RootErros re = new();
            var path = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\Cliente\\data\\clientes.json";

            string jsonString;
            _ = new Root();

            jsonString = File.ReadAllText(path);

            var clients = JsonSerializer.Deserialize<List<Root>>(jsonString);
            _ = clients?.First();
            for (int i = 0; i < clients?.Count; i++)
            {
                _ = clients[i];
            }
            ClientController.ValidatorMaster(clients, a, c, e);
            SerializeErrorsJson(e);
        }

        public static void SerializeErrorsJson(Erro errors)
        {
            //var errors = new RootErros();
            var fileName = "erros.json";
            PrettyWrite(errors, fileName);
        }

        public static void PrettyWrite(Erro rootErros, string fileName)
        {
            var jsonString = JsonSerializer.Serialize(rootErros);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(jsonString);
        }
    }
}
