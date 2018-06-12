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
    public partial class ProdutoLoja : Form
    {
        public ProdutoLoja()
        {
            InitializeComponent();
            preencherComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //   localhost
            localhost.Service1 sv = new localhost.Service1();
            localhost.ProdutoLoja produtoLoja = new localhost.ProdutoLoja();
            localhost.Loja loja = new localhost.Loja();
            loja.Cnpj = comboBoxLoja.SelectedValue.ToString();
            produtoLoja.Loja = sv.SelectLoja(loja).ElementAt(0);
            localhost.Produto produto = new localhost.Produto();
            produto.CodigoBarra = comboBoxProduto.SelectedValue.ToString();
            produtoLoja.Produto = sv.SelectProduto(produto).ElementAt(0);
            produtoLoja.Preco = float.Parse(inputPreco.Text);
            sv.InsertProdutoLoja(produtoLoja);
            MessageBox.Show("Produto associado a loja com sucesso!");
        }

        private void ProdutoLoja_Load(object sender, EventArgs e)
        {

        }

        public void preencherComboBox()
        {
            localhost.Service1 sv = new localhost.Service1();

            var dataSourceProduto = new List<localhost.Produto>();
            localhost.Produto produto = new localhost.Produto();
            localhost.Produto produtoVazio = new localhost.Produto();
            produtoVazio.Id = 0;
            produtoVazio.Nome = "Selecione um produto";
            dataSourceProduto.Add(produtoVazio);

            var dataSourceLoja = new List<localhost.Loja>();
            localhost.Loja loja = new localhost.Loja();
            localhost.Loja lojaVazia = new localhost.Loja();
            lojaVazia.Id = 0;
            lojaVazia.RazaoSocial = "Selecione uma Loja";
            dataSourceLoja.Add(lojaVazia);

            foreach (localhost.Produto produtolista in sv.SelectProduto(produto))
            {
                dataSourceProduto.Add(produtolista);
            }

            foreach (localhost.Loja lojaLista in sv.SelectLoja(loja))
            {
                dataSourceLoja.Add(lojaLista);
            }

            comboBoxProduto.DataSource = dataSourceProduto;
            comboBoxProduto.DisplayMember = "nome";
            comboBoxProduto.ValueMember = "codigobarra";

            comboBoxLoja.DataSource = dataSourceLoja;
            comboBoxLoja.DisplayMember = "razaosocial";
            comboBoxLoja.ValueMember = "cnpj";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Principal principal = new Principal();
            principal.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Service1 sv = new localhost.Service1();
                localhost.ProdutoLoja produtoLoja = new localhost.ProdutoLoja();
                listViewProdutoLoja.Items.Clear();

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
    }
}
