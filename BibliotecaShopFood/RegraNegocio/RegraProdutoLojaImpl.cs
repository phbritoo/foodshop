using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraProdutoLojaImpl : RegraProdutoLoja
    {
        public void Delete(ProdutoLoja produtoLoja)
        {
            throw new NotImplementedException();
        }

        public string Insert(ProdutoLoja produtoLoja)
        {
            String msgRetorno = "";

            try
            {
                ProdutoLojaDAO produtolojadao = new ProdutoLojaDAOImpl();

                if (produtoLoja.Loja == null && produtoLoja.Produto == null && produtoLoja.Preco == 0)
                {
                    msgRetorno = msgRetorno + "Favor inserir dados";
                }

                else
                {

                    if (produtoLoja.Loja == null)
                    {
                        msgRetorno = msgRetorno + "Favor inserir a loja";
                    }

                    if (produtoLoja.Produto == null)
                    {
                        msgRetorno = msgRetorno + "Favor inserir o produto";
                    }

                    if (produtoLoja.Preco == 0)
                    {
                        msgRetorno = msgRetorno + "Favor inserir  preço";
                    }

                    if (produtoLoja.Preco < 0)
                    {
                        msgRetorno = msgRetorno + "O preço não pode ser negativo";
                    }
                }

                if (msgRetorno == "")
                {
                    produtolojadao.Insert(produtoLoja);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
            return msgRetorno;
        }

        public List<ProdutoLoja> List(ProdutoLoja filtro)
        {
            ProdutoLojaDAO produtolojadao = new ProdutoLojaDAOImpl();
            return produtolojadao.List(filtro);
        }

        public void Update(ProdutoLoja produtoLoja)
        {
            throw new NotImplementedException();
        }
    }
}