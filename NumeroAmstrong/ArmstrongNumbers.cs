using System.Runtime.CompilerServices;

namespace NumeroAmstrong
{
    public class ArmstrongNumbers
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
    }
}
