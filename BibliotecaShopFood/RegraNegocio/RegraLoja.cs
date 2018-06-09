using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;


namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraLoja
    {
        String Insert(Loja loja);
        void Update(Loja loja);
        void Delete(Loja loja);
        bool VerificaDuplicidade(Loja loja);
        List<Loja> Select(Loja filtro);
    }
}
