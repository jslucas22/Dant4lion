using System.Net.Security;

namespace Dant4lion.Service.Service.Network
{
    public class ClienteService
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
    }
}
