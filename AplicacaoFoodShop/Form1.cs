using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;
using BibliotecaShopFood.Conexao;

namespace AplicacaoFoodShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                

                Cartao cartao = new Cartao();
                cartao.Numero = textBox1.Text;
                cartao.Bandeira = textBox2.Text;
                cartao.DataValidade = Convert.ToDateTime(textBox3.Text);
                cartao.CodigoSeguranca = textBox4.Text;
                CartaoDAOImpl cartaodao = new CartaoDAOImpl();
                cartaodao.Insert(cartao);
                MessageBox.Show("Cartão cadastrado");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Cartao cartao = new Cartao();
                CartaoDAOImpl cartaodao = new CartaoDAOImpl();
                //if (textBox5.Text != "")
                //{
                //    cartao.Numero = (textBox5.Text);
                //}
                listView1.Items.Clear();
                foreach (Cartao x in cartaodao.Select(cartao))
                {
                    ListViewItem lista = listView1.Items.Add(x.Numero);
                    lista.SubItems.Add(x.Bandeira);
                    lista.SubItems.Add(Convert.ToString(x.DataValidade));
                    lista.SubItems.Add(x.CodigoSeguranca);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
    

