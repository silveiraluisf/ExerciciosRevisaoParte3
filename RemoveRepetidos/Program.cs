using RemoveRepetidos;

public class Program
{
    //Referências:
    //Método para remoção de obj repetidos usando ToHashSet: https://code-maze.com/remove-duplicates-from-a-list-csharp/
    public static void Main()
    {
        var testListInt = new MyList<int>();
        testListInt.ListWithDuplicates = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };

        Console.WriteLine("---- REMOVEDOR DE OBJETOS REPETIDOS NA LISTA ----");
        //Console.WriteLine("");
        Console.WriteLine("\nLISTA INICIAL COM OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testListInt.ListWithDuplicates.ConvertingToHashSet()));

    }
}
