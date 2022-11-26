namespace Cliente.model
{
    public class Client
    {
        public string? Nome { get; set; }
        public long? CPF { get; set; }
        public DateTime? Dt_Nascimento { get; set; }
        public float? Renda_Mensal { get; set; }
        public char? Estado_Civil { get; set; }
        public int? Dependentes { get; set; }
    }
}
