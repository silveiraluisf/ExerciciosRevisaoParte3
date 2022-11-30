using RemoveRepetidos;
using System.Linq;

public class Program
{
    //Referências:
    //Método para remoção de obj repetidos usando ToHashSet: https://code-maze.com/remove-duplicates-from-a-list-csharp/
    public static void Main()
    {
        var testeList = new MyList<int>();
        testeList.ListWithDuplicates = new List<int>() { 1, 2, 3, 4, 5, 1, 2, 3, 4 };

        Console.WriteLine("---- REMOVEDOR DE OBJETOS REPETIDOS NA LISTA ----");
        //Console.WriteLine("");
        Console.WriteLine("\nLISTA INICIAL COM OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testeList.ListWithDuplicates));

        Console.WriteLine("\nRESULTADO DA LISTA APÓS A REMOÇÃO DOS OBJETOS REPETIDOS:");
        Console.WriteLine("Lista = {0}", string.Join(",", testeList.ListWithDuplicates.ConvertingToHashSet()));

    }
}
