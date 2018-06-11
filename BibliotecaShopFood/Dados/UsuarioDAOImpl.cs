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
    public class UsuarioDAOImpl : ConexaoBdSql, UsuarioDAO
    {
        public void Delete(Usuario usuario)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from usuario where cpf = " + usuario.Cpf;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(Usuario usuario)
        {
           try
            {
                this.abrirConexao();
                sql = "insert into usuario (cpf, nome, endereco, telefone, senha) values('" + usuario.Cpf + "','" + usuario.Nome + "','"  + usuario.Endereco + "','" + usuario.Telefone + "','"  + usuario.Senha + "')";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
                
            
        }

        public List<Usuario> Select(Usuario filtro)
        {
            List<Usuario> retorno = new List<Usuario>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT id, cpf, nome, endereco, telefone FROM usuario where id = id";
                if (filtro.Cpf != null)
                {
                    sql += " and cpf like '%" + filtro.Cpf + "%'";
                }
                if (filtro.Nome != null && filtro.Nome.Trim().Equals("") == false)
                {
                    sql += " and nome like '%" + filtro.Nome + "%'";
                }

                if (filtro.Endereco != null && filtro.Endereco.Trim().Equals("") == false)
                {
                    sql += " and endereco like '%" + filtro.Endereco + "%'";

                }

                if (filtro.Telefone != null && filtro.Telefone.Trim().Equals("") == false)
                {
                    sql += " and telefone like '%" + filtro.Telefone + "%'";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.UsuarioId = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                    usuario.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                    usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                    usuario.Endereco = DbReader.GetString(DbReader.GetOrdinal("endereco"));
                    usuario.Telefone = DbReader.GetString(DbReader.GetOrdinal("telefone"));
                    retorno.Add(usuario);
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

        public void Update(Usuario usuario)
        {
            try
            {

                this.abrirConexao();
                string sql = "update produto set cpf ='" + usuario.Cpf + "', nome = '" + usuario.Nome + "', endereco = '" + usuario.Endereco + "', telefone = '" + usuario.Telefone + "' where cpf = '" + usuario.Cpf + "'";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }

        public bool VerificaDuplicidade(Usuario usuario)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select cpf, nome, endereco, telefone from usuario where cpf = '" + usuario.Cpf + "'";
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
