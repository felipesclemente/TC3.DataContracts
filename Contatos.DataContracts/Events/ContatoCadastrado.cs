namespace Contatos.DataContracts.Events
{
    public record ContatoCadastrado
    {
        public DateTime? TimeStamp { get; init; }
        public long IdCriado { get; init; }
    }
}
