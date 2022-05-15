using ProtoBuf;
using System;

namespace Dant4lion.Domain.Models
{
    [ProtoContract]
    public class SistemaDeArquivos
    {
        [ProtoMember(1)]
        public int TipoEntrada { get; set; }

        [ProtoMember(2)]
        public string Nome { get; set; }

        [ProtoMember(3)]
        public Int64 Tamanho { get; set; }
    }
}
