using System.Text.Json.Serialization;

namespace Cliente.model
{
    public class Data
    {
        [JsonPropertyName("nome")]
        public string? Nome { get; set; } = default!;
        [JsonPropertyName("cpf")]
        public string? CPF { get; set; } = default!;
        [JsonPropertyName("dt_nascimento")]
        public string? Dt_Nascimento { get; set; } = default!;
        [JsonPropertyName("renta_mensal")]
        public string? Renda_Mensal { get; set; } = default!;
        [JsonPropertyName("estado_civil")]
        public string? Estado_Civil { get; set; } = default!;
        [JsonPropertyName("dependentes")]
        public string? Dependentes { get; set; } = default!;
    }
}
