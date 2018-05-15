using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
    public class Loja
    {
        private int cnpj;
        private String razaoSocial;
        private String nomeFantasia;

        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
    }

}
