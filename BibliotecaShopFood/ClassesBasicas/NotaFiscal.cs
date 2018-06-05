using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class NotaFiscal
    {
        private int numero;
        private DateTime dataEmissao;
        private decimal precoTotal;
        private int quantidadeProduto;
        private Carrinho carrinho;

        [DataMember(IsRequired = true)]
        public int Numero { get => numero; set => numero = value; }
        [DataMember(IsRequired = true)]
        public DateTime DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        [DataMember(IsRequired = true)]
        public decimal PrecoTotal { get => precoTotal; set => precoTotal = value; }
        [DataMember(IsRequired = true)]
        public int QuantidadeProduto { get => quantidadeProduto; set => quantidadeProduto = value; }
        [DataMember(IsRequired = true)]
        public Carrinho Carrinho { get => carrinho; set => carrinho = value; }
    }
}
