using RemoveRepetidos;

public class Program
{
    //Referências:
    //Método para remoção de obj repetidos usando ToHashSet: https://code-maze.com/remove-duplicates-from-a-list-csharp/
    public static void Main()
    {
        var testListInt = new MyList<int>();
        testListInt.ListWithDuplicates = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };
        var testListString = new MyList<string>();
        testListString.ListWithDuplicates = new List<string>() { "a", "b", "c", "d", "a", "e", "f", "e"};

        Console.WriteLine("---- REMOVEDOR DE OBJETOS REPETIDOS NA LISTA ----");
     
        Console.WriteLine("\nLISTA INICIAL COM INTEIROS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates.ConvertingToHashSet()));

        Console.WriteLine("\nLISTA INICIAL COM STRING REPETIDAS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListString.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListString.ListWithDuplicates.ConvertingToHashSet()));

    }
}
