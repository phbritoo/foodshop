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
    public class NotafiscalDAOImpl : ConexaoBdSql, ProdutoDAO
    {
        public void Delete(NotaFiscal notaFiscal)
        {
            try
            {
                this.abrirConexao();
                sql = "delete from notafiscal where numero = " + notaFiscal.Numero;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e remover" + ex.Message);
            }
        }

        public void Insert(NotaFiscal notaFiscal)
        {
            try
            {
                this.abrirConexao();
                sql = "insert into notafiscal ( dataemissao, precototal , quantidadeprodutos, numerocarrinho) values('" + notaFiscal.DataEmissao + "','" + notaFiscal.PrecoTotal + "','" + notaFiscal.QuantidadeProduto + "'," + notaFiscal.Carrinho.Numero + ")";
                executaSql();

            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<NotaFiscal> Select(NotaFiscal filtro)
        {
            List<NotaFiscal> retorno = new List<NotaFiscal>();
            try
            {
                this.abrirConexao();
                string sql = "SELECT dataemissao, precototal, quantidadeprodutos, numerocarrinho FROM notafiscal where numero = numero";
                if (filtro.Numero >0 )
                {
                    sql += " and numero like " + filtro.Numero;
                }
                if (filtro.PrecoTotal > 0)
                {
                    sql += " and precototal like " + filtro.PrecoTotal;
                }

                if (filtro.QuantidadeProduto > 0 )
                {
                    sql += " and descricao like " + filtro.QuantidadeProduto ;

                }

                if (filtro.Carrinho.Numero > 0)
                {
                    sql += " and numerocarrinho like " + filtro.Carrinho.Numero;
                    
                }

                SqlCommand cmd = new SqlCommand(sql, sqlConn);
                SqlDataReader DbReader = cmd.ExecuteReader();
                while (DbReader.Read())
                {
                    NotaFiscal notaFiscal = new NotaFiscal();
                    notaFiscal.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numero"));
                    notaFiscal.DataEmissao= DbReader.GetDateTime(DbReader.GetOrdinal("dataemissao"));
                    notaFiscal.PrecoTotal = DbReader.GetDecimal(DbReader.GetOrdinal("precototal"));
                    notaFiscal.QuantidadeProduto = DbReader.GetInt32(DbReader.GetOrdinal("quantidadeproduto"));
                    notaFiscal.Carrinho.Numero = DbReader.GetInt32(DbReader.GetOrdinal("numerocarrinho"));
                    retorno.Add(notaFiscal);
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

        public void Update(NotaFiscal notaFiscal)
        {
            try
            {

                this.abrirConexao();
                string sql = "update notafiscal set numero = " + notaFiscal.Numero + ", dataemissao = '" + notaFiscal.DataEmissao + "', precototal = " + notaFiscal.PrecoTotal + ", quantidadeproduto = " + notaFiscal.QuantidadeProduto + ", numerocarrinho = " + notaFiscal.Carrinho.Numero + " where numero = " + notaFiscal.Numero;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e modifcar" + ex.Message);
            }
        }

        public bool VerificaDuplicidade(NotaFiscal notaFiscal)
        {
            bool retorno = false;
            try
            {
                this.abrirConexao();
                string sql = "select numero, dataemissao, precototal, quantidadeproduto, numerocarrinho from notafiscal where numero = " + notaFiscal.Numero;
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
