using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraCartao
    {
        String Insert(Cartao cartao);
        void Update(Cartao cartao);
        void Delete(Cartao cartao);
        List<Cartao> Select(Cartao cartao);
    }
}
