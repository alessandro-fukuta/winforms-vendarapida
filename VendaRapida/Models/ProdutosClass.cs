using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VendaRapida.Data;

namespace VendaRapida.Models
{
    public class ProdutosClass : Conexao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Custo { get; set; }
        public decimal Margem { get; set; }
        public decimal PrecoVenda { get; set; }
        public int Estoque { get; set; }
        public List<ProdutosClass> listaProdutos = new List<ProdutosClass>();
        public ProdutosClass()
        {

        }


        public bool BuscaLista()
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            StrQuery = "SELECT * FROM Produtos order by Descricao";
            listaProdutos.Clear();
            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader();

                while (Dr.Read())
                {
                    listaProdutos.Add(new ProdutosClass
                    {
                        Id = int.Parse(Dr["Id"].ToString()),
                        Descricao = Dr["Descricao"].ToString(),
                        Custo = decimal.Parse(Dr["Custo"].ToString()),
                        Margem = decimal.Parse(Dr["Margem"].ToString()),
                        PrecoVenda = decimal.Parse(Dr["PrecoVenda"].ToString()),
                        Estoque = int.Parse(Dr["Estoque"].ToString())
                    });
                    Ret = true;
                }

            }
            Dr.Close();
            Conn.Close();
            return Ret;
        }

        public bool Consulta(int pId)
        {
            if (!Conecta())
            {
                return false;
            }
            Ret = false;
            StrQuery = "SELECT * FROM Produtos Where Id=" + pId.ToString();

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = CommandType.Text;
                Dr = cmd.ExecuteReader();
                if (Dr.Read())
                {
                    Id = int.Parse(Dr["Id"].ToString());
                    Descricao = Dr["Descricao"].ToString();
                    Custo = decimal.Parse(Dr["Custo"].ToString());
                    Margem = decimal.Parse(Dr["Margem"].ToString());
                    PrecoVenda = decimal.Parse(Dr["PrecoVenda"].ToString());
                    Estoque = int.Parse(Dr["Estoque"].ToString());
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

                StrQuery = "INSERT INTO Produtos (`Descricao`,`Custo`,`Margem`,`PrecoVenda`,`Estoque` ) values (@descricao, @custo,@margem,@precovenda,@estoque)";

            }
            else
            {
                StrQuery = "UPDATE Produtos SET `descricao`=@descricao,`margem`=@margem,`custo`=@custo,`precovenda`=@precovenda,`estoque`=@estoque WHERE Id = " + pId.ToString();
            }

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Parameters.AddWithValue("@descricao", Descricao);
                cmd.Parameters.AddWithValue("@custo", decimal.Parse(Custo.ToString("N")));
                cmd.Parameters.AddWithValue("@margem", decimal.Parse(Margem.ToString("N")));
                cmd.Parameters.AddWithValue("@precovenda", decimal.Parse(PrecoVenda.ToString("N")));
                cmd.Parameters.AddWithValue("@estoque", Estoque);
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
