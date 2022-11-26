using System.Text.Json.Serialization;

namespace Cliente.model
{
    public class Client
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; } = default!;
        [JsonPropertyName("cpf")]
        public long? CPF { get; set; } = default!;
        [JsonPropertyName("dt_nascimento")]
        public DateTime? Dt_Nascimento { get; set; } = default!;
        [JsonPropertyName("renta_mensal")]
        public float? Renda_Mensal { get; set; } = default!;
        [JsonPropertyName("estado_civil")]
        public char? Estado_Civil { get; set; } = default!;
        [JsonPropertyName("dependentes")]
        public int? Dependentes { get; set; } = default!;
    }
}
