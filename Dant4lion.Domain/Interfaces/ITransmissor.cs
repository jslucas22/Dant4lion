using System.Runtime.Remoting.Messaging;

namespace Dant4lion.Domain.Interfaces
{
    public interface ITransmissor
    {
        /// <summary>
        /// Envia uma mensagem
        /// </summary>
        /// <typeparam name="T">Generic</typeparam>
        /// <param name="mensagem">Descrição da mensagem</param>
        void EnviarMensagem<T>(T mensagem) where T : IMessage;
    }
}
