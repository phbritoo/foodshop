using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaShopFood.ClassesBasicas

#region
{
    [DataContract]
    public class Cartao
    {
        private int id;
        private String numero;
        private String bandeira;
        private String codigoSeguranca;
        private Usuario usuarioId;

        public Cartao()
        {
            this.Usuario = new Usuario();
        }

        public Cartao(int id, String numero, String bandeira, String codigoSeguranca, Usuario usuarioId)
        {
            this.id = id;
            this.numero = numero;
            this.bandeira = bandeira;
            this.codigoSeguranca = codigoSeguranca;
            this.usuarioId = usuarioId;
        }

        [DataMember(IsRequired = false)]
        public int Id { get => id; set => id = value; }
        [DataMember(IsRequired = true)]
        public string Numero { get => numero; set => numero = value; }
        [DataMember(IsRequired = true)]
        public string Bandeira { get => bandeira; set => bandeira = value; }
        [DataMember(IsRequired = true)]
        public string CodigoSeguranca { get => codigoSeguranca; set => codigoSeguranca = value; }
        [DataMember(IsRequired = true)]
        public Usuario Usuario { get => usuarioId; set => usuarioId = value; }
    }
}
#endregion