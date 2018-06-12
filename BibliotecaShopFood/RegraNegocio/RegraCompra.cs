using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraCompra
    {
        String Insert(Compra compra);
        void Update(Compra compra);
        void Delete(Compra compra);
        bool VerificaDuplicidade(Compra compra);
        List<Compra> Select(Compra filtro);
    }
}
