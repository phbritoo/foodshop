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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Usuario usuario = new Usuario();
            usuario.Show();
        }

        private void buttonLoja_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Loja loja = new Loja();
            loja.Show();
        }

        private void buttonProduto_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Produto produto = new Produto();
            produto.Show();
        }

        private void buttonCartao_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Cartao cartao = new Cartao();
            cartao.Show();
        }

        private void buttonCarrinho_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Carrinho usuario = new Carrinho();
            usuario.Show();
        }

        private void buttonNotaFiscal_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            NotaFiscal notafiscal = new NotaFiscal();
            notafiscal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ProdutoLoja produtoLoja = new ProdutoLoja();
            produtoLoja.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
