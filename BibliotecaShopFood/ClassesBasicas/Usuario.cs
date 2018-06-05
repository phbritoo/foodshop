using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class Usuario
    {
        private int id;
        private String cpf;
        private String nome;
        private String endereco;
        private String telefone;
        private String senha;

        [DataMember(IsRequired = false)]
        public int Id { get => id; set => id = value; }
        [DataMember(IsRequired = true)]
        public string Cpf { get => cpf; set => cpf = value; }
        [DataMember(IsRequired = true)]
        public string Nome { get => nome; set => nome = value; }
        [DataMember(IsRequired =true)]
        public string Endereco { get => endereco; set => endereco = value; }
        [DataMember(IsRequired = true)]
        public string Telefone { get => telefone; set => telefone = value; }
        [DataMember(IsRequired = true)]
        public string Senha { get => senha; set => senha = value; }
    }
}
