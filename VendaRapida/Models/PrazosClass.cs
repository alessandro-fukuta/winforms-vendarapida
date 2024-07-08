using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaRapida.Data;

namespace VendaRapida.Models
{
    public class PrazosClass : Conexao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Parcela1 { get; set; }
        public int Parcela2 { get; set; }
        public int Parcela3 { get; set; }
        public decimal Desconto { get; set; }

        public PrazosClass()
        {

        }


        public bool Consulta(int pId)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            StrQuery = "SELECT * FROM Prazos Where Id=" + pId.ToString();

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    Id = int.Parse(Dr["Id"].ToString());
                    Descricao = Dr["Descricao"].ToString();
                    Parcela1 = int.Parse( Dr["Parcela1"].ToString());
                    Parcela2 = int.Parse( Dr["Parcela2"].ToString());
                    Parcela3 = int.Parse( Dr["Parcela3"].ToString());
                    Desconto = decimal.Parse( Dr["Desconto"].ToString());
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

                StrQuery = "INSERT INTO Prazos (`Descricao`,`Parcela1`,`Parcela2`,`Parcela3`,`Desconto` ) values (@descricao, @parcela1,@parcela2,@parcela3,@desconto)";

            }
            else
            {
                StrQuery = "UPDATE Prazos SET `descricao`=@descricao, `Parcela1`=@parcela1,`Parcela2`=@parcela2,`Parcela3`=@parcela3,`Desconto`=@desconto  WHERE Id = " + pId.ToString();
            }

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@parcela1", Parcela1);
                cmd.Parameters.AddWithValue("@parcela2", Parcela2);
                cmd.Parameters.AddWithValue("@parcela3", Parcela3);
                cmd.Parameters.AddWithValue("@desconto", decimal.Parse( Desconto.ToString("N")));
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



        // fim da classe
    }
}
