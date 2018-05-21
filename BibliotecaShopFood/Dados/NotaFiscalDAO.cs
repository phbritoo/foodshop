using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.Dados
{
    public interface NotaFiscalDAO
    {
        void Insert(NotaFiscal notaFiscal);
        void Update(NotaFiscal notaFiscal);
        void Delete(NotaFiscal notaFiscal);
        bool VerificaDuplicidade(NotaFiscal notaFiscal);
        List<NotaFiscal> Select(NotaFiscal filtro);
    }
}
