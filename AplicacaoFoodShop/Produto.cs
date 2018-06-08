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
    public partial class Produto : Form
    {
        public Produto()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Produto produto = new localhost.Produto();
                produto.CodigoBarra = textBoxCodigo.Text;
                produto.Nome = textBoxNome.Text;
                produto.Marca = textBoxMarca.Text;
                produto.Descricao = textBoxDescricao.Text;
                localhost.Service1 sv = new localhost.Service1();
                sv.InsertProduto(produto);
                MessageBox.Show("Produto Cadastrado com Sucesso!");
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
                localhost.Produto produto = new localhost.Produto();
                localhost.Service1 sv = new localhost.Service1();
                listViewProduto.Items.Clear();

                foreach (localhost.Produto produtolista in sv.SelectProduto(produto))
                {
                    ListViewItem lista = listViewProduto.Items.Add(produtolista.CodigoBarra);
                    lista.SubItems.Add(produtolista.Nome);
                    lista.SubItems.Add(produtolista.Descricao);
                    lista.SubItems.Add(produtolista.Marca);

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
