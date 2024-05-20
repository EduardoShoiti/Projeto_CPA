using Microsoft.VisualBasic;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintAgro
{
    internal class CadastroAgricultura
    {
        private int id;
        private string cultivo;
        private string estacaoAno;
        private string fertilizante;
        private string clima;
       
        public int Id 
        {
            get { return id; }
            set { id = value; }
        }

        public string Cultivo
        {
            get { return cultivo; }
            set { cultivo = value; }
        }

        public string EstacaoAno
        {
            get { return estacaoAno;}
            set { estacaoAno = value;}
        }

        public string Fertilizante
        {
            get { return fertilizante;}
            set { fertilizante = value;}
        }

        public string Clima
        {
            get { return clima; }
            set { clima = value; }
        }

        //Método para cadastrar agricultura no banco de dados

        public bool cadastrarAgro()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string insert = $"INSERT INTO agricultura (cultivo,estacaoAno,fertilizante,clima) values ('{Cultivo}', '{EstacaoAno}', '{Fertilizante}', '{Clima}')";

                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = insert;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - método cadastrar" + ex.Message);
                return false;
            }
        }


        public MySqlDataReader localizarAgricultura()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, cultivo, estacaoAno, fertilizante,clima from agricultura where cultivo = '{Cultivo}';";
                MySqlCommand comandosql = MysqlConexaoBanco.CreateCommand();
                comandosql.CommandText = select;

                MySqlDataReader reader = comandosql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - método localizar agricultura" + ex.Message);
                return null;
            }
        }

        public bool atualizarAgricultura()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update agricultura set cilma = '{Clima}', cultivo = '{Cultivo}', where id = '{Id}'";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro no banco de dados - Método atualizar funcionário" + ex.Message);
                return false;
            }
        }

        public bool  deletarAgricultura()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string delete = $"delete from agricultura where id = '{Id}' ";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Erro banco de dados - Método deletar agricultura" + ex.Message);
                return false;
            }
        }
    }
}
