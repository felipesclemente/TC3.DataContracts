namespace Contatos.DataContracts.Entities
{
    public class Contato
    {
        public long? Id { get; set; }
        public string? NomeCompleto { get; set; }
        public int? DDD { get; set; }
        public int? Telefone { get; set; }
        public string? Email { get; set; }
        public Regiao? Regiao { get; set; }
    }
}
