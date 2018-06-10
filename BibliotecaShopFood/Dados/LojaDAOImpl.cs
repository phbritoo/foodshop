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
    public class LojaDAOImpl : ConexaoBdSql, LojaDAO


    {
        public void Delete(Loja loja)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from loja where cnpj = " + loja.Cnpj;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(Loja loja)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into loja (CNPJ, RAZAOSOCIAL, NOMEFANTASIA) values('" + loja.Cnpj + "','" + loja.RazaoSocial + "','" + loja.NomeFantasia + "')";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Loja> Select(Loja filtro)
        {
            List<Loja> retorno = new List<Loja>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT CNPJ, RAZAOSOCIAL, NOMEFANTASIA FROM loja where cnpj = cnpj";
                if (filtro.Cnpj != null)
                {
                    sql += " and cnpj = " + filtro.Cnpj;
                }
                if (filtro.RazaoSocial != null && filtro.RazaoSocial.Trim().Equals("") == false)
                {
                    sql += " and razaosocial like '%" + filtro.RazaoSocial + "%'";
                }

                if (filtro.NomeFantasia != null && filtro.NomeFantasia.Trim().Equals("") == false)
                {
                    sql += " and nomefantasia like '%" + filtro.NomeFantasia + "%'";
                }


                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Loja loja = new Loja();
                    loja.Cnpj = DbReader.GetString(DbReader.GetOrdinal("cnpj"));
                    loja.RazaoSocial = DbReader.GetString(DbReader.GetOrdinal("razaosocial"));
                    loja.NomeFantasia = DbReader.GetString(DbReader.GetOrdinal("nomefantasia"));
                    retorno.Add(loja);
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

        public void Update(Loja loja)
        {
            try
            {

                this.abrirConexao();
                string sql = "update loja set cnpj = '" + loja.Cnpj + "',razaosocial = '" + loja.RazaoSocial + "', nomefantasia = '" + loja.NomeFantasia + " ' where cnpj = " + loja.Cnpj;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Loja loja)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select cnpj, razaosocial, nomefantasia from loja where cnpj = '" + loja.Cnpj + "'";
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
