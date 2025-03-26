﻿namespace Contatos.DataContracts.Commands
{
    public record AtualizarContato
    {
        public Guid CommandId { get; init; }
        public DateTime TimeStamp { get; init; }
        public long Id { get; init; }
        public string? NomeCompleto { get; init; }
        public int DDD { get; init; }
        public int Telefone { get; init; }
        public string? Email { get; init; }
    }
}
