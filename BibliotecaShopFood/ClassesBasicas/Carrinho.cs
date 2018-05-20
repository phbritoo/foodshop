using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.ClassesBasicas
{
   public class Carrinho
    {
        private int numero;
        private Cartao cartaocreditoid;
        private Usuario usuarioid;

        public int Numero { get => numero; set => numero = value; }
        public Cartao Cartaocreditoid { get => cartaocreditoid; set => cartaocreditoid = value; }
        public Usuario Usuarioid { get => usuarioid; set => usuarioid = value; }
    }
}
