using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraProdutoImpl : RegraProduto
    {
        public void Delete(Produto produto)
        {
            throw new NotImplementedException();
        }

        public String Insert(Produto produto)
        {
            String msgRetorno = "";
            {
                try
                {

                    ProdutoDAO produtodao = new ProdutoDAOImpl();
                    
                    if (produtodao.VerificaDuplicidade(produto))
                    {
                        msgRetorno = msgRetorno + " Produto já cadastrado";
                    }

                    else
                    {
                    }
                    if (produto.CodigoBarra == "" && produto.Nome == "" && produto.Descricao == "" && produto.Marca == "")
                    {
                        msgRetorno = msgRetorno + " Inserir dados obrigatórios";
                    }
                    else
                    {
                        if (produto.CodigoBarra == null || produto.CodigoBarra == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o Codigo de Barras \n";
                        }

                        if (produto.Nome == null || produto.Nome == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o Nome do produto \n";
                        }
                        if (produto.Descricao == null || produto.Descricao == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir a descricao do produto \n";
                        }
                        if (produto.Marca == null || produto.Marca == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir a marca do produto \n";
                        }

                    }
                    if (msgRetorno == "")
                    {
                        produtodao.Insert(produto);
                    }



                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao conectar e inserir" + ex.Message);
                }

                return msgRetorno;
            }
        }
        
        public List<Produto> Select(Produto filtro)
        {
            ProdutoDAO produtodao = new ProdutoDAOImpl();
            return produtodao.Select(filtro);
        }
        public void Update(Produto produto)
        {
            throw new NotImplementedException();
        }
        
        public bool VerificaDuplicidade(Produto produto)
        {
            throw new NotImplementedException();
        }
    }
}
