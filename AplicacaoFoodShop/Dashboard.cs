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
        public Dashboard(localhost.Carrinho carrinho)
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

                localhost.Produto produto = new localhost.Produto();
                produto.Nome = inputPesquisaProduto.Text;

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

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            ListDash listDash = new ListDash();
            listDash.Visible = true;
            //Carrinho carrinho = new Carrinho();
            //this.Visible = false;
            //carrinho.Visible = true;
        }

        private void adicionarButton_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Compra compra = new localhost.Compra();
                localhost.Carrinho carrinho = new localhost.Carrinho();
                localhost.ProdutoLoja produtoloja = new localhost.ProdutoLoja();
                produtoloja.Id = Convert.ToInt32(listViewProdutoLoja.SelectedItems[0].SubItems[0].Text);
                compra.ProdutoLoja = produtoloja;
                compra.Valor = float.Parse(listViewProdutoLoja.SelectedItems[0].SubItems[4].Text);
                carrinho.Numero = 1;
                compra.Carrinho = carrinho;
                compra.Quantidade = Convert.ToInt32(inputQtdItemsCarrinho.Text);
                localhost.Service1 sv = new localhost.Service1();
                sv.InsertCompra(compra);
            }
            catch (Exception ex)
            {

                //MessageBox.Show("Erro ao inserir produto " + ex.Message);
            }
            
            
        }

        
    }
}
