using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoFoodShop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonConectar_Click(object sender, EventArgs e)
        {
            localhost.Service1 sv = new localhost.Service1();
            localhost.Usuario usuario = new localhost.Usuario();
            usuario.Cpf = boxLogin.Text;
            usuario.Senha = boxSenha.Text;
          localhost.Usuario temp = sv.LoginUsuarioLogin(usuario.Cpf, usuario.Senha);

            if (temp == null)
            {
                MessageBox.Show("Usuário e senha incorreto");
            }
            else
            {
                this.Visible = false;
                Principal principal = new Principal();
                principal.Show();

            }
        }
    }
}
