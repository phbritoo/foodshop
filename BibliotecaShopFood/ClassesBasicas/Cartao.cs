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
        private DateTime dataValidade;
        private String codigoSeguranca;

        [DataMember(IsRequired =true)]
        public int Id { get => id; set => id = value; }
        [DataMember]
        public string Numero { get => numero; set => numero = value; }
        [DataMember]
        public string Bandeira { get => bandeira; set => bandeira = value; }
        [DataMember]
        public DateTime DataValidade { get => dataValidade; set => dataValidade = value; }
        [DataMember]
        public string CodigoSeguranca { get => codigoSeguranca; set => codigoSeguranca = value; }
    }
}
#endregion