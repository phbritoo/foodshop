using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class Compra
    {
        private Carrinho carrinho;
        private ProdutoLoja produtoLoja;
        private float valor;
        private int quantidade;

        [DataMember(IsRequired = true)]
        public Carrinho Carrinho { get => carrinho; set => carrinho = value; }
        [DataMember(IsRequired = true)]
        public ProdutoLoja ProdutoLoja { get => produtoLoja; set => produtoLoja = value; }
        [DataMember(IsRequired = true)]
        public float Valor { get => valor; set => valor = value; }
        [DataMember(IsRequired = true)]
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
