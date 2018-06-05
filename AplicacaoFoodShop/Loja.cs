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
                loja.Cnpj = Convert.ToInt32(textBoxCNPJ.Text);
                loja.RazaoSocial = textBoxRazaoSocial.Text;
                loja.NomeFantasia = textBoxFantasia.Text;
                localhost.Service1 sv = new localhost.Service1();
                sv.InsertLoja(loja);
                MessageBox.Show("Loja Cadastrada com Sucesso!");
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
    }
}
