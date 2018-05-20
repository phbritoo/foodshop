using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
    public class Usuario
    {
        private int id;
        private String cpf;
        private String nome;
        private DateTime dataNascimento;
        private String endereco;
        private String telefone;
        private String isAdm;

        public int Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public String IsAdm { get => isAdm; set => isAdm = value; }
    }
}
