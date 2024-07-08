using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace VendaRapida.Data
{

    public class Conexao  // classe generica de conexao de dados
    {
        public string Host = "192.168.1.250";
        public string BancoDados = "VENDARAPIDA";
        public string Usuario = "fukuta";
        public string Senha = "Se39iry0#";
        public bool Ret = false;
        public MySqlConnection Conn;
        public string StatusConexao = "";
        public string StrQuery = "";
        public MySqlDataReader Dr;

        public bool Conecta()
        {
            MySqlConnectionStringBuilder StrCon = new MySqlConnectionStringBuilder();

            StrCon.Server = Host;
            StrCon.Port = 3306; // porta de serviço do mysql
            StrCon.UserID = Usuario;
            StrCon.Password = Senha;
            StrCon.Database = BancoDados;

            Conn = new MySqlConnection(StrCon.ToString());

            try
            {
                Conn.Open();
                Ret = true;
                StatusConexao = "BD conectado com sucesso !";
            }
            catch (MySqlException ex)
            {
                StatusConexao = ex.Message;
                Ret = false;
            }

            return Ret;
        }



    }

}
