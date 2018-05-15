using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;
using BibliotecaShopFood.Conexao;

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
                sql = "insert into loja (CNPJ, RAZAO_SOCIAL, NOME_FANTASIA) values(" + loja.Cnpj + ",'" + loja.RazaoSocial + "','" + loja.NomeFantasia + "')" ;
                executaSql();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao conectar e inserir" + ex.Message);
            }
        }

        public List<Loja> Select(Loja filtro)
        {
            throw new NotImplementedException();
        }

        public void Update(Loja loja)
        {
            throw new NotImplementedException();
        }

        public bool VerificaDuplicidade(Loja loja)
        {
            throw new NotImplementedException();
        }
    }
}
