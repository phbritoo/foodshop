using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;

namespace BibliotecaShopFood.RegraNegocio
{
    public class RegraUsuarioImpl: RegraUsuario
    {
        public void Delete(Usuario usuario)
        {
            throw new NotImplementedException();
        }

        public string Insert(Usuario usuario)
        {
            String msgRetorno = "";


            try
            {
                UsuarioDAO usuariodao= new UsuarioDAOImpl();
                if (usuariodao.VerificaDuplicidade(usuario))
                {
                    msgRetorno = msgRetorno + "Usuario já cadastrado";
                }
                else
                {
                    if (usuario.Cpf== "" && usuario.Endereco == "" && usuario.Nome == "" && usuario.Senha == "" && usuario.Telefone == "" )
                    {
                        msgRetorno = msgRetorno + " Inserir dados obrigatórios";
                    }
                    else
                    {
                        if (usuario.Nome == null || usuario.Nome == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o nome do usuario \n";
                        }
                        if (usuario.Senha == null || usuario.Senha == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir a senha do usuario \n";
                        }


                        if (usuario.Endereco == null || usuario.Endereco == "")
                        {
                            msgRetorno = msgRetorno + " Favor inserir o endereco do usuario \n";
                        }

                        if (usuario.Telefone.Length != 11)
                        {
                            msgRetorno = msgRetorno + "Telefone deve conte 11 numeros\n";
                        }

                        if (usuario.Cpf != "")
                        {

                            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                            string tempCpf;
                            string digito;

                            int soma;
                            int resto;

                            usuario.Cpf = usuario.Cpf.Trim();
                            usuario.Cpf = usuario.Cpf.Replace(".", "").Replace("-", "");

                            if (usuario.Cpf.Length != 11)
                            {
                                msgRetorno = msgRetorno + " CPF Invalido \n";
                            }
                            tempCpf = usuario.Cpf.Substring(0, 9);

                            soma = 0;

                            for (int i = 0; i < 9; i++)
                            {
                                soma += int.Parse(tempCpf[i].ToString()) * (multiplicador1[i]);
                            }
                            resto = soma % 11;

                            if (resto < 2)
                            {
                                resto = 0;
                            }
                            else
                            {
                                resto = 11 - resto;
                            }

                            digito = resto.ToString();
                            tempCpf = tempCpf + digito;
                            int soma2 = 0;

                            for (int i = 0; i < 10; i++)
                            {
                                soma2 += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
                            }

                            resto = soma2 % 11;

                            if (resto < 2)
                            {
                                resto = 0;
                            }
                            else
                            {
                                resto = 11 - resto;
                            }

                            digito = digito + resto.ToString();
                            usuario.Cpf.EndsWith(digito);
                        }
                        else {
                            msgRetorno = msgRetorno + " Favor inserir o CPF do usuario \n";
                        }
                    }

                       
                    }
                
                if (msgRetorno == "")
                {
                    usuariodao.Insert(usuario);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }

            return msgRetorno;
        }

        public List<Usuario> Select(Usuario filtro)
        {
            UsuarioDAO usuariodao = new UsuarioDAOImpl();
            return usuariodao.Select(filtro);
        }

        public void Update(Usuario usuario)
        {
            throw new NotImplementedException();
        }
        
        public bool VerificaDuplicidade(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}
