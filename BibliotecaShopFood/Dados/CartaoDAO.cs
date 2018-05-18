using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
namespace BibliotecaShopFood.Dados
{
    public interface CartaoDAO
    {
        void Insert(Cartao cartao);
        void Update(Cartao cartao);
        void Delete(Cartao cartao);
        bool VerificaDuplicidade(Cartao cartao);
        List<Cartao> Select(Cartao cartao);

    }
}
