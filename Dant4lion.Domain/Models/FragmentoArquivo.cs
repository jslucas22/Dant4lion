using ProtoBuf;
using System;

namespace Dant4lion.Domain.Models
{
    [ProtoContract]
    public class FragmentoArquivo
    {
        [ProtoMember(1)]
        public byte[] Conteudo { get; set; }
        
        [ProtoMember(2)]
        public Int64 Offset { get; set; }
    }
}
