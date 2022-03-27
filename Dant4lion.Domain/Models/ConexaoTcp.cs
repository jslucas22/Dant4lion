using ProtoBuf;
using System;

namespace Dant4lion.Domain.Models
{
    [ProtoContract]
    public class ConexaoTcp
    {
        /// <summary>
        /// Nome do processo
        /// </summary>
        [ProtoMember(1)]
        public string Processo { get; set; }
        /// <summary>
        /// Endereço do ip local
        /// </summary>
        [ProtoMember(2)]
        public string IpLocal { get; set; }
        /// <summary>
        /// Porta ip local
        /// </summary>
        [ProtoMember(3)]
        public Int16 PortaIpLocal { get; set; }
        /// <summary>
        /// Endereço de ip remoto
        /// </summary>
        [ProtoMember(4)]
        public string IpRemoto { get; set; }
        /// <summary>
        /// Porta ip remoto
        /// </summary>
        [ProtoMember(5)]
        public Int16 PortaIpRemoto { get; set; }
    }
}
