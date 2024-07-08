using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;


namespace VendaRapida.Data 
{
    public static class GlobalVar
    {
        public static string NomeBancoDados = "VENDARAPIDA";

    }
    public class DataBank : Conexao
    {
        // Criar banco de Dados

        public bool CriarBanco()
        {
            bool Ret = false;
            
            string connStr = "server=" + Host + 
                             ";user=" + Usuario + 
                             ";port=" + 3306 + 
                             ";password=" + Senha;

            using (var conn = new MySqlConnection(connStr))
            using (var cmd = conn.CreateCommand())
            {
                conn.Open();
                cmd.CommandText = "CREATE DATABASE IF NOT EXISTS `" + GlobalVar.NomeBancoDados + "` CHARACTER SET latin1 COLLATE latin1_general_ci;";
                cmd.ExecuteNonQuery();
                Ret = true;
            }
            return Ret;
        }

        public bool CriarProdutos()
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "create table IF NOT EXISTS `Produtos` (`Id` int not null auto_increment, `descricao` varchar(100), `custo` decimal(13,2),`margem` decimal(13,2),`precovenda` decimal(13,2),`estoque` int, primary key (`Id`)) DEFAULT CHARSET=latin1";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.ExecuteNonQuery();
                Ret = true;
            }

            return Ret;
        }


        public bool CriarClientes()
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "create table IF NOT EXISTS `Clientes` (`Id` int not null auto_increment, `nome` varchar(100), `telefone` varchar(20), primary key (`Id`)) DEFAULT CHARSET=latin1";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.ExecuteNonQuery();
                Ret = true;
            }


            return Ret;
        }


        public bool CriarPrazos()
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "create table IF NOT EXISTS `Prazos` (`Id` int not null auto_increment, `Descricao` varchar(100), `Parcela1` int, `Parcela2` int, `Parcela3` int, `Desconto` decimal(13,2), primary key (`Id`)) DEFAULT CHARSET=latin1";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.ExecuteNonQuery();
                Ret = true;
            }

          
            return Ret;
        }

        public bool CriarPedidos()
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "create table IF NOT EXISTS `Pedidos` (`Id` int not null auto_increment, `Data` DateTime," +
                " `ClienteId` int, " +
                " `PrazoId` int," +
                " `Parcela1` DateTime," +
                " `Parcela2` DateTime," +
                " `Parcela3` DateTime," +
                " `TotalBruto` decimal(13,2)," +
                " `DescontoPor` decimal(13,2)," +
                " `DescontoReal` decimal(13,2)," +
                " `Totalpagar` decimal(13,2), primary key (`Id`)) DEFAULT CHARSET=latin1";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.ExecuteNonQuery();
                Ret = true;
            }

            if (Ret)
            {
                StrQuery = "ALTER TABLE `Pedidos` ADD CONSTRAINT `fk_IdClientes` FOREIGN KEY ( `ClienteId` ) REFERENCES `Clientes` ( `Id` ) ;";
                using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
                {
                    cmd.ExecuteNonQuery();
                    
                }

                StrQuery = "ALTER TABLE `Pedidos` ADD CONSTRAINT `fk_IdPrazos` FOREIGN KEY ( `PrazoId` ) REFERENCES `Prazos` ( `Id` ) ;";
                using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
                {
                    cmd.ExecuteNonQuery();
                   
                }

            }

            return Ret;
        }

        public bool CriarPedidosComplemento()
        {
            Ret = false;
            if (!Conecta())
            {
                return Ret;
            }

            StrQuery = "create table IF NOT EXISTS `PedidosCompl` (`Id` int not null auto_increment," +
                " `PedidoId` int, " +
                " `ProdutoId` int, " +
                " `Quantidade` int, primary key (`Id`)) DEFAULT CHARSET=latin1";

            using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
            {
                cmd.ExecuteNonQuery();
                Ret = true;
            }
            if(Ret)
            {

                StrQuery = "ALTER TABLE `PedidosCompl` ADD CONSTRAINT `fk_IdPedidos` FOREIGN KEY ( `PedidoId` ) REFERENCES `Pedidos` ( `Id` ) ;";
                using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
                {
                    cmd.ExecuteNonQuery();
                } 

                StrQuery = "ALTER TABLE `PedidosCompl` ADD CONSTRAINT `fk_IdProdutos` FOREIGN KEY ( `ProdutoId` ) REFERENCES `Produtos` ( `Id` ) ;";
                using (MySqlCommand cmd = new MySqlCommand(StrQuery, Conn))
                {
                    cmd.ExecuteNonQuery();
                }

            }

            return Ret;
        }






        // Criar tabelas de banco de dados


    }
}
