using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraCompraImpl : RegraCompra
    {
        public void Delete(Compra compra)
        {
            throw new NotImplementedException();
        }

        public String Insert(Compra compra)
        {
            String msgRetorno = "";
            CompraDAO compradao = new CompraDAOImpl();
            compradao.Insert(compra);
            return msgRetorno;
        }

        public List<Compra> Select(Compra filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Compra compra)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Compra compra)
        {
            throw new NotImplementedException();
        }
    }
}
