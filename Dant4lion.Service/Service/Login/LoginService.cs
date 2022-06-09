using Dant4lion.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dant4lion.Service.Service.Login
{
    public class LoginService
    {
        public bool Logar(string usuario, string senha)
        {
            Usuario usuario = new Usuario();
            return usuario.NomeUsuario.Length > 0 && usuario.Senha.Length > 0;
        }
    }
}
