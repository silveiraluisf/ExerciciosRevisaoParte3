namespace NumeroAmstrong
{
    public class Program
    {
        // Referências:
        // Métodos de extensão: https://www.macoratti.net/18/04/c_extmet1.htm
        // Algoritmos para os cálculos dos números de Amstrong: https://www.macoratti.net/19/02/c_armstr1.htm
        public static void Main()
        {            
            AmstrongNumbers n = new AmstrongNumbers();
            
            Console.WriteLine("Números de Armstrong entre 1 e 10000 \n");
            for (int numero = 1; numero <= 10000; numero++)
            {
                if (n.IsAmstrong(numero))
                {
                    Console.WriteLine($"{numero}");
                }
            }
        }
    }
}