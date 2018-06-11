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
    public class CarrinhoDAOImpl : ConexaoBdSql, CarrinhoDAO
    {
        public void Delete(Carrinho carrinho)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from carrinho where numero = " + carrinho.Numero;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(Carrinho carrinho)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into carrinho (cartaocreditoid, usuarioid) values( " + carrinho.Cartaocreditoid.Id + "," + carrinho.UsuarioId.UsuarioId + ")";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Carrinho> Select(Carrinho filtro)
        {
            List<Carrinho> retorno = new List<Carrinho>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT numero, cartaocreditoid, usuarioid  FROM carrinho where numero = numero";
                if (filtro.Numero > 0)
                {
                    sql += " and numero like '%" + filtro.Numero + "%'";
                }
                if (filtro.Cartaocreditoid.Numero != null && filtro.Cartaocreditoid.Numero.Trim().Equals("") == false)
                {
                    sql += " and cartaocreditoid like '%" + filtro.Cartaocreditoid.Numero + "%'";
                }

                if (filtro.UsuarioId.Cpf != null && filtro.UsuarioId.Cpf.Trim().Equals("") == false)
                {
                    sql += " and usuarioid like '%" + filtro.UsuarioId.Cpf + "%'";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Carrinho carrinho = new Carrinho();
                    carrinho.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numero"));
                    carrinho.Cartaocreditoid.Id = DbReader.GetInt32(DbReader.GetOrdinal("cartaocreditoid"));
                    carrinho.UsuarioId.UsuarioId = DbReader.GetInt32(DbReader.GetOrdinal("usuarioid"));
                    retorno.Add(carrinho);
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

        public void Update(Carrinho carrinho)
        {
            try
            {

                this.abrirConexao();
                string sql = "update carrinho set numero =" + carrinho.Numero + ", cartaocreditoid = " + carrinho.Cartaocreditoid + ", usuarioid = " + carrinho.UsuarioId + " where numero = " + carrinho.Numero ;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Carrinho carrinho)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select numero, cartaocreditoid, usuarioid from carrinho where numero = " + carrinho.Numero;
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
