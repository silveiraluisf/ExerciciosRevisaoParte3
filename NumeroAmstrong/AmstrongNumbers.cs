using System.Runtime.CompilerServices;

namespace NumeroAmstrong
{
    public class AmstrongNumbers
    {
        // Método para calcular a potência de um numero elevado a outro
        public int Potencia(int x, long y)
        {
            if (y == 0)
                return 1;
            if (y % 2 == 0)
                return Potencia(x, y / 2) *
                       Potencia(x, y / 2);
            return x * Potencia(x, y / 2) *
                       Potencia(x, y / 2);
        }
        // Método para calcular a ordem do numero
        public int Ordem(int x)
        {
            int n = 0;
            while (x != 0)
            {
                n++;
                x = x / 10;
            }
            return n;
        }
        //Método para calcular os números de Amstrong de 0 a 10000 usando o método de extensão IsAmstrong
        public void Armstrong10000()
        {
            Console.WriteLine("Números de Armstrong entre 1 e 10000 \n");
            for (int numero = 1; numero <= 10000; numero++)
            {
                if (IsAmstrong.IsArmstrong(this, numero))
                {
                    Console.WriteLine($"{numero}");
                }
            }
        }
    }

}
