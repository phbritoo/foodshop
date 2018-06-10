using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Dados;
using BibliotecaShopFood.RegraNegocio;
namespace WcfFoodShop
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public void DeleteCarrinho(Carrinho carrinho)
        {
            try
            {
                CarrinhoDAO carrinhodao = new CarrinhoDAOImpl();
                carrinhodao.Delete(carrinho);
            }
            catch (Exception ex )
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void DeleteCartao(Cartao cartao)
        {
            try
            {
                CartaoDAO cartaodao = new CartaoDAOImpl();
                cartaodao.Delete(cartao);

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            } 
        }

        public void DeleteLoja(Loja loja)
        {
            try
            {
                LojaDAO lojadao = new LojaDAOImpl();
                lojadao.Delete(loja);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void DeleteNotaFiscal(NotaFiscal notaFiscal)
        {
            try
            {
                NotaFiscalDAO notafiscaldao = new NotafiscalDAOImpl();
                notafiscaldao.Delete(notaFiscal);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void DeleteProduto(Produto produto)
        {
            try
            {
                ProdutoDAO produtodao = new ProdutoDAOImpl();
                produtodao.Delete(produto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void DeleteUsuario(Usuario usuario)
        {
            try
            {
                UsuarioDAO usuariodao = new UsuarioDAOImpl();
                usuariodao.Delete(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void InsertCarrinho(Carrinho carrinho)
        {
            try
            {
                CarrinhoDAO carrinhodao = new CarrinhoDAOImpl();
                carrinhodao.Insert(carrinho);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public String InsertCartao(Cartao cartao)
        {
            try
            {
                RegraCartao cartaoRegra = new RegraCartaoImpl();
                return cartaoRegra.Insert(cartao);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
           
        }

        public String InsertLoja(Loja loja)
        {
            try
            {
                RegraLoja lojaRegra = new RegraLojaImpl();
                return lojaRegra.Insert(loja);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public void InsertNotaFiscal(NotaFiscal notaFiscal)
        {
            try
            {
                NotaFiscalDAO notafiscaldao = new NotafiscalDAOImpl();
                notafiscaldao.Insert(notaFiscal);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public String InsertProduto(Produto produto)
        {
            try
            {
                RegraProduto produtoRegra = new RegraProdutoImpl();
                return produtoRegra.Insert(produto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public String InsertUsuario(Usuario usuario)
        {
            try
            {
                RegraUsuario usuarioRegra = new RegraUsuarioImpl();
                return usuarioRegra.Insert(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Carrinho> SelectCarrinho(Carrinho filtro)
        {
            try
            {
                CarrinhoDAO carrinhodao = new CarrinhoDAOImpl();
                return carrinhodao.Select(filtro);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public List<Cartao> SelectCartao(Cartao cartao)
        {
            try
            {
                RegraCartao cartaoRegra = new RegraCartaoImpl();
                return cartaoRegra.Select(cartao);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public List<Loja> SelectLoja(Loja filtro)
        {
            try
            {
                RegraLoja lojaRegra = new RegraLojaImpl();
                return lojaRegra.Select(filtro);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public List<NotaFiscal> SelectNotaFiscal(NotaFiscal filtro)
        {
            try
            {
                NotaFiscalDAO notafiscaldao = new NotafiscalDAOImpl();
                return notafiscaldao.Select(filtro);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public List<Produto> SelectProduto(Produto produto)
        {
            try
            {
                RegraProduto produtoRegra = new RegraProdutoImpl();
                return produtoRegra.Select(produto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public List<Usuario> SelectUsuario(Usuario filtro)
        {
            try
            {
                RegraUsuario usuarioRegra = new RegraUsuarioImpl();
                return usuarioRegra.Select(filtro);
            }
            catch (Exception ex )
            {

                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
        }

        public void UpdateCarrinho(Carrinho carrinho)
        {
            try
            {
                CarrinhoDAO carrinhodao = new CarrinhoDAOImpl();
                carrinhodao.Update(carrinho);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public void UpdateCartao(Cartao cartao)
        {
            try
            {
                CartaoDAO cartadao = new CartaoDAOImpl();
                cartadao.Select(cartao);
            }
            catch (Exception ex )
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public void UpdateLoja(Loja loja)
        {
            try
            {
                LojaDAO lojadao = new LojaDAOImpl();
                lojadao.Update(loja);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public void UpdateNotaFiscal(NotaFiscal notaFiscal)
        {
            try
            {
                NotaFiscalDAO notafiscaldao = new NotafiscalDAOImpl();
                notafiscaldao.Update(notaFiscal);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public void UpdateProduto(Produto produto)
        {
            try
            {
                ProdutoDAO produtodao = new ProdutoDAOImpl();
                produtodao.Update(produto);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public void UpdateUsuario(Usuario usuario)
        {
            try
            {
                UsuarioDAO usuariodao = new UsuarioDAOImpl();
                usuariodao.Update(usuario);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e atualizar" + ex.Message);
            }
        }

        public Usuario LoginUsuarioLogin(string cpf, string senha)
        {
            try
            {
                UsuarioLoginDAO usuariologindao = new UsuarioLoginDAOImpl();
                return usuariologindao.UsuarioLogin(cpf, senha);
            }

            catch (Exception ex)
            {

                throw new Exception("Erro no processo de login" + ex.Message);
            }
        }

        public void Insert(ProdutoLoja produtoLoja)
        {
            throw new NotImplementedException();
        }

        public void Update(ProdutoLoja produtoLoja)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProdutoLoja produtoLoja)
        {
            throw new NotImplementedException();
        }

        public List<ProdutoLoja> List(ProdutoLoja filtro)
        {
            throw new NotImplementedException();
        }
    }
}
