using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaRapida.Data;

namespace VendaRapida.Models
{
    public class ClientesClass : Conexao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public ClientesClass()
        {

        }

        public bool Consulta(int pId)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            StrQuery = "SELECT * FROM Clientes Where Id=" + pId.ToString();

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    Id = int.Parse(Dr["Id"].ToString());
                    Nome = Dr["Nome"].ToString();
                    Telefone = Dr["Telefone"].ToString();
                    Ret = true;
                }
            }
            Dr.Close();
            Conn.Close();
            return Ret;
        }


        public bool Salvar(bool pIncluir, int pId)
        {
           
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            if (pIncluir)
            {

                StrQuery = "INSERT INTO Clientes (`Nome`,`Telefone` ) values (@nome, @telefone)";

            }
            else
            {
                StrQuery = "UPDATE Clientes SET `nome`=@nome, `Telefone`=@telefone WHERE Id = " + pId.ToString();
            }

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@nome", Nome);
                cmd.Parameters.AddWithValue("@telefone", Telefone);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Ret = true;
                    }
                }
                catch (Exception ex)
                {
                    Ret = false;
                }

            }

            Conn.Close();
            return Ret;

        }




    }
}
