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

      
        public int Id { get => id; set => id = value; }
        [DataMember(IsRequired = true)]
        public string Numero { get => numero; set => numero = value; }
        [DataMember(IsRequired = true)]
        public string Bandeira { get => bandeira; set => bandeira = value; }
        [DataMember(IsRequired = true)]
        public string CodigoSeguranca { get => codigoSeguranca; set => codigoSeguranca = value; }
    }
}
#endregion