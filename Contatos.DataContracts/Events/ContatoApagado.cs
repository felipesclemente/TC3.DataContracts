namespace Contatos.DataContracts.Events
{
    public record ContatoApagado
    {
        public DateTime? TimeStamp { get; init; }
        public long IdApagado { get; init; }
    }
}
