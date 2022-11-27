using System.Formats.Asn1;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cliente.model
{
    public class Client
    {
        public string? Nome { get; set; } = default!;
        public long? CPF { get; set; } = default!;
        public DateTime? Dt_Nascimento { get; set; } = default!;
        public float? Renda_Mensal { get; set; } = default!;
        public char? Estado_Civil { get; set; } = default!;
        public int? Dependentes { get; set; } = default!;
    }
}
