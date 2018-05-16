using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BibliotecaShopFood.Conexao
{
   public class ConexaoBdSql
    {
        public SqlConnection sqlConn;
        public String sql;
        private const string local = @"DESKTOP-A8Q224L\SQLEXPRESS";
        private const string banco_de_dados = "SHOPFOOD";
        private const string usuario = "camilo";
        private const string senha = "140784";
        string connectionStringSqlServer = @"Data Source=" + local + ";Initial Catalog=" + banco_de_dados + ";UId=" + usuario + ";Password=" + senha + ";";


        public void abrirConexao()
        {
            this.sqlConn = new SqlConnection(connectionStringSqlServer);
            this.sqlConn.Open();
        }

        public void fecharConexao()
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }

        public void executaSql()
        {
            SqlCommand cmd = new SqlCommand(sql, this.sqlConn);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            this.fecharConexao();
                
        }
    }
}
