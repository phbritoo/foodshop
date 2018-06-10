using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraCartaoImpl : RegraCartao
    {
        public void Delete(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public string Insert(Cartao cartao)
        {
            String msgRetorno = "";


            try
            {
                CartaoDAO cartaodao = new CartaoDAOImpl();
                if (cartaodao.VerificaDuplicidade(cartao))
                {
                    msgRetorno = msgRetorno + "Cartão já cadastrado";
                }
                else
                {
                    if (cartao.Numero == "" && cartao.Bandeira == "" && cartao.CodigoSeguranca == "")
                    {
                        msgRetorno = msgRetorno + " Inserir dados obrigatórios";
                    }
                    else
                    {
                        if (cartao.Numero == null || cartao.Numero == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o número do cartão \n";
                        }

                        if (cartao.Bandeira == null || cartao.Bandeira == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir a Bandeira do cartão \n";
                        }
                        if (cartao.CodigoSeguranca == null || cartao.CodigoSeguranca == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o Código de segurança \n";

                        }
                        if (cartao.Numero.Length != 11)
                        {
                            msgRetorno = msgRetorno + " O número do cartão deve possuir 11 dígitos \n";
                        }

                        if (cartao.CodigoSeguranca.Length != 3)
                        {
                            msgRetorno = msgRetorno + " O código de segurança deve possuir 3 dígitos \n";
                        }
                    }
                }
                if (msgRetorno == "")
                {
                    cartaodao.Insert(cartao);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }

            return msgRetorno;
        }

        public List<Cartao> Select(Cartao filtro)
        {
            CartaoDAO cartaodao = new CartaoDAOImpl();
            return cartaodao.Select(filtro);
        }

        public void Update(Cartao cartao)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Cartao cartao)
        {
            throw new NotImplementedException();
        }
    }
}
