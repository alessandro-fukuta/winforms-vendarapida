using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using VendaRapida.Data;
namespace VendaRapida.Models
{
    public class PedidoClass : Conexao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Cliente_Id { get; set; }
        public int Prazo_id { get; set; }
        public decimal Total_Bruto { get; set; }
        public decimal Desconto_por { get; set; }
        public decimal Desconto_Real { get; set; }
        public decimal Total_Pagar { get; set; }
        public DateTime? Parcela1 { get; set; }
        public DateTime? Parcela2 { get; set; }
        public DateTime? Parcela3 { get; set; }

        public PedidoClass()
        {

        }

        public bool Consulta(int pId)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            StrQuery = "SELECT * FROM Pedidos Where Id=" + pId.ToString();

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    Id = int.Parse(Dr["Id"].ToString());
                    Data = DateTime.Parse(Dr["Data"].ToString());
                    Cliente_Id = int.Parse(Dr["ClienteId"].ToString());
                    Prazo_id = int.Parse(Dr["PrazoId"].ToString());
                    Parcela1 = DateTime.Parse(Dr["Parcela1"].ToString());
                    if (!string.IsNullOrEmpty(Dr["Parcela2"].ToString()))
                    {
                        Parcela2 = DateTime.Parse(Dr["Parcela2"].ToString());
                    }
                    else
                    {
                        Parcela2 = null;
                    }
                    if (!string.IsNullOrEmpty(Dr["Parcela3"].ToString()))
                    {
                        Parcela3 = DateTime.Parse(Dr["Parcela3"].ToString());
                    }
                    else
                    {
                        Parcela3 = null;
                    }

                    Desconto_por = decimal.Parse(Dr["Descontopor"].ToString());
                    Desconto_Real = decimal.Parse(Dr["Descontoreal"].ToString());
                    Total_Bruto = decimal.Parse(Dr["totalbruto"].ToString());
                    Total_Pagar = decimal.Parse(Dr["totalpagar"].ToString());

                    Ret = true;
                }
            }
            Dr.Close();
            Conn.Close();
            return Ret;
        }

        /*
         if (cmd.LastInsertedId != 0)
                    cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));
                // Retorna o id do novo rgistro e convert de Int64 para Int32 (int).
                return Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);
            }

        */

        public bool Salvar(bool pIncluir, int pId)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            if (pIncluir)
            {
                StrQuery = "insert into Pedidos (`data`,`clienteid`,`prazoid`," +
                    "`descontopor`,`descontoreal`,`totalbruto`,`totalpagar`," +
                    "`Parcela1`,`Parcela2`,`Parcela3`) values " +
                    "(@data,@clienteid,@prazoid,@descontopor,@descontoreal," +
                    "@totalbruto,@totalpagar,@parcela1,@parcela2,@parcela3)";

            }
            else
            {
                StrQuery = "update `Pedidos` set  `data`=@data,`clienteid`=@clienteid," +
                    "`descontopor`=@descontopor,`descontoreal`=@descontoreal," +
                    "`totalbruto`=@totalbruto,`totalpagar`=@totalpagar," +
                    "`Parcela1`=@parcela1,`Parcela2`=@parcela2,`Parcela3`=@parcela3 " +
                    "WHERE `Id`=" + pId.ToString();
            }

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Parameters.AddWithValue("@clienteid", Cliente_Id);
                cmd.Parameters.AddWithValue("@prazoid", Prazo_id);
                cmd.Parameters.AddWithValue("@descontopor", Desconto_por);
                cmd.Parameters.AddWithValue("@descontoreal", Desconto_Real);
                cmd.Parameters.AddWithValue("@totalbruto", Total_Bruto);
                cmd.Parameters.AddWithValue("@totalpagar", Total_Pagar);
                cmd.Parameters.AddWithValue("@parcela1", Parcela1);
                cmd.Parameters.AddWithValue("@parcela2", Parcela2);
                cmd.Parameters.AddWithValue("@parcela3", Parcela3);

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {   // buscando o Id do ultmo registro
                        if (pIncluir)
                        {
                            if (cmd.LastInsertedId != 0)
                            {
                                cmd.Parameters.Add(new MySqlParameter("ultimoId", cmd.LastInsertedId));
                                Id = Convert.ToInt32(cmd.Parameters["@ultimoId"].Value);
                                Ret = true;
                            }
                        } else
                        {
                            Ret = true;
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // ex;
                    Ret = false;
                }

            }

            Conn.Close();
            return Ret;
        }

    }
}
