namespace NumeroAmstrong
{
    public static class IsAmstrong
    {
        // Verifica se o numero é um Número de Armstrong
        public static bool IsArmstrong(this AmstrongNumbers obj, int x)
        {
            // chama o método para calcular a ordem do numero
            int ordem = obj.Ordem(x);
            int temp = x, soma = 0;
            while (temp != 0)
            {
                int resto = temp % 10;
                soma = soma + obj.Potencia(resto, ordem);
                temp = temp / 10;
            }
            // a condição foi satisfeita retorna true
            return (soma == x);
        }
    }
}
