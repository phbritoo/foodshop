using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{ [DataContract]
   public class ProdutoLoja
    {
        private Produto produto;
        private Loja loja;
        private float preco;

        [DataMember(IsRequired = true)]
        public Loja Loja { get => loja; set => loja = value; }
        [DataMember(IsRequired = true)]
        public Produto Produto { get => produto; set => produto = value; }
        [DataMember(IsRequired = true)]
        public float Preco { get => preco; set => preco = value; }
    }
}
