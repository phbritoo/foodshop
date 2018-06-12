using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraProdutoLoja
    {
        String Insert(ProdutoLoja produtoLoja);
        void Update(ProdutoLoja produtoLoja);
        void Delete(ProdutoLoja produtoLoja);
        List<ProdutoLoja> List(ProdutoLoja filtro);
    }
}
