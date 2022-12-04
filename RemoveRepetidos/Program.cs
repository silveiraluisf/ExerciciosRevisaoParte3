using RemoveRepetidos;
using System.Security.Cryptography;

public class Program
{
    //Referências:
    //Método para remoção de obj repetidos usando ToHashSet: https://code-maze.com/remove-duplicates-from-a-list-csharp/
    public static void Main()
    {
        //criação da lista com inteiros para teste
        var testListInt = new MyList<int>();
        testListInt.ListWithDuplicates = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };

        //criação da lista de strings para teste
        var testListString = new MyList<string>();
        testListString.ListWithDuplicates = new List<string>() { "a", "b", "c", "d", "a", "e", "f", "e"};

        //criação da lista de clientes e objetos da classe ClientSimplified para teste
        var testListClient = new MyList<ClientSimplified>();
        ClientSimplified a = new() { Name= "a", CPF = 123123123, };
        ClientSimplified b = new() { Name = "b", CPF = 456456456, };
        ClientSimplified c = new() { Name = "c", CPF = 789789789, };
        ClientSimplified d = new() { Name = "d", CPF = 123123123, };
        ClientSimplified e = new() { Name = "e", CPF = 123456789, };
        testListClient.ListWithDuplicates = new List<ClientSimplified>() { a, b, c, d, e };   

        //execução do método para remover os itens repetidos
        Console.WriteLine("---- REMOVEDOR DE OBJETOS REPETIDOS NA LISTA ----");
     
        Console.WriteLine("\nLISTA INICIAL COM INTEIROS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates.ConvertingToHashSet()));

        Console.WriteLine("\nLISTA INICIAL COM STRING REPETIDAS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListString.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListString.ListWithDuplicates.ConvertingToHashSet()));

        Console.WriteLine("\nLISTA INICIAL COM OBJETOS CLIENTES REPETIDOS:");
        foreach (ClientSimplified client in testListClient.ListWithDuplicates)
        {
            Console.WriteLine($" Nome:{client.Name}, CPF: {client.CPF}");
        }
        testListClient.ListWithDuplicates.RemoveRepeatedClient();
        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        foreach (ClientSimplified client in testListClient.ListWithDuplicates)
        {
            Console.WriteLine($" Nome:{client.Name}, CPF: {client.CPF}");
        }
    }
}
