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
                MessageBox.Show("Erro na conexão com o servidor MySQL! Código: " + ex.Number);
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
                MessageBox.Show("Erro ao encerrar a conexão com o servidor MySQL! Código: " + ex.Message);
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

                int infoID = int.Parse(cmdInfo.ExecuteScalar().ToString());

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

        public bool RemoverUsuario(string email, int funcao)
        {
            MessageBox.Show(email + " " + funcao.ToString());
            //string queryInfo = @"INSERT INTO InfoBasica (nome, cadastro, email, telefone, funcao) VALUES (@nome, @cadastro, @email, @telefone, @funcao) WHERE NOT EXISTS (SELECT * from InfoBasica WHERE email = @email);";
            string queryInfo = @"SELECT infoID FROM InfoBasica WHERE email = @email AND funcao = @funcao; DELETE FROM InfoBasica WHERE email = @email AND funcao = @funcao;";
            //string queryInfo = @"SELECT infoID FROM InfoBasica WHERE email = @email AND funcao = @funcao; SELECT SCOPE_IDENTITY();";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                cmdInfo.Parameters.AddWithValue("@email", email);
                cmdInfo.Parameters.AddWithValue("@funcao", funcao);

                string str_infoID = null;
                int infoID = 0;

                try
                {
                    str_infoID = cmdInfo.ExecuteScalar().ToString();
                    infoID = int.Parse(str_infoID);
                }
                catch
                {
                    return false;
                }
                //string str_infoID = cmdInfo.ExecuteScalar().ToString();
                

                //if(str_infoID != null)
                //{
                //    infoID = int.Parse(str_infoID);
                //}
                // = int.Parse(cmdInfo.ExecuteScalar().ToString()); //TODO: Corrigir erro aqui

                MessageBox.Show(infoID.ToString());

                if (infoID > 0)
                {
                    //TODO: Implementar a remoção das outras tabelas: Gerente, Fornecedor e Produtos

                    //string queryGerente = "INSERT INTO Gerente (infoID, senha) VALUES (" + infoID + ", '" + gerente.senha + "');";
                    //SqlCommand cmdGerente = new SqlCommand(queryGerente, connection);
                    //if (cmdGerente.ExecuteNonQuery() > 0)
                    //{
                    //    FecharConexao();
                    //    return true;
                    //}
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
