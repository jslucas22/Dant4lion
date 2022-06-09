using Dant4lion.Service.Service.Login;
using System;
using System.Windows.Forms;

namespace Dant4lion.ServerSide.View
{
    public partial class Login : Form
    {
        private LoginService _service;

        public Login()
        {
            InitializeComponent();
        }

        private void Logar()
        {
            if (_service.Logar(txtUsuario.Text, txtSenha.Text))
                new Main().ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e) => Logar();
    }
}
