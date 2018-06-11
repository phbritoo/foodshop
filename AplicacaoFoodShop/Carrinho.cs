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
    public partial class Carrinho : Form
    {
        public Carrinho()
        {
            InitializeComponent();
            preencherComboboxUsuario();


        }

        private void buttonUsuarioOk_Click(object sender, EventArgs e)
        {
            localhost.Cartao cartao = new localhost.Cartao();
            localhost.Usuario usuario = new localhost.Usuario();
            usuario.UsuarioId = Convert.ToInt32(comboBoxUsuario.SelectedValue);
            cartao.Usuario = usuario;
            localhost.Service1 sv = new localhost.Service1();
            sv.SelectCartao(cartao);
            preencherComboboxCartao();

        }

        private void preencherComboboxUsuario()
        {
            localhost.Service1 sv = new localhost.Service1();
            var dataSourceUsuario = new List<localhost.Usuario>();
            localhost.Usuario usuario = new localhost.Usuario();
            localhost.Usuario usuariovazio = new localhost.Usuario();
            usuariovazio.UsuarioId = 0;
            usuariovazio.Nome = "Selecione um Usuário";
            dataSourceUsuario.Add(usuariovazio);


            foreach (localhost.Usuario usuariolista in sv.SelectUsuario(usuario))
            {
                dataSourceUsuario.Add(usuariolista);
            }

            comboBoxUsuario.DataSource = dataSourceUsuario;
            comboBoxUsuario.DisplayMember = "nome";
            comboBoxUsuario.ValueMember = "usuarioId";
        }

        private void preencherComboboxCartao()
        {
            localhost.Service1 sv = new localhost.Service1();
            var dataSourceCartao = new List<localhost.Cartao>();
            localhost.Cartao cartao = new localhost.Cartao();
            localhost.Cartao cartaovazio = new localhost.Cartao();
            cartaovazio.Id = 0;
            cartaovazio.Numero = "Selecione um Cartão";
            dataSourceCartao.Add(cartaovazio);
            foreach (localhost.Cartao cartaolista in sv.SelectCartao(cartao))
            {
                dataSourceCartao.Add(cartaolista);
            }

            comboBoxCartao.DataSource = dataSourceCartao;
            comboBoxCartao.DisplayMember = "numero";
            comboBoxCartao.ValueMember = "id";
        }

        private void buttonCadastrarCarrinho_Click(object sender, EventArgs e)
        {
            try
            {


                localhost.Carrinho carrinho = new localhost.Carrinho();
                localhost.Cartao cartao = new localhost.Cartao();
                localhost.Usuario usuario = new localhost.Usuario();
                usuario.UsuarioId = Convert.ToInt32(comboBoxUsuario.SelectedValue);
                cartao.Id = Convert.ToInt32(comboBoxCartao.SelectedValue);
                carrinho.UsuarioId = usuario;
                carrinho.Cartaocreditoid = cartao;
                localhost.Service1 sv = new localhost.Service1();

                String retornoMsg = sv.InsertCarrinho(carrinho);

                if (retornoMsg == "" || "".Equals(retornoMsg))
                {
                    MessageBox.Show("Cartão cadastrado com sucesso");
                }
                else
                {
                    MessageBox.Show(retornoMsg);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }
    }
}
