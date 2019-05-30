using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRetail
{
    class SQLConnect
    {
        private SqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Construtor
        public SQLConnect()
        {
            Inicializar();
        }

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
                MessageBox.Show("Erro na conexão com o SQL Server! Código: " + ex.Number);
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
                MessageBox.Show("Erro ao encerrar a conexão com o servidor MySQL! Código: " + ex.Number);
                return false;
            }
        }

        public bool InserirGerente(Gerente gerente)
        {
            string queryInfo = @"INSERT INTO InfoBasica (nome, cadastro, email, telefone, funcao)
                                SELECT @nome, @cadastro, @email, @telefone, @funcao
                                WHERE NOT EXISTS (SELECT * from InfoBasica WHERE email = @email); SELECT SCOPE_IDENTITY();";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                cmdInfo.Parameters.AddWithValue("@nome", gerente.info.nome);
                cmdInfo.Parameters.AddWithValue("@cadastro", gerente.info.cadastro);
                cmdInfo.Parameters.AddWithValue("@email", gerente.info.email);
                cmdInfo.Parameters.AddWithValue("@telefone", gerente.info.telefone);
                cmdInfo.Parameters.AddWithValue("@funcao", gerente.info.funcao);

                int infoID;
                try
                {
                    string str_infoID = cmdInfo.ExecuteScalar().ToString();
                    infoID = int.Parse(str_infoID);
                }
                catch
                {
                    return false;
                }

                if (infoID > 0)
                {
                    string queryGerente = "INSERT INTO Gerente (infoID, senha) VALUES (" + infoID + ", '" + gerente.senha + "');";
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
        public bool InserirFornecedor(Fornecedor fornecedor, Produto[] produtos)
        {
            string queryInfo = @"INSERT INTO InfoBasica (nome, cadastro, email, telefone, funcao)
                                SELECT @nome, @cadastro, @email, @telefone, @funcao
                                WHERE NOT EXISTS (SELECT * from InfoBasica WHERE email = @email); SELECT SCOPE_IDENTITY();";

            string queryFornecedor = "INSERT INTO Fornecedor (infoID, senha) VALUES (@infoID, @senha);";

            string queryProdutos = "INSERT INTO Produto (nome, preco, fornecedorID, quantidade) VALUES (@nome, @preco, @fornecedorID, @quantidade);";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                cmdInfo.Parameters.AddWithValue("@nome", fornecedor.info.nome);
                cmdInfo.Parameters.AddWithValue("@cadastro", fornecedor.info.cadastro);
                cmdInfo.Parameters.AddWithValue("@email", fornecedor.info.email);
                cmdInfo.Parameters.AddWithValue("@telefone", fornecedor.info.telefone);
                cmdInfo.Parameters.AddWithValue("@funcao", fornecedor.info.funcao);

                int infoID;
                try
                {
                    string str_infoID = cmdInfo.ExecuteScalar().ToString();
                    infoID = int.Parse(str_infoID);
                }
                catch
                {
                    return false;
                }

                if (infoID > 0)
                {
                    SqlCommand cmdFornecedor = new SqlCommand(queryFornecedor, connection);
                    cmdFornecedor.Parameters.AddWithValue("@infoID", infoID);
                    cmdFornecedor.Parameters.AddWithValue("@senha", fornecedor.senha);

                    if (cmdFornecedor.ExecuteNonQuery() > 0)
                    {
                        foreach (Produto singleProduct in produtos)
                        {
                            SqlCommand cmdProdutos = new SqlCommand(queryProdutos, connection);
                            cmdProdutos.Parameters.AddWithValue("@nome", singleProduct.nome);
                            cmdProdutos.Parameters.AddWithValue("@preco", singleProduct.preco);
                            cmdProdutos.Parameters.AddWithValue("@quantidade", singleProduct.quantidade);
                            cmdProdutos.Parameters.AddWithValue("@fornecedorID", infoID);
                            if (cmdProdutos.ExecuteNonQuery() == 0)
                            {
                                return false;
                            }
                        }
                        
                        FecharConexao();
                        return true;
                    }
                }
                FecharConexao();
            }
            return false;
        }

        public bool RemoverUsuario(string email, int funcao)
        {
            string queryInfo = @"SELECT infoID FROM InfoBasica WHERE email = @email AND funcao = @funcao; DELETE FROM InfoBasica WHERE email = @email AND funcao = @funcao;";
            
            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                cmdInfo.Parameters.AddWithValue("@email", email);
                cmdInfo.Parameters.AddWithValue("@funcao", funcao);

                int infoID;
                try
                {
                    string str_infoID = cmdInfo.ExecuteScalar().ToString();
                    infoID = int.Parse(str_infoID);
                }
                catch
                {
                    return false;
                }

                if (infoID > 0)
                {
                    switch (funcao)
                    {
                        case 0:
                            return true;
                        case 1:
                            string queryProdFornecedor = "DELETE FROM Produto WHERE fornecedorID = @fornecedorID;";
                            SqlCommand cmdProdFornecedor = new SqlCommand(queryProdFornecedor, connection);
                            cmdProdFornecedor.Parameters.AddWithValue("@fornecedorID", infoID);

                            string queryFornecedor = "DELETE FROM Fornecedor WHERE infoID = @infoID;";
                            SqlCommand cmdFornecedor = new SqlCommand(queryFornecedor, connection);
                            cmdFornecedor.Parameters.AddWithValue("@infoID", infoID);

                            if (cmdProdFornecedor.ExecuteNonQuery() > 0 && cmdFornecedor.ExecuteNonQuery() > 0)
                            {
                                FecharConexao();
                                return true;
                            }
                            break;

                        case 2:
                            string queryGerente = "DELETE FROM Gerente WHERE infoID = @infoID;";
                            SqlCommand cmdGerente = new SqlCommand(queryGerente, connection);
                            cmdGerente.Parameters.AddWithValue("@infoID", infoID);
                            if (cmdGerente.ExecuteNonQuery() > 0)
                            {
                                FecharConexao();
                                return true;
                            }
                            break;
                    }
                }
                FecharConexao();
            }
            return false;
        }

        public int ValidarLogin(LoginData login)
        {
            string queryEmail = "SELECT * FROM InfoBasica WHERE email = '" + login.email + "';";

            if (AbrirConexao())
            {
                SqlCommand cmdEmail = new SqlCommand(queryEmail, connection);
                SqlDataReader readerInfo = cmdEmail.ExecuteReader();

                if (readerInfo.Read())
                {
                    int funcao = int.Parse(readerInfo["funcao"].ToString());
                    int infoID = int.Parse(readerInfo["infoID"].ToString());
                    readerInfo.Close();

                    if (funcao > 0)
                    {
                        string querySenha = "SELECT * FROM " + (funcao == 2 ? "Gerente" : "Fornecedor") + " WHERE infoID = '" + infoID + "' and senha = '" + login.senha + "';";
                        SqlCommand cmdSenha = new SqlCommand(querySenha, connection);
                        SqlDataReader readerSenha = cmdSenha.ExecuteReader();

                        if (readerSenha.HasRows)
                        {
                            return funcao;
                        }
                    }
                }
                FecharConexao();
            }
            return 0;
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        ////Select statement
        //public List<string>[] Select()
        //{
        //}

        ////Count statement
        //public int Count()
        //{
        //}

        ////Backup
        //public void Backup()
        //{
        //}

        ////Restore
        //public void Restore()
        //{
        //}
    }
}
