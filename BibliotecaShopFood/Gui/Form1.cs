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

namespace BibliotecaShopFood.Gui
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
                Loja loja = new Loja();
                loja.Cnpj = textBox1.Text;
                loja.NomeFantasia = textBox2.Text;
                loja.RazaoSocial = textBox3.Text;
                LojaDAOImpl lojadao = new LojaDAOImpl();
                lojadao.Insert(loja);
                
                

                    
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
