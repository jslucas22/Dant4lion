using Dant4lion.Domain.Interfaces;
using System;
using System.Net.Security;
using System.Runtime.Remoting.Messaging;

namespace Dant4lion.Service.Service.Network
{
    public class ClienteService : IEquatable<ClienteService>, ITransmissor
    {
        private readonly SslStream _sslStream;

        /// <summary>
        /// Fecha a conexao entre o cliente e o servidor
        /// </summary>
        public void Desconectar()
        {
            if (_sslStream != null)
            {
                _sslStream.Close();
            }
        }

        /// <summary>
        /// Envia uma mensagem para o cliente conectado
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="mensagem"></param>
        public void EnviarMensagem<T>(T mensagem) where T : IMessage
        {
            throw new NotImplementedException();
        }

        public bool Equals(ClienteService service)
        {
            try
            {
                bool isMesmaReferencia = !(service is null);

                return isMesmaReferencia;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
