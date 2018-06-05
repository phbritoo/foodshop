using BibliotecaShopFood.ClassesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFoodShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string PegarTexto();

        [OperationContract]
        void InsertCartao(Cartao cartao);
        [OperationContract]
        void UpdateCartao(Cartao cartao);
        [OperationContract]
        void DeleteCartao(String numero);



    }

}
