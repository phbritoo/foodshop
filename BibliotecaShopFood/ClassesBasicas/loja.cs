﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace BibliotecaShopFood.ClassesBasicas
{
    [DataContract]
    public class Loja
    {
        private int id;
        private String cnpj;
        private String razaoSocial;
        private String nomeFantasia;

        [DataMember(IsRequired = true)]
        public int Id { get => id; set => id = value; }
        [DataMember(IsRequired = true)]
        public string Cnpj { get => cnpj; set => cnpj = value; }
        [DataMember(IsRequired = true)]
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        [DataMember(IsRequired = true)]
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
    }

}
