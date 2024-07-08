using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendaRapida.Data;
using MySqlConnector;
using System.Linq.Expressions;

namespace VendaRapida.Models
{
    public class PedidoComplClass : Conexao
    {
        public int Id { get; set; }
        public int Pedido_Id { get; set; }
        public int Produto_Id { get; set; }
        public int Quantidade { get; set; }
        public List<PedidoComplClass> lstPedCom = new List<PedidoComplClass>();

        public PedidoComplClass()
        {

        }


        public bool ExcluirProdutosPedido(int pPedido)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = true;
            StrQuery = "delete from PedidosCompl where `PedidoId`=" + pPedido.ToString();
            lstPedCom.Clear();
            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                int i = cmd.ExecuteNonQuery();
                if(i > 0 ){
                    Ret = true;
                } else
                {
                    Ret = false;
                }
            }
            Conn.Close();
            return Ret;
        }

        public bool BuscaProdutosPedido(int pPedido)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = true;
            StrQuery = "select * from PedidosCompl where `PedidoId`=" + pPedido.ToString();
            lstPedCom.Clear();
            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                Dr = cmd.ExecuteReader();
                while (Dr.Read())
                {
                    lstPedCom.Add(new PedidoComplClass
                    {
                        Id = int.Parse(Dr["Id"].ToString()),
                        Pedido_Id = int.Parse(Dr["PedidoId"].ToString()),
                        Produto_Id = int.Parse(Dr["ProdutoId"].ToString()),
                        Quantidade = int.Parse(Dr["Quantidade"].ToString())
                    });
                    Ret = true;
                }
            }
            Dr.Close(); Conn.Close();
            return Ret;
        }


        public bool SalvarProdutosPedido(int pId)
        {
            if (!Conecta())
            {
                return false;
            }

            Ret = true;

            StrQuery = "insert into `pedidoscompl` (`PedidoId`,`ProdutoId`,`Quantidade`) values (" +
                "@pedido_id,@produto_id,@quantidade)";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.Parameters.AddWithValue("@pedido_id", pId);
                cmd.Parameters.AddWithValue("@produto_id", Produto_Id);
                cmd.Parameters.AddWithValue("@quantidade", Quantidade);
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        Ret = true;
                    }
                }
                catch (MySqlException ex)
                {
                    Ret = false;
                }
            }

            Conn.Close();
            return Ret;


        }



    }
}
