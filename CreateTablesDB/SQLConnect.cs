using System;
using System.Data.SqlClient;
using System.IO;
using System.Text;

namespace CreateTablesDB
{
    class SQLConnect
    {
        private SqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public SQLConnect()
        {
            Inicializar();
        }

        //private void Inicializar()
        //{
        //    server = "smartretail.c3nntdu4girq.sa-east-1.rds.amazonaws.com";
        //    database = "SmartRetail";
        //    uid = "sradmin";
        //    password = "SmartRetail";
        //    string connectionString;
        //    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        //    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        //    connection = new SqlConnection(connectionString);
        //}

        private void Inicializar()
        {
            server = "(localdb)\\SmartRetail";
            database = "SmartRetail";
            uid = "sa";
            password = "admin";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new SqlConnection(connectionString);
        }

        private bool AbrirConexao()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                Console.Write("Erro na conexão com o SQL Server! Código: " + ex.Number);
                return false;
            }
        }

        private bool FecharConexao()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                Console.Write("Erro ao encerrar a conexão com o SQL Server! Código: " + ex.Number);
                return false;
            }
        }

        public bool CreateTables()
        {
            string queryTables = File.ReadAllText(@"../../SQLTables.sql", Encoding.UTF8);
            if (AbrirConexao())
            {
                SqlCommand cmdTables = new SqlCommand(queryTables, connection);
                try
                {
                    cmdTables.ExecuteNonQuery();
                    FecharConexao();
                    return true;
                }
                catch
                {
                    FecharConexao();
                    return false;
                }
            }
            return false;
        }

        public bool AddAdmin()
        {
            string queryInfo = @"INSERT INTO InfoBasica (nome, cadastro, email, telefone, funcao) VALUES ('System Admin', 12345678910, 'admin@admin.com', 51999999999, 2); SELECT SCOPE_IDENTITY();";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);

                int infoID;
                try
                {
                    infoID = int.Parse(cmdInfo.ExecuteScalar().ToString());
                }
                catch
                {
                    return false;
                }

                if (infoID > 0)
                {
                    string queryGerente = "INSERT INTO Gerente (infoID, senha) VALUES (" + infoID + ", 'admin');";
                    SqlCommand cmdGerente = new SqlCommand(queryGerente, connection);
                    if (cmdGerente.ExecuteNonQuery() > 0)
                    {
                        FecharConexao();
                        return true;
                    }
                }
                FecharConexao();
            }
            return false;
        }
    }
}
