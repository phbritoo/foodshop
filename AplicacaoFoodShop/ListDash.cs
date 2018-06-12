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
    public partial class ListDash : Form
    {
        public ListDash()
        {
            InitializeComponent();
            ListarDash();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void ListarDash()
        {
            localhost.Compra compra = new localhost.Compra();
            localhost.Carrinho carrinho = new localhost.Carrinho();
            localhost.ProdutoLoja produtoLoja = new localhost.ProdutoLoja();
            localhost.Produto produto = new localhost.Produto();


            localhost.Service1 sv = new localhost.Service1();

            foreach (localhost.Produto produtolista in sv.SelectProduto(produto))
            {

            }
            {
                ListViewItem lista = listViewDash.Items.Add(compraLista.)
            }

            
        }
    }
}


 foreach (localhost.Produto produtoLista in sv.SelectProduto(produto))
                {
                    produtoLoja.Produto = produtoLista;

                    foreach (localhost.ProdutoLoja produtolista in sv.ListProdutoLoja(produtoLoja))
                    {
                        ListViewItem lista = listViewProdutoLoja.Items.Add(produtolista.Produto.Id.ToString());
lista.SubItems.Add(produtolista.Produto.Nome);
                        lista.SubItems.Add(produtolista.Produto.Descricao);
                        lista.SubItems.Add(produtolista.Loja.RazaoSocial);
                        lista.SubItems.Add(produtolista.Preco.ToString());
                        
                    }
                }