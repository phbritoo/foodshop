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
    public partial class Cartao : Form
    {
        public Cartao()
        {
            InitializeComponent();
            preencherCombobox();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
        try
            {
                localhost.Cartao cartao = new localhost.Cartao();
                localhost.Usuario usuario = new localhost.Usuario();
                cartao.Numero = textBoxNumero.Text;
                cartao.Bandeira = textBoxBandeira.Text;
                cartao.CodigoSeguranca = textBoxCodigoSeguranca.Text;
                usuario.UsuarioId = Convert.ToInt32(comboBoxUsuario.SelectedValue);
                cartao.Usuario = usuario;  
                localhost.Service1 sv = new localhost.Service1();

                String retornoMsg = sv.InsertCartao(cartao);

                if (retornoMsg == null || "".Equals(retornoMsg))
                {
                    MessageBox.Show("Cartão Cadastrado com Sucesso!");

                }
                else
                {
                    MessageBox.Show(retornoMsg);
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar e inserir " + ex.Message);
            }

        }

        public void preencherCombobox()
        {
            localhost.Service1 sv = new localhost.Service1();
            var dataSourceUsuario = new List<localhost.Usuario>();
            localhost.Usuario usuario = new localhost.Usuario();
            localhost.Usuario usuariovazio = new localhost.Usuario();
            usuariovazio.UsuarioId = 0;
            usuariovazio.Nome = "Selecione um Usuário";
            dataSourceUsuario.Add(usuariovazio);            
            

            foreach (localhost.Usuario usuariolista in sv.SelectUsuario(usuario))
            {
                dataSourceUsuario.Add(usuariolista);
            }

            comboBoxUsuario.DataSource = dataSourceUsuario;
            comboBoxUsuario.DisplayMember = "nome";
            comboBoxUsuario.ValueMember = "usuarioId";

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Cartao cartao = new localhost.Cartao();
                localhost.Service1 sv = new localhost.Service1();
                listViewCartao.Items.Clear();

                foreach (localhost.Cartao cartaolista in sv.SelectCartao(cartao))
                {
                    ListViewItem lista = listViewCartao.Items.Add(cartaolista.Numero);
                    lista.SubItems.Add(cartaolista.Bandeira);
                    lista.SubItems.Add(cartaolista.CodigoSeguranca);
                    lista.SubItems.Add(cartaolista.Usuario.Nome);
                 
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e Listar" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Principal principal = new Principal();
            principal.Show();
        }

        private void listViewCartao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
