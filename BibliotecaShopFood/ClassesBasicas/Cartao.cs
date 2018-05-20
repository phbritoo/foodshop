using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
    public class Cartao
    {
        private int id;
        private String numero;
        private String bandeira;
        private DateTime dataValidade;
        private String codigoSeguranca;

        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Bandeira { get => bandeira; set => bandeira = value; }
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }
        public string CodigoSeguranca { get => codigoSeguranca; set => codigoSeguranca = value; }
    }
}
