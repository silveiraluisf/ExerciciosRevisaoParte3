using Cliente.model;
using Cliente.view;
using System.Drawing;
using System.Text.Json;

namespace Cliente.controller
{
    public class SerializationController
    {
        public static void DeserializeClientsJson()
        {
            Interface @interface = new();
            Client client = new();
            Erro erro = new();
            Data? data = new Data();

            var path = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\Cliente\\data\\clientes.json";

            string jsonString;
            

            jsonString = File.ReadAllText(path);

            var clients = JsonSerializer.Deserialize<List<Data>>(jsonString);
            data = clients?.First();
            for (int i = 0; i < clients?.Count; i++)
            {
                _ = clients[i];
            }
            ClientController.ValidatorMaster(clients, @interface, client, erro);
            SerializeErrorsJson(data);
        }

        public static void SerializeErrorsJson(Data rclientsData)
        {
            var errors = ClientController.GetErrors(rclientsData);
            var fileName = "erros.json";
            PrettyWrite(errors, fileName);
        }

        public static void PrettyWrite(RootErros rootErros, string fileName)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(rootErros, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(jsonString);
        }
    }
}
