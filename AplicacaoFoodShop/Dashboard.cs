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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pesquisarButton_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Service1 sv = new localhost.Service1();
                localhost.ProdutoLoja produtoLoja = new localhost.ProdutoLoja();
                listViewProdutoLoja.Items.Clear();
                produtoLoja.Produto.Nome = inputPesquisaProduto.Text;
                foreach (localhost.ProdutoLoja produtolista in sv.ListProdutoLoja(produtoLoja))
                {
                    ListViewItem lista = listViewProdutoLoja.Items.Add(produtolista.Produto.Nome);
                    lista.SubItems.Add(produtolista.Loja.RazaoSocial);
                    lista.SubItems.Add(produtolista.Preco.ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void voltarButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Principal principal = new Principal();
            principal.Show();
        }
    }
}
