using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class Produto
    {
        private int id;
        private String codigoBarra;
        private String nome;
        private String descricao;
        private String marca;

        [DataMember(IsRequired = true)]
        public int Id { get => id; set => id = value; }
        [DataMember(IsRequired = true)]
        public String CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        [DataMember(IsRequired = true)]
        public string Nome { get => nome; set => nome = value; }
        [DataMember(IsRequired = true)]
        public string Descricao { get => descricao; set => descricao = value; }
        [DataMember(IsRequired = true)]
        public string Marca { get => marca; set => marca = value; }
    }
}
