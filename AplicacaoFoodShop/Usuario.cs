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
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Usuario usuario = new localhost.Usuario();
                usuario.Cpf = textBoxCpf.Text;
                usuario.Nome = textBoxNome.Text;
                usuario.Telefone = textBoxTelefone.Text;
                usuario.Endereco = textBoxEndereco.Text;
                usuario.Senha = textBoxSenha.Text;
                localhost.Service1 sv = new localhost.Service1();
                sv.InsertUsuario(usuario);
                MessageBox.Show("Usuário Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
            
        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Usuario usuario = new localhost.Usuario();
                localhost.Service1 sv = new localhost.Service1();
                listViewUsuario.Items.Clear();
                foreach (localhost.Usuario usuariolista in sv.SelectUsuario(usuario))
                {
                    ListViewItem lista = listViewUsuario.Items.Add(usuariolista.Cpf);
                    lista.SubItems.Add(usuariolista.Nome);
                    lista.SubItems.Add(usuariolista.Endereco);
                    lista.SubItems.Add(usuariolista.Telefone);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e Listar" + ex.Message);
            }
           

        }

    }
}
