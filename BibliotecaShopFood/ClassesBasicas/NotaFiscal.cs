using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
    public class NotaFiscal
    {
        private int numero;
        private DateTime dataEmissao;
        private decimal precoTotal;
        private int quantidadeProduto;
        private Carrinho carrinho;

        public int Numero { get => numero; set => numero = value; }
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        public decimal PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        public Carrinho Carrinho { get => carrinho; set => carrinho = value; }
    }
}
