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
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Loja loja = new localhost.Loja();
                loja.Cnpj = textBoxCNPJ.Text;
                loja.RazaoSocial = textBoxRazaoSocial.Text;
                loja.NomeFantasia = textBoxFantasia.Text;
                localhost.Service1 sv = new localhost.Service1();
                String retornoMsg = sv.InsertLoja(loja);

                if (retornoMsg == null || "".Equals(retornoMsg))
                {
                    MessageBox.Show("Loja Cadastrada com Sucesso!");
                }
                else
                {
                    MessageBox.Show(retornoMsg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            try
            {
                localhost.Loja loja = new localhost.Loja();
                localhost.Service1 sv = new localhost.Service1();
                listViewLoja.Items.Clear();
                foreach (localhost.Loja lojalista in sv.SelectLoja(loja))
                {
                    ListViewItem lista = listViewLoja.Items.Add(Convert.ToString(lojalista.Cnpj));
                    lista.SubItems.Add(lojalista.RazaoSocial);
                    lista.SubItems.Add(lojalista.NomeFantasia);

                }
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e listar" + ex.Message);
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
