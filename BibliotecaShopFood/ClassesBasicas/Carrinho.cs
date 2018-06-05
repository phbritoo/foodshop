using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class Carrinho
    {
        private int numero;
        private Cartao cartaocreditoid;
        private Usuario usuarioid;

        [DataMember(IsRequired = true)]
        public int Numero { get => numero; set => numero = value; }
        [DataMember(IsRequired = true)]
        public Cartao Cartaocreditoid { get => cartaocreditoid; set => cartaocreditoid = value; }
        [DataMember(IsRequired = true)]
        public Usuario Usuarioid { get => usuarioid; set => usuarioid = value; }
    }
}
