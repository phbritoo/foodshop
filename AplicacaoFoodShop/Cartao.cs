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
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Cartao cartao = new localhost.Cartao();
                cartao.Numero = textBoxNumero.Text;
                cartao.Bandeira = textBoxBandeira.Text;
                cartao.CodigoSeguranca = textBoxCodigoSeguranca.Text;
                localhost.Service1 sv = new localhost.Service1();
                sv.InsertCartao(cartao);
                MessageBox.Show("Cartão Cadastrado com Sucesso!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro ao conectar e inserir" + ex.Message);
            }
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
    }
}
