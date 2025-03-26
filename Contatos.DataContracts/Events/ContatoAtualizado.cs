using Contatos.DataContracts.Entities;

namespace Contatos.DataContracts.Events
{
    public record ContatoAtualizado
    {
        public DateTime? TimeStamp { get; init; }
        public long IdContato { get; init; }
        public string? NomeAtualizado { get; init; }
        public int DDDAtualizado { get; init; }
        public int TelefoneAtualizado { get; init; }
        public string? EmailAtualizado { get; init; }
        public Regiao? RegiaoAtualizada { get; init; }
    }
}
