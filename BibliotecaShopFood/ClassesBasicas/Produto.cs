using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
    public class Produto
    {
        private int id;
        private String codigoBarra;
        private String nome;
        private String descricao;
        private String marca;

        public int Id { get => id; set => id = value; }
        public String CodigoBarra { get => codigoBarra; set => codigoBarra = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Marca { get => marca; set => marca = value; }
    }
}
