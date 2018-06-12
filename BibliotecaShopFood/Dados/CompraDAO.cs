using BibliotecaShopFood.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.Dados
{
   public interface CompraDAO
    {
        void Insert(Compra compra);
        void Update(Compra compra);
        void Delete(Compra compra);
        bool VerificaDuplicidade(Compra compra);
        List<Compra> Select(Compra filtro);
    }
}
