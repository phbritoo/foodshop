using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
     public interface RegraCarrinho
    {
        String Insert(Carrinho carrinho);
        void Update(Carrinho carrinho);
        void Delete(Carrinho carrinho);
        bool VerificaDuplicidade(Carrinho carrinho);
        List<Carrinho> Select(Carrinho filtro);
    }
}
