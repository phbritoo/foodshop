using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Conexao;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Serialization;


namespace BibliotecaShopFood.Dados

{
    public class CartaoDAOImpl : ConexaoBdSql, CartaoDAO
    {
       
        public void Delete(Cartao cartao)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from cartaocredito where numero = " + cartao.Numero;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }


        public void Insert(Cartao cartao)
        {
         
                    try
                     {
                        
                        this.abrirConexao();
                        sql = "insert into cartaocredito (numero, bandeira, codigoseguranca, usuarioid) values('" + cartao.Numero + "','" + cartao.Bandeira + "','"+ cartao.CodigoSeguranca + "'," + cartao.Usuario.UsuarioId + ")";
                        executaSql();

                    }
                    catch (Exception ex)
                    {

                        throw new Exception("Erro ao conectar e inserir" + ex.Message);
                    }

                }
                
          
        
        
        public List<Cartao> Select(Cartao filtro)
        {
            List<Cartao> retorno = new List<Cartao>();
            try
            {
                this.abrirConexao();
                

                string sql = "select cartaocredito.id, cartaocredito.numero, cartaocredito.bandeira, cartaocredito.codigoseguranca, usuario.id, usuario.nome FROM cartaocredito INNER JOIN USUARIO ON cartaocredito.usuarioid = 1";
                
                if (filtro.Usuario != null )
                {
                  sql += " where usuario.id like " + filtro.Usuario.UsuarioId + "";
                }
                if (filtro.Bandeira != null && filtro.Bandeira.Trim().Equals("") == false)
                {
                    sql += " and bandeira like '%" + filtro.Bandeira + "%'";
                }

               if (filtro.CodigoSeguranca != null && filtro.CodigoSeguranca.Trim().Equals("") == false)
                {
                    sql += " and codigoseguranca like '%" + filtro.Bandeira + "%'";

                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                     Cartao cartao = new Cartao();
                     cartao.Id = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                     cartao.Numero = DbReader.GetString(DbReader.GetOrdinal("numero"));
                     cartao.Bandeira = DbReader.GetString(DbReader.GetOrdinal("bandeira"));
                     cartao.CodigoSeguranca = DbReader.GetString(DbReader.GetOrdinal("codigoseguranca"));
                     Usuario usuario = new Usuario();
                     usuario.UsuarioId = DbReader.GetInt32(DbReader.GetOrdinal("id"));
                     usuario.Nome = DbReader.GetString(DbReader.GetOrdinal("nome"));
                     cartao.Usuario = usuario;
                     retorno.Add(cartao);
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
        
        public void Update(Cartao cartao)
        {
            try
            {

                this.abrirConexao();
                string sql = "update cartaocredito set numero ='" + cartao.Numero + "', bandeira = '" + cartao.Bandeira + "', datavalidade = '" + "', codigoseguranca = '" + cartao.CodigoSeguranca + " ' where numero = '" + cartao.Numero + "'";
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }
        
        public bool VerificaDuplicidade(Cartao cartao)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select numero, bandeira, codigoseguranca from cartaocredito where numero = '" + cartao.Numero + "'";
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
