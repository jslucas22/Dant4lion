using ProtoBuf;

namespace Dant4lion.Domain.Models
{
    [ProtoContract]
    public class Processo
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string Nome { get; set; }

        [ProtoMember(3)]
        public string NomeJanela { get; set; }
    }
}
