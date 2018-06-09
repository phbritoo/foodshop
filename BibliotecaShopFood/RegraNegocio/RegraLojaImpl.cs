using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraLojaImpl : RegraLoja
    {
        public void Delete(Loja loja)
        {
            throw new NotImplementedException();
        }

        public String Insert(Loja loja)
        {
            String msgRetorno = "";
            {
                try
                {

                    LojaDAO lojadao = new LojaDAOImpl();

                    if (lojadao.VerificaDuplicidade(loja))
                    {
                        msgRetorno = msgRetorno + " Loja já cadastrada";
                    }

                    else
                    {
                    }
                    if (loja.Cnpj == "" && loja.NomeFantasia == "" && loja.RazaoSocial == "")
                    {
                        msgRetorno = msgRetorno + " Inserir dados obrigatórios";
                    }
                    else
                    {
                        if (loja.Cnpj == null || loja.Cnpj == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o CNPJ \n";
                        }

                        if (loja.NomeFantasia == null || loja.NomeFantasia == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o Nome Fantasia \n";
                        }
                        if (loja.RazaoSocial == null || loja.RazaoSocial == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir a Razão Social \n";
                        }

                    }
                    if (msgRetorno == "")
                    {
                        lojadao.Insert(loja);
                    }



                }
                catch (Exception ex)
                {

                    throw new Exception("Erro ao conectar e inserir" + ex.Message);
                }

                return msgRetorno;
            }
        }

        public List<Loja> Select(Loja filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Loja loja)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Loja loja)
        {
            throw new NotImplementedException();
        }
    }
}
