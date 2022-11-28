using Cliente.model;

namespace Cliente.view
{
    public class Interface
    {
        public void Title()
        {
            Console.WriteLine("---- BEM-VINDO AO CADASTRO DE CLIENTE -----");
            Console.WriteLine("");
        }

        public void ShowData(Client c)
        {
            Console.WriteLine("---- CLIENTE CADASTRADO ----");
            Console.WriteLine("");
            Console.WriteLine($"Nome: {c.Nome}");
            Console.WriteLine($"CPF: {c.CPF}");
            Console.WriteLine($"Data de nascimento: {c.Dt_Nascimento}");
            Console.WriteLine($"Renda mensal: {c.Renda_Mensal}");
            Console.WriteLine($"Estado civil: {c.Estado_Civil}");
            Console.WriteLine($"Número de dependentes: {c.Dependentes}");

        }
    }
}
