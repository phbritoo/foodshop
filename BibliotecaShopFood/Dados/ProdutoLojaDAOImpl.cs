using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using System.Data;
using System.Data.SqlClient;
using BibliotecaShopFood.Conexao;

namespace BibliotecaShopFood.Dados
{
    class ProdutoLojaDAOImpl : ConexaoBdSql , ProdutoLojaDAO
    {
        public void Delete(ProdutoLoja produtoLoja)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from produto_loja where produtoId =" + produtoLoja.Produto.Id + " and cnpj =" + "'" + produtoLoja.Loja.Cnpj + "'";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(ProdutoLoja produtoLoja)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into produto_loja (produtoId, cnpj, valor) values('" + produtoLoja.Produto.Id + "','" + produtoLoja.Loja.Cnpj + "','" + produtoLoja.Preco +"')";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public List<ProdutoLoja> List(ProdutoLoja filtro)
        {
            List<ProdutoLoja> retorno = new List<ProdutoLoja>();
            try
            {
                this.abrirConexao();
                string sql = "select produto.id, produto.codigobarra, produto.nome,produto.descricao,produto.marca" +
                                     "loja.cnpj, loja.razaosocial,loja.nomefantasia, produto_loja.valor" +
                             "inner join produto on produto.Id = produto_loja.produtoId" +
                             "inner join loja on loja.cnpj = produto_loja.cnpj" +
                             "from produto_loja";

                if (filtro.Loja != null) 
                {
                    sql += " where produto_loja.cnpj  like '%" + filtro.Loja.Cnpj + "%'";
                }
                if (filtro.Produto != null)
                {
                    sql += " and produto_loja.produtoId  = "+ filtro.Produto.Id;
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    ProdutoLoja produtoLoja = new ProdutoLoja();
                    Produto produto = new Produto();
                    produto.Id = DbReader.GetInt32(DbReader.GetOrdinal("produto.Id"));
                    produto.CodigoBarra = DbReader.GetString(DbReader.GetOrdinal("produto.codigobarra"));
                    produto.Nome = DbReader.GetString(DbReader.GetOrdinal("produto.nome"));
                    produto.Descricao = DbReader.GetString(DbReader.GetOrdinal("produto.descricao"));
                    produto.Marca = DbReader.GetString(DbReader.GetOrdinal("produto.marca"));
                    produtoLoja.Produto = produto;
                    Loja loja = new Loja();
                    loja.Cnpj = DbReader.GetInt32(DbReader.GetOrdinal("cnpj"));
                    loja.RazaoSocial = DbReader.GetString(DbReader.GetOrdinal("razaosocial"));
                    loja.NomeFantasia = DbReader.GetString(DbReader.GetOrdinal("nomefantasia"));
                    produtoLoja.Loja = loja;
                    produtoLoja.Preco = DbReader.GetFloat(DbReader.GetOrdinal("produto_loja.valor"));
                    retorno.Add(produtoLoja);
                }
                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao conectar e selecionar" + ex.Message);
            }
            return retorno;
        }

        public void Update(ProdutoLoja produtoLoja)
        {
            try
            {
                this.abrirConexao();
                sql = "update produto_loja set produtoId = '" +produtoLoja.Produto.Id+"', cnpj = '"+produtoLoja.Loja.Cnpj+"', valor = '" + produtoLoja.Preco + "'" + "where produtoId =" + produtoLoja.Produto.CodigoBarra + " and cnpj =" + "'" + produtoLoja.Loja.Cnpj + "'";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }
    }
}
