using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Conexao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaShopFood.Dados
{
    public class CompraDAOImpl : ConexaoBdSql, CompraDAO
    {
        public void Delete(Compra compra)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from carrinho_produto_loja where numerocarrinho = " + compra.Carrinho.Numero + " and produto_lojaId = " +compra.ProdutoLoja.Id;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public void Insert(Compra compra)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into CARRINHO_PRODUTO_LOJA (numerocarrinho,produto_LojaId, valor, quantidade) values(" + compra.Carrinho.Numero + "," + compra.ProdutoLoja.Id +","+compra.Valor+","+compra.Quantidade+")";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public List<Compra> Select(Compra filtro)
        {
            List<Compra> retorno = new List<Compra>();
            try
            {
                this.abrirConexao();


                string sql = "SELECT CARRINHO_PRODUTO_LOJA.NUMEROCARRINHO, CARRINHO_PRODUTO_LOJA.PRODUTO_LOJAID, CARRINHO_PRODUTO_LOJA.QUANTIDADE,CARRINHO_PRODUTO_LOJA.VALOR, PRODUTO.ID, PRODUTO.NOME, PRODUTO.DESCRICAO FROM CARRINHO_PRODUTO_LOJA INNER JOIN CARRINHO on NUMEROCARRINHO = carrinho.numero INNER JOIN PRODUTO_LOJA on PRODUTO_LOJAID = PRODUTO_LOJA.ID INNER JOIN PRODUTO on PRODUTO_LOJA.PRODUTOID = PRODUTO.ID";


                //string sql = "select   carrinho_produto_loja.valor, quantidade, " +
                //                      "carrinho.cartaocreditoId , carrinho.numero , carrinho.usuarioId, " +
                //                      "produto_loja.Id, produto_loja.lojaId, produto_loja.produtoId, produto_loja.valor " +
                //              "from carrinho_produto_loja " +
                //                    "inner join carrinho on numerocarrinho = carrinho.numero " +
                //                    "inner join produto_loja on produto_LojaId = produto_Loja.Id";

                if (filtro.Carrinho != null)
                {
                    sql += " where numerocarrinho = " + filtro.Carrinho.Numero;
                }
                if (filtro.ProdutoLoja != null)
                {
                    sql += " and produto_LojaId =" +filtro.ProdutoLoja.Id;
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Compra compra = new Compra();
                    Carrinho carrinho = new Carrinho();
                    ProdutoLoja produtoLoja = new ProdutoLoja();
                    Produto produto = new Produto();
                    carrinho.Numero = DbReader.GetInt32(DbReader.GetOrdinal("carrinho"));
                    produtoLoja.Id = DbReader.GetInt32(DbReader.GetOrdinal("produtoloja"));
                    compra.Quantidade = DbReader.GetInt32(DbReader.GetOrdinal("quantidade"));
                    compra.Valor = float.Parse(DbReader.GetDecimal(DbReader.GetOrdinal("valor")).ToString());
                    produto.Id = DbReader.GetInt32(DbReader.GetOrdinal("idproduto"));
                    produto.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    produto.Descricao = DbReader.GetString(DbReader.GetOrdinal("descrição"));
                    compra.ProdutoLoja = produtoLoja;
                    compra.Carrinho = carrinho;
                    retorno.Add(compra);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            return retorno;
        }

        public void Update(Compra compra)
        {
            try
            {
                this.abrirConexao();
                sql = "update CARRINHO_PRODUTO_LOJA set numerocarrinho ="+ compra.Carrinho.Numero+",produto_LojaId ="+ compra.ProdutoLoja.Id +",valor ="+compra.Valor+", quantidade = "+ compra.Quantidade;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public bool VerificaDuplicidade(Compra compra)
        {
            try
            {

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
                
            }
            return false;
        }
    }
}
