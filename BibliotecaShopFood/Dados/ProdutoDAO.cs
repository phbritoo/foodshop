using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.Dados
{
    public interface ProdutoDAO
    {
        void Insert(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
        bool VerificaDuplicidade(Produto produto);
        List<Produto> Select(Produto produto);
    }
}
