using ProtoBuf;

namespace Dant4lion.Domain.Models
{
    public class Unidade
    {
        [ProtoMember(1)]
        public string Nome { get; set; }

        [ProtoMember(2)]
        public string Diretorio { get; set; }

        [ProtoMember(3)]
        public string SerialUnidade { get; set; }
    }
}
