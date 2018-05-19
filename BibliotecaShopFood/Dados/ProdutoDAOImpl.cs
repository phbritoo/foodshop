using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Conexao;
using System.Data;
using System.Data.SqlClient;


namespace BibliotecaShopFood.Dados
{
    public class ProdutoDAOImpl : ConexaoBdSql, ProdutoDAO
    {
        public void Delete(Produto produto)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from produto where codigobarra = " + produto.CodigoBarra;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(Produto produto)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into produto (codigobarra, nome, descricao, marca) values('" + produto.CodigoBarra + "','" + produto.Nome + "','" + produto.Descricao + "','" + produto.Marca + "')";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Produto> Select(Produto filtro)
        {
            List<Produto> retorno = new List<Produto>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT codigobarra, nome, descricao, marca FROM produto where id = id";
                if (filtro.CodigoBarra != null)
                {
                    sql += " and codigobarra like '%" + filtro.CodigoBarra + "%'";
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    sql += " and bandeira like '%" + filtro.Nome + "%'";
                }

                if (filtro.Descricao != null && filtro.Descricao.Trim().Equals("") == false)
                {
                    sql += " and codigoseguranca like '%" + filtro.Descricao + "%'";

                }

                if (filtro.Marca != null && filtro.Marca.Trim().Equals("") == false)
                {
                    sql += " and codigoseguranca like '%" + filtro.Marca + "%'";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Produto produto = new Produto();
                    produto.CodigoBarra = DbReader.GetString(DbReader.GetOrdinal("codigobarra"));
                    produto.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    produto.Descricao = DbReader.GetString(DbReader.GetOrdinal("descricao"));
                    produto.Marca = DbReader.GetString(DbReader.GetOrdinal("marca"));
                    retorno.Add(produto);
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

        public void Update(Produto produto)
        {
            try
            {

                this.abrirConexao();
                string sql = "update produto set codigobarra ='" + produto.CodigoBarra + "', nome = '" + produto.Nome + "', descricao = '" + produto.Descricao + "', marca = '" + produto.Marca + " ' where codigobarra = '" + produto.CodigoBarra + "'";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Produto produto)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select codigobarra, nome, descricao, marca from produto where codigobarra = '" + produto.CodigoBarra + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    retorno = true;
                    break;
                }

                DbReader.Close();
                cmd.Dispose();
                this.fecharConexao();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e verificar" + ex.Message);
            }
            return retorno;
        }
    }
}
