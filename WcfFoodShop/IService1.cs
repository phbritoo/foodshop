﻿using BibliotecaShopFood.ClassesBasicas;
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
        String InsertCarrinho(Carrinho carrinho);
        [OperationContract]
        void UpdateCarrinho(Carrinho carrinho);
        [OperationContract]
        void DeleteCarrinho(Carrinho carrinho);
        [OperationContract]
        List<Carrinho> SelectCarrinho(Carrinho filtro);

        [OperationContract]
        String InsertCartao(Cartao cartao);
        [OperationContract]
        void UpdateCartao(Cartao cartao);
        [OperationContract]
        void DeleteCartao(Cartao cartao);
        [OperationContract]
        List<Cartao> SelectCartao(Cartao cartao);

        [OperationContract]
        String InsertLoja(Loja loja);
        [OperationContract]
        void UpdateLoja(Loja loja);
        [OperationContract]
        void DeleteLoja(Loja loja);
        [OperationContract]
        List<Loja> SelectLoja(Loja filtro);

        [OperationContract]
        void InsertNotaFiscal(NotaFiscal notaFiscal);
        [OperationContract]
        void UpdateNotaFiscal (NotaFiscal notaFiscal);
        [OperationContract]
        void DeleteNotaFiscal (NotaFiscal notaFiscal);
        [OperationContract]
        List<NotaFiscal> SelectNotaFiscal(NotaFiscal filtro);

        [OperationContract]
        String InsertProduto(Produto produto);
        [OperationContract]
        void UpdateProduto(Produto produto);
        [OperationContract]
        void DeleteProduto(Produto produto);
        [OperationContract]
        List<Produto> SelectProduto(Produto produto);

        [OperationContract]
        String InsertUsuario(Usuario usuario);
        [OperationContract]
        void UpdateUsuario(Usuario usuario);
        [OperationContract]
        void DeleteUsuario(Usuario usuario);
        [OperationContract]
        List<Usuario> SelectUsuario(Usuario filtro);

        [OperationContract]
        Usuario LoginUsuarioLogin(string cpf, string senha);


        [OperationContract]
        String InsertProdutoLoja(ProdutoLoja produtoLoja);
        [OperationContract]
        void UpdateProdutoLoja(ProdutoLoja produtoLoja);
        [OperationContract]
        void DeleteProdutoLoja(ProdutoLoja produtoLoja);
        [OperationContract]
        List<ProdutoLoja> ListProdutoLoja(ProdutoLoja filtro);


        [OperationContract]
        String InsertCompra(Compra compra);
        [OperationContract]
        void UpdateCompra(Compra compra);
        [OperationContract]
        void DeleteCompra(Compra compra);
        [OperationContract]
        List<Compra> SelectCompra(Compra filtro);


    }

}
