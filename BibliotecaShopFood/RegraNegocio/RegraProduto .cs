using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraProduto
    {
        String Insert(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
        List<Produto> Select(Produto produto);
    }
}
