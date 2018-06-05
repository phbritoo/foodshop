using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace WcfFoodShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DeleteCartao(String numero)
        {
            try
            {
                CartaoDAO c = new CartaoDAOImpl();
                Cartao cartao = new Cartao();
                cartao.Numero = numero;
                c.Delete(cartao);
            }
            catch (Exception)
            {

                throw;
            } 
        }

        public void InsertCartao(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public string PegarTexto()
        {
            return "Testando o wcf";
        }

        public void UpdateCartao(Cartao cartao)
        {
            throw new NotImplementedException();
        }
    }
}
