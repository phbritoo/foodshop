using BibliotecaShopFood.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.Dados
{
    public interface ProdutoLojaDAO
    {
        void Insert(ProdutoLoja produtoLoja);
        void Update(ProdutoLoja produtoLoja);
        void Delete(ProdutoLoja produtoLoja);
        List<ProdutoLoja> List(ProdutoLoja filtro);

    }
}
