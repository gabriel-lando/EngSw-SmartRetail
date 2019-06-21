using System;
using System.Collections;
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

        //private void Inicializar()
        //{
        //    server = "(localdb)\\SmartRetail";
        //    database = "SmartRetail";
        //    uid = "sa";
        //    password = "admin";
        //    string connectionString;
        //    connectionString = "SERVER=" + server + ";" + "DATABASE=" +
        //    database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        //    connection = new SqlConnection(connectionString);
        //}
        private void Inicializar()
        {
            server = "smartretail.c3nntdu4girq.sa-east-1.rds.amazonaws.com";
            database = "SmartRetail";
            uid = "sradmin";
            password = "SmartRetail";
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

            string queryProdutos = "INSERT INTO Produto (nome, preco, fornecedorID, quantidade, prateleira, validade) VALUES (@nome, @preco, @fornecedorID, @quantidade, @prateleira, @validade);";

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
                            cmdProdutos.Parameters.AddWithValue("@prateleira", singleProduct.prateleira);
                            cmdProdutos.Parameters.AddWithValue("@validade", singleProduct.validade.Date);
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
                        case 0: //TODO: Remover Carrinho e afins
                            string queryCliente = "DELETE FROM Cliente WHERE infoID = @infoID;";
                            SqlCommand cmdCliente = new SqlCommand(queryCliente, connection);
                            cmdCliente.Parameters.AddWithValue("@infoID", infoID);
                            if (cmdCliente.ExecuteNonQuery() > 0)
                            {
                                FecharConexao();
                                return true;
                            }
                            break;
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

        public int ValidarLogin(out int retID, LoginData login)
        {
            retID = 0;
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
                            retID = infoID;
                            return funcao;
                        }
                    }
                }
                FecharConexao();
            }
            return 0;
        }

        public int ValidaCliente(string filename)
        {
            string queryFacial = "SELECT * FROM Cliente WHERE facial_data = @facial;";

            if (AbrirConexao())
            {
                SqlCommand cmdFacial = new SqlCommand(queryFacial, connection);
                cmdFacial.Parameters.AddWithValue("@facial", filename);
                SqlDataReader readerFacial = cmdFacial.ExecuteReader();

                if (readerFacial.Read()) // Se não encontrar, retorna -1, para efetuar o cadastro.
                {
                    int infoID = int.Parse(readerFacial["infoID"].ToString());
                    bool onStore = bool.Parse(readerFacial["onStore"].ToString());
                    readerFacial.Close();

                    if (onStore) // Se onStore = true, marca que ele saiu da loja e retorna a infoID do cliente. Se onStore = false, então marca que ele entrou na loja e retorna 0.
                    {
                        string queryOnStore = "UPDATE Cliente SET onStore = 0 WHERE infoID = " + infoID + ";";
                        SqlCommand cmdOnStore = new SqlCommand(queryOnStore, connection);

                        if (cmdOnStore.ExecuteNonQuery() > 0)
                        {
                            return infoID;
                        }
                    }

                    else
                    {
                        string queryNewCart = @"INSERT INTO Carrinho (infoID, preco_total) VALUES (" + infoID + ", 0); SELECT SCOPE_IDENTITY();";
                        SqlCommand cmdNewCart = new SqlCommand(queryNewCart, connection);

                        int carrinhoID;
                        try
                        {
                            carrinhoID = int.Parse(cmdNewCart.ExecuteScalar().ToString());
                        }
                        catch
                        {
                            return -2;
                        }

                        string queryOnStore = "UPDATE Cliente SET onStore = 1, carrinhoID = " + carrinhoID + " WHERE infoID = " + infoID + ";";
                        SqlCommand cmdOnStore = new SqlCommand(queryOnStore, connection);
                        
                        if (cmdOnStore.ExecuteNonQuery() > 0)
                        {
                            return 0;
                        }
                    }
                }
                FecharConexao();
                return -1;
            }
            return -2;
        }

        public bool InserirCliente(Cliente cliente)
        {
            string queryInfo = @"INSERT INTO InfoBasica (nome, cadastro, email, telefone, funcao)
                                SELECT @nome, @cadastro, @email, @telefone, @funcao
                                WHERE NOT EXISTS (SELECT * from Cliente WHERE facial_data = @facial); SELECT SCOPE_IDENTITY();";

            string queryCliente = @"INSERT INTO Cliente (infoID, facial_data, endereco_cobranca, nro_cartao_de_credito, carrinhoID, onStore)
                                    SELECT @infoID, @facial, @endereco, @cartao, @carrinhoID, @onStore";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                cmdInfo.Parameters.AddWithValue("@nome", cliente.info.nome);
                cmdInfo.Parameters.AddWithValue("@cadastro", cliente.info.cadastro);
                cmdInfo.Parameters.AddWithValue("@email", cliente.info.email);
                cmdInfo.Parameters.AddWithValue("@telefone", cliente.info.telefone);
                cmdInfo.Parameters.AddWithValue("@funcao", cliente.info.funcao);
                cmdInfo.Parameters.AddWithValue("@facial", cliente.facial_data);

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
                    string queryNewCart = @"INSERT INTO Carrinho (infoID, preco_total) VALUES (" + infoID + ", 0); SELECT SCOPE_IDENTITY();";
                    SqlCommand cmdNewCart = new SqlCommand(queryNewCart, connection);

                    int carrinhoID;
                    try
                    {
                        carrinhoID = int.Parse(cmdNewCart.ExecuteScalar().ToString());
                    }
                    catch
                    {
                        return false;
                    }

                    SqlCommand cmdCliente = new SqlCommand(queryCliente, connection);
                    cmdCliente.Parameters.AddWithValue("@infoID", infoID);
                    cmdCliente.Parameters.AddWithValue("@facial", cliente.facial_data);
                    cmdCliente.Parameters.AddWithValue("@endereco", cliente.endereco_cobranca);
                    cmdCliente.Parameters.AddWithValue("@cartao", cliente.nro_carta_de_credito);
                    cmdCliente.Parameters.AddWithValue("@carrinhoID", carrinhoID);
                    cmdCliente.Parameters.AddWithValue("@onStore", 1);

                    if (cmdCliente.ExecuteNonQuery() > 0)
                    {
                        FecharConexao();
                        return true;
                    }
                }
                FecharConexao();
            }
            return false;
        }

        public int DetectaCliente(string filename)
        {
            string queryFacial = "SELECT * FROM Cliente WHERE facial_data = @facial;";

            if (AbrirConexao())
            {
                SqlCommand cmdFacial = new SqlCommand(queryFacial, connection);
                cmdFacial.Parameters.AddWithValue("@facial", filename);
                SqlDataReader readerFacial = cmdFacial.ExecuteReader();

                if (readerFacial.Read())
                {
                    int infoID = int.Parse(readerFacial["infoID"].ToString());
                    bool onStore = bool.Parse(readerFacial["onStore"].ToString());
                    readerFacial.Close();

                    if (onStore) // Se onStore = true, retorna a infoID do cliente.
                    {
                        return infoID;
                    }
                }
                FecharConexao();
            }
            return 0;
        }

        public bool LoadAllProducts(out List<Produto> produtosDB)
        {
            produtosDB = new List<Produto>();
            string queryProducts = "SELECT * FROM Produto;";

            if(!LoadAllOffers(out List<Oferta> ofertasDB))
            {
                return false;
            }

            Oferta[] ofertas = ofertasDB.ToArray();

            if (AbrirConexao())
            {
                SqlCommand cmdProducts = new SqlCommand(queryProducts, connection);
                SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                while (readerProducts.Read())
                {
                    int productID = int.Parse(readerProducts["productID"].ToString());
                    string nome = readerProducts["nome"].ToString();
                    float preco = float.Parse(readerProducts["preco"].ToString());
                    int fornecedorID = int.Parse(readerProducts["fornecedorID"].ToString());
                    int qtde = int.Parse(readerProducts["quantidade"].ToString());
                    int prateleira = int.Parse(readerProducts["prateleira"].ToString());
                    DateTime validade = DateTime.Parse(readerProducts["validade"].ToString()).Date;

                    if (qtde >= 0)
                    {
                        foreach (Oferta oferta in ofertas)
                        {
                            if (oferta.productID == productID)
                            {
                                preco *= (1 - (oferta.desconto) / 100);
                                break;
                            }
                        }

                        produtosDB.Add(new Produto()
                        {
                            productID = productID,
                            nome = nome,
                            fornecedorID = fornecedorID,
                            preco = preco,
                            validade = validade,
                            prateleira = prateleira,
                            quantidade = qtde
                        });
                    }
                }

                FecharConexao();

                if (produtosDB.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LoadSomeProducts(out List<Produto> produtosDB, List<int> produtos)
        {
            produtosDB = new List<Produto>();
            string queryProducts = "SELECT * FROM Produto WHERE productID = @productID;";
            if (AbrirConexao())
            {
                foreach(int productID in produtos)
                {
                    SqlCommand cmdProducts = new SqlCommand(queryProducts, connection);
                    cmdProducts.Parameters.AddWithValue("@productID", productID);
                    SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                    if (readerProducts.Read())
                    {
                        string nome = readerProducts["nome"].ToString();
                        float preco = float.Parse(readerProducts["preco"].ToString());
                        int fornecedorID = int.Parse(readerProducts["fornecedorID"].ToString());
                        int qtde = int.Parse(readerProducts["quantidade"].ToString());
                        int prateleira = int.Parse(readerProducts["prateleira"].ToString());
                        DateTime validade = DateTime.Parse(readerProducts["validade"].ToString()).Date;

                        produtosDB.Add(new Produto()
                        {
                            productID = productID,
                            nome = nome,
                            fornecedorID = fornecedorID,
                            preco = preco,
                            validade = validade,
                            prateleira = prateleira,
                            quantidade = qtde
                        });

                        readerProducts.Close();
                    }
                }
                FecharConexao();

                if (produtosDB.Count() >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool LoadAllOffers(out List<Oferta> ofertasDB)
        {
            ofertasDB = new List<Oferta>();
            string queryOffers = "SELECT * FROM Oferta;";
            if (AbrirConexao())
            {
                SqlCommand cmdOffers = new SqlCommand(queryOffers, connection);
                SqlDataReader readerOffers = cmdOffers.ExecuteReader();

                while (readerOffers.Read())
                {
                    int productID = int.Parse(readerOffers["productID"].ToString());
                    string nome = readerOffers["nome"].ToString();
                    float desconto = float.Parse(readerOffers["desconto"].ToString());
                    DateTime duracao = DateTime.Parse(readerOffers["duracao"].ToString()).Date;

                    ofertasDB.Add(new Oferta()
                    {
                        productID = productID,
                        nome = nome,
                        desconto = desconto,
                        duracao = duracao
                    });
                }

                FecharConexao();

                if (ofertasDB.Count() >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool SaveOffers(List<Oferta> ofertasDB)
        {
            string queryDelOffers = "DELETE FROM Oferta WHERE productID >= 0; ";
            if (AbrirConexao())
            {
                SqlCommand cmdDelOffers = new SqlCommand(queryDelOffers, connection);
                cmdDelOffers.ExecuteNonQuery();

                Oferta[] ofertasArray = ofertasDB.ToArray();

                foreach (Oferta oferta in ofertasArray)
                {
                    string queryInsOffer = "INSERT INTO Oferta (productID, nome, desconto, duracao) VALUES (@productID, @nome, @desconto, @duracao);";

                    SqlCommand cmdInsOffer = new SqlCommand(queryInsOffer, connection);
                    cmdInsOffer.Parameters.AddWithValue("@productID", oferta.productID);
                    cmdInsOffer.Parameters.AddWithValue("@nome", oferta.nome);
                    cmdInsOffer.Parameters.AddWithValue("@desconto", oferta.desconto);
                    cmdInsOffer.Parameters.AddWithValue("@duracao", oferta.duracao.Date);
                    if (cmdInsOffer.ExecuteNonQuery() == 0)
                    {
                        return false;
                    }
                }

                FecharConexao();

                return true;
            }
            return false;
        }

        public bool LoadSpecialOffers(out List<Oferta> ofertasDB)
        {
            ofertasDB = new List<Oferta>();
            string queryOffers = "SELECT TOP 2 * FROM Oferta ORDER BY NEWID();";
            if (AbrirConexao())
            {
                SqlCommand cmdOffers = new SqlCommand(queryOffers, connection);
                SqlDataReader readerOffers = cmdOffers.ExecuteReader();

                while (readerOffers.Read())
                {
                    int productID = int.Parse(readerOffers["productID"].ToString());
                    string nome = readerOffers["nome"].ToString();
                    float desconto = float.Parse(readerOffers["desconto"].ToString());
                    DateTime duracao = DateTime.Parse(readerOffers["duracao"].ToString()).Date;

                    ofertasDB.Add(new Oferta()
                    {
                        productID = productID,
                        nome = nome,
                        desconto = desconto,
                        duracao = duracao
                    });
                }

                FecharConexao();

                if (ofertasDB.Count() >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ChangeProdutoCarrinho(int infoID, Produto produto, int qtde) // Buscar carrinhoID, criar Sacola com carrinhoID, productID e quantidade, subtrair quantidade do productID 
        {
            string queryCarrinhoID = "SELECT * FROM Cliente WHERE infoID = @infoID;";

            if (AbrirConexao())
            {
                SqlCommand cmdCarrinhoID = new SqlCommand(queryCarrinhoID, connection);
                cmdCarrinhoID.Parameters.AddWithValue("@infoID", infoID);
                SqlDataReader readerCarrinhoID = cmdCarrinhoID.ExecuteReader();

                if (readerCarrinhoID.Read())
                {
                    int carrinhoID = int.Parse(readerCarrinhoID["carrinhoID"].ToString());
                    readerCarrinhoID.Close();

                    if (carrinhoID > 0) // Se existir carrinho, cria uma sacola com o produto e subtrai a qtde do estoque
                    {
                        string queryUpdateQtde = "UPDATE Produto SET quantidade = quantidade - @quantidade WHERE productID = @productID;";
                        string queryUpdateCarrinho = "UPDATE Carrinho SET preco_total = preco_total + @preco_total WHERE carrinhoID = @carrinhoID;";
                        string queryAddSacola = @"IF EXISTS(SELECT * FROM Sacola WHERE carrinhoID = @carrinhoID AND productID = @productID)
                                                    UPDATE Sacola SET quantidade = quantidade + @quantidade WHERE carrinhoID = @carrinhoID AND productID = @productID;
                                                ELSE
                                                    INSERT INTO Sacola (carrinhoID, productID, quantidade) SELECT @carrinhoID, @productID, @quantidade;";

                        SqlCommand cmdUpdateQtde = new SqlCommand(queryUpdateQtde, connection);
                        cmdUpdateQtde.Parameters.AddWithValue("@quantidade", qtde);
                        cmdUpdateQtde.Parameters.AddWithValue("@productID", produto.productID);

                        SqlCommand cmdUpdateCarrinho = new SqlCommand(queryUpdateCarrinho, connection);
                        cmdUpdateCarrinho.Parameters.AddWithValue("@preco_total", qtde * produto.preco);
                        cmdUpdateCarrinho.Parameters.AddWithValue("@carrinhoID", carrinhoID);

                        SqlCommand cmdAddSacola = new SqlCommand(queryAddSacola, connection);
                        cmdAddSacola.Parameters.AddWithValue("@carrinhoID", carrinhoID);
                        cmdAddSacola.Parameters.AddWithValue("@productID", produto.productID);
                        cmdAddSacola.Parameters.AddWithValue("@quantidade", qtde);

                        if (cmdUpdateQtde.ExecuteNonQuery() > 0 && cmdAddSacola.ExecuteNonQuery() > 0 && cmdUpdateCarrinho.ExecuteNonQuery() > 0)
                        {
                            return true;
                        }
                    }
                }
                FecharConexao();
            }
            return false;
        }

        public bool ReturnProductsFornecedor(out List<Produto> produtosDB, int infoID)
        {
            produtosDB = new List<Produto>();

            string queryProducts = "SELECT * FROM Produto WHERE fornecedorID = @fornecedorID;";
            if (AbrirConexao())
            {
                SqlCommand cmdProducts = new SqlCommand(queryProducts, connection);
                cmdProducts.Parameters.AddWithValue("@fornecedorID", infoID);
                SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                while (readerProducts.Read())
                {
                    int productID = int.Parse(readerProducts["productID"].ToString());
                    string nome = readerProducts["nome"].ToString();
                    float preco = float.Parse(readerProducts["preco"].ToString());
                    int fornecedorID = int.Parse(readerProducts["fornecedorID"].ToString());
                    int qtde = int.Parse(readerProducts["quantidade"].ToString());
                    int prateleira = int.Parse(readerProducts["prateleira"].ToString());
                    DateTime validade = DateTime.Parse(readerProducts["validade"].ToString()).Date;

                    produtosDB.Add(new Produto()
                    {
                        productID = productID,
                        nome = nome,
                        fornecedorID = fornecedorID,
                        preco = preco,
                        validade = validade,
                        prateleira = prateleira,
                        quantidade = qtde
                    });
                }
                if (produtosDB.Count() > 0)
                {
                    return true;
                }
                FecharConexao();
            }

            return false;
        }

        public bool RemoveProductsFornecedor(List<Produto> produtosDB)
        {
            if (AbrirConexao())
            {
                Produto[] produtosArray = produtosDB.ToArray();

                foreach (Produto singleProduct in produtosArray)
                {
                    string queryProdFornecedor = "DELETE FROM Oferta WHERE productID = @productID; DELETE FROM Sacola WHERE productID = @productID; DELETE FROM Produto WHERE productID = @productID;";
                    SqlCommand cmdProdFornecedor = new SqlCommand(queryProdFornecedor, connection);
                    cmdProdFornecedor.Parameters.AddWithValue("@productID", singleProduct.productID);

                    cmdProdFornecedor.ExecuteNonQuery();
                }

                FecharConexao();
                return true;
            }
            return false;
        }

        public bool UpdateProductsFornecedor(List<Produto> produtosDB)
        {
            if (AbrirConexao())
            {
                Produto[] produtosArray = produtosDB.ToArray();

                foreach (Produto singleProduct in produtosArray)
                {
                    string queryProdFornecedor = "UPDATE Oferta SET nome = @nome WHERE productID = @productID; UPDATE Produto SET nome = @nome, preco = @preco, quantidade = @quantidade, prateleira = @prateleira, validade = @validade WHERE productID = @productID";
                    SqlCommand cmdProdutos = new SqlCommand(queryProdFornecedor, connection);
                    cmdProdutos.Parameters.AddWithValue("@productID", singleProduct.productID);
                    cmdProdutos.Parameters.AddWithValue("@nome", singleProduct.nome);
                    cmdProdutos.Parameters.AddWithValue("@preco", singleProduct.preco);
                    cmdProdutos.Parameters.AddWithValue("@quantidade", singleProduct.quantidade);
                    cmdProdutos.Parameters.AddWithValue("@prateleira", singleProduct.prateleira);
                    cmdProdutos.Parameters.AddWithValue("@validade", singleProduct.validade.Date);

                    cmdProdutos.ExecuteNonQuery();
                }

                FecharConexao();
                return true;
            }
            return false;
        }

        public bool InsertProductsFornecedor(List<Produto> produtosDB)
        {
            if (AbrirConexao())
            {
                Produto[] produtosArray = produtosDB.ToArray();

                foreach (Produto singleProduct in produtosArray)
                {
                    string queryProdutos = "INSERT INTO Produto (nome, preco, fornecedorID, quantidade, prateleira, validade) VALUES (@nome, @preco, @fornecedorID, @quantidade, @prateleira, @validade);";

                    SqlCommand cmdProdutos = new SqlCommand(queryProdutos, connection);
                    cmdProdutos.Parameters.AddWithValue("@nome", singleProduct.nome);
                    cmdProdutos.Parameters.AddWithValue("@preco", singleProduct.preco);
                    cmdProdutos.Parameters.AddWithValue("@quantidade", singleProduct.quantidade);
                    cmdProdutos.Parameters.AddWithValue("@fornecedorID", singleProduct.fornecedorID);
                    cmdProdutos.Parameters.AddWithValue("@prateleira", singleProduct.prateleira);
                    cmdProdutos.Parameters.AddWithValue("@validade", singleProduct.validade.Date);
                    if (cmdProdutos.ExecuteNonQuery() == 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        public bool GenerateNF(int infoID, int carrinhoID)
        {
            if (AbrirConexao())
            {
                string queryVenda = "INSERT INTO Venda (carrinhoID, infoID) VALUES (@carrinhoID, @infoID);";
                SqlCommand cmdVenda = new SqlCommand(queryVenda, connection);
                cmdVenda.Parameters.AddWithValue("@carrinhoID", carrinhoID);
                cmdVenda.Parameters.AddWithValue("@infoID", infoID);

                if (cmdVenda.ExecuteNonQuery() > 0)
                {
                    FecharConexao();
                    return true;
                }
            }
            return false;
        }

        public bool ReturnAllClients(out List<Cliente> clientesDB, out List<InfoBasica> infoBasicasDB)
        {
            clientesDB = new List<Cliente>();
            infoBasicasDB = new List<InfoBasica>();

            string queryInfo = "SELECT * FROM InfoBasica WHERE funcao = 0;";
            string queryClientes = "SELECT * FROM Cliente;";
            
            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                SqlDataReader readerInfo = cmdInfo.ExecuteReader();

                while (readerInfo.Read())
                {
                    int infoID = int.Parse(readerInfo["infoID"].ToString());
                    string nome = readerInfo["nome"].ToString();
                    string email = readerInfo["email"].ToString();
                    long cadastro = long.Parse(readerInfo["cadastro"].ToString());
                    long telefone = long.Parse(readerInfo["telefone"].ToString());

                    infoBasicasDB.Add(new InfoBasica()
                    {
                        infoID = infoID,
                        nome = nome,
                        email = email,
                        cadastro = cadastro,
                        telefone = telefone
                    });
                }
                readerInfo.Close();

                SqlCommand cmdClientes = new SqlCommand(queryClientes, connection);
                SqlDataReader readerClientes = cmdClientes.ExecuteReader();

                while (readerClientes.Read())
                {
                    int infoID = int.Parse(readerClientes["infoID"].ToString());
                    string endereco = readerClientes["endereco_cobranca"].ToString();

                    clientesDB.Add(new Cliente()
                    {
                        infoID = infoID,
                        endereco_cobranca = endereco
                    });
                }
                readerClientes.Close();

                FecharConexao();

                if (infoBasicasDB.Count() == clientesDB.Count())
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReturnAllFornGer(out List<InfoBasica> infoBasicasDB, int funcao)
        {
            infoBasicasDB = new List<InfoBasica>();

            string queryInfo = "SELECT * FROM InfoBasica WHERE funcao = " + funcao + ";";

            if (AbrirConexao())
            {
                SqlCommand cmdInfo = new SqlCommand(queryInfo, connection);
                SqlDataReader readerInfo = cmdInfo.ExecuteReader();

                while (readerInfo.Read())
                {
                    int infoID = int.Parse(readerInfo["infoID"].ToString());
                    string nome = readerInfo["nome"].ToString();
                    string email = readerInfo["email"].ToString();
                    long cadastro = long.Parse(readerInfo["cadastro"].ToString());
                    long telefone = long.Parse(readerInfo["telefone"].ToString());

                    infoBasicasDB.Add(new InfoBasica()
                    {
                        nome = nome,
                        email = email,
                        cadastro = cadastro,
                        telefone = telefone
                    });
                }
                readerInfo.Close();

                FecharConexao();

                if (infoBasicasDB.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReturnAllSells(out List<Venda> vendasDB)
        {
            vendasDB = new List<Venda>();

            List<Venda>  tmpVendas = new List<Venda>();

            string queryVendas = "SELECT * FROM Venda;";

            if (AbrirConexao())
            {
                SqlCommand cmdVendas = new SqlCommand(queryVendas, connection);
                SqlDataReader readerVendas = cmdVendas.ExecuteReader();

                while (readerVendas.Read())
                {
                    int infoID = int.Parse(readerVendas["infoID"].ToString());
                    int carrinhoID = int.Parse(readerVendas["carrinhoID"].ToString());
                    int nota_fiscal = int.Parse(readerVendas["nota_fiscal"].ToString());

                    tmpVendas.Add(new Venda()
                    {
                        infoID = infoID,
                        carrinhoID = carrinhoID,
                        nota_fiscal = nota_fiscal
                    });
                }
                readerVendas.Close();

                Venda[] tmpVendasArray = tmpVendas.ToArray();

                foreach(Venda venda in tmpVendasArray)
                {
                    string queryCarrinho = "SELECT * FROM Carrinho WHERE carrinhoID = " + venda.carrinhoID + ";";
                    string queryCliente = "SELECT * FROM InfoBasica WHERE infoID = " + venda.infoID + ";";

                    float preco_total = 0;
                    string nome = string.Empty;

                    SqlCommand cmdCarrinho = new SqlCommand(queryCarrinho, connection);
                    SqlDataReader readerCarrinho = cmdCarrinho.ExecuteReader();

                    if (readerCarrinho.Read())
                    {
                        preco_total = float.Parse(readerCarrinho["preco_total"].ToString());
                    }
                    readerCarrinho.Close();

                    SqlCommand cmdCliente = new SqlCommand(queryCliente, connection);
                    SqlDataReader readerCliente = cmdCliente.ExecuteReader();

                    if (readerCliente.Read())
                    {
                        nome = readerCliente["nome"].ToString();
                    }
                    readerCliente.Close();

                    if (preco_total > 0 && nome != string.Empty)
                    {
                        vendasDB.Add(new Venda()
                        {
                            nome = nome,
                            preco_total = preco_total,
                            nota_fiscal = venda.nota_fiscal
                        });
                    }
                }
                FecharConexao();

                if (vendasDB.Count() > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ReturnProductsSacola(out List<Produto> produtosSacola, out float preco_total, out int carrinhoID, int infoID)
        {
            produtosSacola = new List<Produto>();
            preco_total = 0;
            carrinhoID = 0;

            string queryCarrinhoID = "SELECT * FROM Cliente WHERE infoID = @infoID;";

            if (LoadAllOffers(out List<Oferta> ofertasDB))
            {
                if (AbrirConexao())
                {
                    SqlCommand cmdCarrinhoID = new SqlCommand(queryCarrinhoID, connection);
                    cmdCarrinhoID.Parameters.AddWithValue("@infoID", infoID);
                    SqlDataReader readerCarrinhoID = cmdCarrinhoID.ExecuteReader();

                    if (readerCarrinhoID.Read())
                    {
                        carrinhoID = int.Parse(readerCarrinhoID["carrinhoID"].ToString());
                        readerCarrinhoID.Close();

                        if (carrinhoID > 0) // Se existir carrinho, retorna os produtos e qtdes da sacola
                        {
                            string queryTotal = "SELECT * FROM Carrinho WHERE carrinhoID = @carrinhoID;";
                            SqlCommand cmdTotal = new SqlCommand(queryTotal, connection);
                            cmdTotal.Parameters.AddWithValue("@carrinhoID", carrinhoID);
                            SqlDataReader readerTotal = cmdTotal.ExecuteReader();

                            if (readerTotal.Read())
                            {
                                preco_total = float.Parse(readerTotal["preco_total"].ToString());
                            }
                            readerTotal.Close();

                            string querySacolas = "SELECT * FROM Sacola WHERE carrinhoID = @carrinhoID;";
                            SqlCommand cmdSacolas = new SqlCommand(querySacolas, connection);
                            cmdSacolas.Parameters.AddWithValue("@carrinhoID", carrinhoID);
                            SqlDataReader readerSacolas = cmdSacolas.ExecuteReader();

                            List<Sacola> tmpSacola = new List<Sacola>();

                            while (readerSacolas.Read())
                            {
                                int productID = int.Parse(readerSacolas["productID"].ToString());
                                int qtde = int.Parse(readerSacolas["quantidade"].ToString());

                                if (qtde > 0)
                                {
                                    tmpSacola.Add(new Sacola()
                                    {
                                        productID = productID,
                                        quantidade = qtde
                                    });
                                }
                            }
                            readerSacolas.Close();

                            if (tmpSacola.Count() > 0)
                            {

                                Oferta[] ofertas = ofertasDB.ToArray();
                                Sacola[] sacolaArray = tmpSacola.ToArray();

                                foreach (Sacola sacola in sacolaArray)
                                {
                                    string queryProducts = "SELECT * FROM Produto WHERE productID = @productID;";
                                    SqlCommand cmdProducts = new SqlCommand(queryProducts, connection);
                                    cmdProducts.Parameters.AddWithValue("@productID", sacola.productID);
                                    SqlDataReader readerProducts = cmdProducts.ExecuteReader();

                                    if (readerProducts.Read())
                                    {
                                        string nome = readerProducts["nome"].ToString();
                                        float preco = float.Parse(readerProducts["preco"].ToString());
                                        int fornecedorID = int.Parse(readerProducts["fornecedorID"].ToString());
                                        int prateleira = int.Parse(readerProducts["prateleira"].ToString());
                                        DateTime validade = DateTime.Parse(readerProducts["validade"].ToString()).Date;

                                        foreach (Oferta oferta in ofertas)
                                        {
                                            if (oferta.productID == sacola.productID)
                                            {
                                                preco *= (1 - (oferta.desconto) / 100);
                                                break;
                                            }
                                        }

                                        produtosSacola.Add(new Produto()
                                        {
                                            productID = sacola.productID,
                                            nome = nome,
                                            fornecedorID = fornecedorID,
                                            preco = preco,
                                            validade = validade,
                                            prateleira = prateleira,
                                            quantidade = sacola.quantidade
                                        });
                                    }
                                    readerProducts.Close();
                                }

                            }
                        }
                    }

                    FecharConexao();

                    if (produtosSacola.Count() >= 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
