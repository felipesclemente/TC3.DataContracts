namespace Contatos.DataContracts.Commands
{
    public record ApagarContato
    {
        public Guid CommandId { get; init; }
        public DateTime TimeStamp { get; init; }
        public long IdContato { get; init; }
    }
}
