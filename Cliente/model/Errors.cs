namespace Cliente.model
{
    public class Dados
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Dt_nascimento { get; set; }
        public string? Renda_mensal { get; set; }
        public string? Estado_civil { get; set; }
        public string? Dependentes { get; set; }
    }

    public class Erro
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public string? Dt_nascimento { get; set; }
        public string? Renda_mensal { get; set; }
        public string? Estado_civil { get; set; }
        public string? Dependentes { get; set; }
    }

    public class RootErros
    {
        public Dados? Dados { get; set; }
        public List<Erro>? Erros { get; set; }
    }
}
