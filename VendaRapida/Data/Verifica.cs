using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendaRapida.Data
{
    internal class Verifica : Conexao
    {

        public string TABLE_NAME { get; set; }
        public List<Verifica> listaVerifica = new List<Verifica>();

        public bool RetornaConexaoBD()
        {
            if (!Conecta())
            {
                return false;
            }
            Conn.Close();
            return true;
        }
        public bool RetornaTabelasNoDB()
        {
            Ret = false;
            if (!Conecta())
            {
                return false;
            }
            StrQuery = "SELECT * FROM information_schema.tables WHERE table_schema = 'VENDARAPIDA';";
            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                Dr = cmd.ExecuteReader();
                listaVerifica.Clear();
                while (Dr.Read())
                {
                    listaVerifica.Add(new Verifica
                    {
                        TABLE_NAME = Dr["TABLE_NAME"].ToString()
                    }); ;

                    Ret = true;
                }
            }

            Dr.Close(); Conn.Close();
            return Ret;
        }


    }
}
