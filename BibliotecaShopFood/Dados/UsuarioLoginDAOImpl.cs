using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Conexao;
using System.Data.SqlClient;

namespace BibliotecaShopFood.Dados
{
    public class UsuarioLoginDAOImpl : ConexaoBdSql, UsuarioLoginDAO
    {
        public Usuario UsuarioLogin(string cpf, string senha) { 

            Usuario retorno = null;
            {
                this.abrirConexao();

                try
                {
                    sql = "select cpf, senha from usuario where cpf = '" + cpf + "' and senha = '" + senha + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlConn);
                    SqlDataReader DbReader = cmd.ExecuteReader();
                    while (DbReader.Read())
                    {
                        retorno = new Usuario();
                        retorno.Cpf = DbReader.GetString(DbReader.GetOrdinal("cpf"));
                        retorno.Senha = DbReader.GetString(DbReader.GetOrdinal("senha"));
                    }
                }

                catch (Exception ex)
                {
                    throw new Exception("Usuário e senha incorreta" + ex.Message);
                }

                return retorno;
            }
        }
    }
}
