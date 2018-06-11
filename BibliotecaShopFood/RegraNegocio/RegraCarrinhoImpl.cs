using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraCarrinhoImpl : RegraCarrinho
    {
        public void Delete(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }

        public string Insert(Carrinho carrinho)
        {
            String msgRetorno = "";
            try
            {
                CarrinhoDAO carrinhodao = new CarrinhoDAOImpl();

                //if (carrinho.UsuarioId.UsuarioId == 0)
                //{
                //    msgRetorno = msgRetorno + "Favor selecionar um usuário \n ";
                //}
                //if (carrinho.Cartaocreditoid.Id == 0)
                //{
                //    msgRetorno = msgRetorno + "Favor selecionar um cartâo \n";
                //}
                if (msgRetorno == "")
                {
                    carrinhodao.Insert(carrinho);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
            return msgRetorno;
        }

        public List<Carrinho> Select(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }

        public void Update(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Carrinho carrinho)
        {
            throw new NotImplementedException();
        }
    }
}
