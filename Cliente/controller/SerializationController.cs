using Cliente.model;
using Cliente.view;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cliente.controller
{
    public class SerializationController
    {
        public static void DeserializeClientsJson()
        {
            Interface @interface = new();
            Client client = new();            
            Data? data = new();

            var path = "C:\\Users\\silve\\source\\repos\\ExerciciosRevisaoParte3\\Cliente\\data\\clientes.json";

            string jsonString;
            
            jsonString = File.ReadAllText(path);

            //Deserializa o Json, adiciona cada cliente a uma lista "clients" e executa o validador mestre sob a lista
            var clients = JsonSerializer.Deserialize<List<Data>>(jsonString);
            data = clients?.First();
            for (int i = 0; i < clients?.Count; i++)
            {
                _ = clients[i];
            }
            ClientController.ValidatorMaster(clients, @interface, client);
        }
        
        public static void SerializeErrorsJson(Data rclientsData, Erro erro) 
        {
            List<Erro> list= new List<Erro> {erro};
            RootErros root = new()
            {
                Dados = rclientsData,
                Erros = list,
            };
            addRootErrors(root);
            //var fileName = "erros.json";
            //PrettyWrite(root, fileName);
        }
        public static void addRootErrors(RootErros r)
        {
            List<RootErros> errosList = new List<RootErros> { r };
            errosList.Add(r);
            var fileName = "erros.json";
            PrettyWrite(errosList, fileName);
        }

        private static readonly JsonSerializerOptions _options =
        new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public static void PrettyWrite(List<RootErros> rootErros, string fileName)
        {
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(rootErros, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine(jsonString);
        }
    }
}
