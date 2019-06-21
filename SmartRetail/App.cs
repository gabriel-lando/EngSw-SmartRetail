using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartRetail
{
    public partial class App : Form
    {
        private int infoID;
        public App()
        {
            InitializeComponent();
        }

        private void EmailTextBox_Click(object sender, EventArgs e)
        {
            EmailTextBox.SelectAll();
        }

        private void PwdTextBox_Click(object sender, EventArgs e)
        {
            PwdTextBox.SelectAll();
        }

        private void PwdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(this, new EventArgs());
            }
        }

        private void LimparBtn_Click(object sender, EventArgs e)
        {
            //EmailTextBox.Text = "Email";
            //PwdTextBox.Text = "Password";
            EmailTextBox.Text = "admin@admin.com";
            PwdTextBox.Text = "admin";
            ErrorLoginTextBox.Visible = false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData
            {
                email = EmailTextBox.Text,
                senha = PwdTextBox.Text
            };

            SQLConnect sql = new SQLConnect();
            int valida = sql.ValidarLogin(out int retID, login);

            if (valida > 0)
            {
                infoID = retID;
                LimparBtn_Click(null, null);
                TabCtrl.SelectedIndex = valida;
                GerCtrlCad_ComboBox.SelectedIndex = 0;

                if(valida == 1) //Carrega os produtos na tabela
                {
                    CarregaProdFornecedor();
                }
            }
            else
            {
                infoID = 0;
                ErrorLoginTextBox.Visible = true;
                ErrorLoginTextBox.Text = "Usuário ou senha incorretos!";
            }
        }

        private void CarregaProdFornecedor()
        {
            ClearTable();

            SQLConnect sql = new SQLConnect();

            if (sql.ReturnProductsFornecedor(out List<Produto> produtosDB, infoID))
            {
                Produto[] produtosArray = produtosDB.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    string[] tmpRow = new string[] { produto.productID.ToString(), produto.nome, String.Format("{0:F2}", produto.preco), produto.quantidade.ToString(), produto.prateleira.ToString(), produto.validade.ToString("dd/MM/yyyy")};
                    ForCtrlCad_ProdTable.Rows.Add(tmpRow);
                }
            }
        }
        private void ClearTable()
        {
            ForCtrlCad_ProdTable.Rows.Clear();
        }

        private void GerCtrlCad_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (GerCtrlCad_ComboBox.SelectedIndex)
            {
                case 1:
                    GerCtrlCad_Nome.Enabled = true;
                    GerCtrlCad_Cadastro.Enabled = true;
                    GerCtrlCad_Email.Enabled = true;
                    GerCtrlCad_Telefone.Enabled = true;
                    GerCtrlCad_Senha.Enabled = true;
                    GerCtrlCad_SenhaRep.Enabled = true;
                    GerCtrlCad_ProdTable.Visible = true;
                    GerCtrlCad_Label8.Visible = true;
                    GerCtrlCad_CadastrarBtn.Enabled = true;
                    GerCtrlCad_ClearBtn.Enabled = true;
                    break;
                case 2:
                    GerCtrlCad_Nome.Enabled = true;
                    GerCtrlCad_Cadastro.Enabled = true;
                    GerCtrlCad_Email.Enabled = true;
                    GerCtrlCad_Telefone.Enabled = true;
                    GerCtrlCad_Senha.Enabled = true;
                    GerCtrlCad_SenhaRep.Enabled = true;
                    GerCtrlCad_ProdTable.Visible = false;
                    GerCtrlCad_Label8.Visible = false;
                    GerCtrlCad_CadastrarBtn.Enabled = true;
                    GerCtrlCad_ClearBtn.Enabled = true;
                    break;
                default:
                    GerCtrlCad_Nome.Enabled = false;
                    GerCtrlCad_Cadastro.Enabled = false;
                    GerCtrlCad_Email.Enabled = false;
                    GerCtrlCad_Telefone.Enabled = false;
                    GerCtrlCad_Senha.Enabled = false;
                    GerCtrlCad_SenhaRep.Enabled = false;
                    GerCtrlCad_ProdTable.Visible = false;
                    GerCtrlCad_Label8.Visible = false;
                    GerCtrlCad_CadastrarBtn.Enabled = false;
                    GerCtrlCad_ClearBtn.Enabled = false;
                    break;
            }
        }

        private void GerCtrlCad_CadastrarBtn_Click(object sender, EventArgs e)
        {
            if (GerCtrlCad_Senha.Text != GerCtrlCad_SenhaRep.Text)
            {
                GerCtrlCad_ErrorTextBox.Visible = true;
                GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                GerCtrlCad_ErrorTextBox.Text = "Senhas não conferem!";
            }
            else if (GerCtrlCad_Nome.Text == "" || GerCtrlCad_Cadastro.Text == "" || GerCtrlCad_Email.Text == "" || GerCtrlCad_Telefone.Text == "" || GerCtrlCad_Senha.Text == "" || GerCtrlCad_SenhaRep.Text == "")
            {
                GerCtrlCad_ErrorTextBox.Visible = true;
                GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                GerCtrlCad_ErrorTextBox.Text = "Dados não preenchidos corretamente!";
            }
            else if (GerCtrlCad_ComboBox.SelectedIndex == 2)
            {
                Gerente gerente = new Gerente();
                gerente.info.email = GerCtrlCad_Email.Text;

                if (gerente.info.ValidaEmail())
                {
                    try
                    {
                        gerente.info.nome = GerCtrlCad_Nome.Text;
                        gerente.info.cadastro = long.Parse(GerCtrlCad_Cadastro.Text);
                        gerente.info.telefone = long.Parse(GerCtrlCad_Telefone.Text);
                        gerente.info.funcao = GerCtrlCad_ComboBox.SelectedIndex;
                        gerente.senha = GerCtrlCad_Senha.Text;
                    }
                    catch
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        GerCtrlCad_ErrorTextBox.Text = "Tipos de dados inconsistentes!";
                        return;
                    }

                    SQLConnect sql = new SQLConnect();
                    bool insere = sql.InserirGerente(gerente);

                    if (insere)
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
                        GerCtrlCad_ErrorTextBox.Text = "Dados inseridos com sucesso!";
                    }
                    else
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        GerCtrlCad_ErrorTextBox.Text = "Erro ao realizar o cadastro!";
                    }
                }
                else
                {
                    GerCtrlCad_ErrorTextBox.Visible = true;
                    GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    GerCtrlCad_ErrorTextBox.Text = "Email inválido!";
                }
                
            }
            else if (GerCtrlCad_ComboBox.SelectedIndex == 1)
            {
                Fornecedor fornecedor = new Fornecedor();
                fornecedor.info.email = GerCtrlCad_Email.Text;

                if (fornecedor.info.ValidaEmail())
                {
                    try
                    {
                        fornecedor.info.nome = GerCtrlCad_Nome.Text;
                        fornecedor.info.cadastro = long.Parse(GerCtrlCad_Cadastro.Text);
                        fornecedor.info.telefone = long.Parse(GerCtrlCad_Telefone.Text);
                        fornecedor.info.funcao = GerCtrlCad_ComboBox.SelectedIndex;
                        fornecedor.senha = GerCtrlCad_Senha.Text;
                    }
                    catch
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        GerCtrlCad_ErrorTextBox.Text = "Tipos de dados inconsistentes!";
                        return;
                    }

                    List<Produto> list = new List<Produto>();

                    foreach (DataGridViewRow Datarow in GerCtrlCad_ProdTable.Rows)
                    {
                        if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null && Datarow.Cells[4].Value != null)
                        {
                            try
                            {
                                string nomeGrid = Datarow.Cells[0].Value.ToString();
                                float precoGrid = float.Parse(Datarow.Cells[1].Value.ToString());
                                int qtdeGrid = int.Parse(Datarow.Cells[2].Value.ToString());
                                int prateleiraGrid = int.Parse(Datarow.Cells[3].Value.ToString());
                                DateTime validadeGrid = DateTime.Parse(Datarow.Cells[4].Value.ToString());

                                list.Add(new Produto()
                                {
                                    nome = nomeGrid,
                                    preco = precoGrid,
                                    prateleira = prateleiraGrid,
                                    validade = validadeGrid,
                                    quantidade = qtdeGrid
                                });
                            }
                            catch
                            {
                                GerCtrlCad_ErrorTextBox.Visible = true;
                                GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                                GerCtrlCad_ErrorTextBox.Text = "Verificar produtos!";
                                return;
                            }
                        }
                    }
                    if (list != null)
                    {
                        Produto[] produtos = list.ToArray();

                        SQLConnect sql = new SQLConnect();
                        bool insere = sql.InserirFornecedor(fornecedor, produtos);

                        if (insere)
                        {
                            GerCtrlCad_ErrorTextBox.Visible = true;
                            GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
                            GerCtrlCad_ErrorTextBox.Text = "Dados inseridos com sucesso!";
                        }
                        else
                        {
                            GerCtrlCad_ErrorTextBox.Visible = true;
                            GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                            GerCtrlCad_ErrorTextBox.Text = "Erro ao realizar o cadastro!";
                        }
                    }
                }
            }
        }

        private void GerCtrlCad_ClearBtn_Click(object sender, EventArgs e)
        {
            GerCtrlCad_ComboBox.SelectedIndex = 0;
            GerCtrlCad_ErrorTextBox.Visible = false;
            GerCtrlCad_Nome.Text = "";
            GerCtrlCad_Cadastro.Text = "";
            GerCtrlCad_Email.Text = "";
            GerCtrlCad_Telefone.Text = "";
            GerCtrlCad_Senha.Text = "";
            GerCtrlCad_SenhaRep.Text = "";
            GerCtrlCad_ProdTable.Rows.Clear();
            GerCtrlCad_ProdTable.Refresh();
        }

        private void GerCtrlRem_ClearBtn_Click(object sender, EventArgs e)
        {
            GerCtrlCad_ComboBox.SelectedIndex = -1;
            GerCtrlRem_ErrorTextBox.Visible = false;
            GerCtrlRem_EmailRep.Text = "";
            GerCtrlRem_Email.Text = "";
        }

        private void GerCtrlRem_RemoverBtn_Click(object sender, EventArgs e)
        {
            if (GerCtrlRem_EmailRep.Text != GerCtrlRem_Email.Text || GerCtrlRem_EmailRep.Text == "")
            {
                GerCtrlRem_ErrorTextBox.Visible = true;
                GerCtrlRem_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                GerCtrlRem_ErrorTextBox.Text = "Emails preenchidos incorretamente!";
            }
            else
            {
                SQLConnect sql = new SQLConnect();
                if (sql.RemoverUsuario(GerCtrlRem_Email.Text.ToString(), GerCtrlRem_ComboBox.SelectedIndex))
                {
                    GerCtrlRem_ErrorTextBox.Visible = true;
                    GerCtrlRem_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
                    GerCtrlRem_ErrorTextBox.Text = "Cadastro removido com sucesso!";
                }
                else
                {
                    GerCtrlRem_ErrorTextBox.Visible = true;
                    GerCtrlRem_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    GerCtrlRem_ErrorTextBox.Text = "Erro ao remover cadastro!";
                }
            }
        }

        private void LogoffGerBtn_Click(object sender, EventArgs e)
        {
            GerCtrlCad_ClearBtn_Click(null, null);
            GerCtrlRem_ClearBtn_Click(null, null);
            TabCtrl.SelectedIndex = 0;
        }

        private void LogoffForBtn_Click(object sender, EventArgs e)
        {
            //GerCtrlCad_ClearBtn_Click(null, null);
            //GerCtrlRem_ClearBtn_Click(null, null);
            ClearTable();
            TabCtrl.SelectedIndex = 0;
        }

        private void ForCtrlCad_CancelBtn_Click(object sender, EventArgs e)
        {
            CarregaProdFornecedor();
        }

        private void ForCtrlCad_CadastrarBtn_Click(object sender, EventArgs e)
        {
            List<Produto> listUpdate = new List<Produto>();
            List<Produto> listInsert = new List<Produto>();
            List<Produto> listRemove = new List<Produto>();

            foreach (DataGridViewRow Datarow in ForCtrlCad_ProdTable.Rows)
            {
                if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null && Datarow.Cells[4].Value != null && Datarow.Cells[5].Value != null) // Atualiza produto existente
                {
                    try
                    {
                        int prodIDGrid = int.Parse(Datarow.Cells[0].Value.ToString());
                        string nomeGrid = Datarow.Cells[1].Value.ToString();
                        float precoGrid = float.Parse(Datarow.Cells[2].Value.ToString());
                        int qtdeGrid = int.Parse(Datarow.Cells[3].Value.ToString());
                        int prateleiraGrid = int.Parse(Datarow.Cells[4].Value.ToString());
                        DateTime validadeGrid = DateTime.Parse(Datarow.Cells[5].Value.ToString());

                        listUpdate.Add(new Produto()
                        {
                            productID = prodIDGrid,
                            nome = nomeGrid,
                            preco = precoGrid,
                            prateleira = prateleiraGrid,
                            validade = validadeGrid,
                            quantidade = qtdeGrid
                        });
                    }
                    catch
                    {
                        ForCtrlCad_ErrorTextBox.Visible = true;
                        ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        ForCtrlCad_ErrorTextBox.Text = "Verificar produtos!";
                        return;
                    }
                }
                else if (Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null && Datarow.Cells[4].Value != null && Datarow.Cells[5].Value != null) // Add novo produto
                {
                    try
                    {
                        string nomeGrid = Datarow.Cells[1].Value.ToString();
                        float precoGrid = float.Parse(Datarow.Cells[2].Value.ToString());
                        int qtdeGrid = int.Parse(Datarow.Cells[3].Value.ToString());
                        int prateleiraGrid = int.Parse(Datarow.Cells[4].Value.ToString());
                        DateTime validadeGrid = DateTime.Parse(Datarow.Cells[5].Value.ToString());

                        listInsert.Add(new Produto()
                        {
                            nome = nomeGrid,
                            preco = precoGrid,
                            prateleira = prateleiraGrid,
                            validade = validadeGrid,
                            quantidade = qtdeGrid,
                            fornecedorID = infoID
                        });
                    }
                    catch
                    {
                        ForCtrlCad_ErrorTextBox.Visible = true;
                        ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        ForCtrlCad_ErrorTextBox.Text = "Verificar produtos!";
                        return;
                    }
                }
                else if (Datarow.Cells[0].Value != null) // Remove produto existente
                {
                    try
                    {
                        int prodIDGrid = int.Parse(Datarow.Cells[0].Value.ToString());

                        listRemove.Add(new Produto()
                        {
                            productID = prodIDGrid
                        });
                    }
                    catch
                    {
                        ForCtrlCad_ErrorTextBox.Visible = true;
                        ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        ForCtrlCad_ErrorTextBox.Text = "Verificar produtos!";
                        return;
                    }
                }
            }

            SQLConnect sql = new SQLConnect();

            if (listUpdate.Count() > 0) // Atualiza
            {
                if (!sql.UpdateProductsFornecedor(listUpdate))
                {
                    ForCtrlCad_ErrorTextBox.Visible = true;
                    ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    ForCtrlCad_ErrorTextBox.Text = "Erro ao atualizar produtos!";

                    return;
                }
            }

            if (listInsert.Count() > 0) // Insere
            {
                if (!sql.InsertProductsFornecedor(listInsert))
                {
                    ForCtrlCad_ErrorTextBox.Visible = true;
                    ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    ForCtrlCad_ErrorTextBox.Text = "Erro ao inserir produtos!";

                    return;
                }
            }

            if (listRemove.Count() > 0) // Remove
            {
                if (!sql.RemoveProductsFornecedor(listRemove))
                {
                    ForCtrlCad_ErrorTextBox.Visible = true;
                    ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    ForCtrlCad_ErrorTextBox.Text = "Erro ao remover produtos!";

                    return;
                }
            }

            ForCtrlCad_ErrorTextBox.Visible = true;
            ForCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
            ForCtrlCad_ErrorTextBox.Text = "Dados inseridos com sucesso!";
        }

        private void CarregaProdutos()
        {
            ClearTables();

            SQLConnect sql = new SQLConnect();
            if (sql.LoadAllProducts(out List<Produto> produtosDB))
            {
                Produto[] produtosArray = produtosDB.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    string[] tmpRow = new string[] { produto.nome, String.Format("{0:F2}", produto.preco), produto.quantidade.ToString(), produto.prateleira.ToString(), produto.fornecedorID.ToString(), produto.validade.ToString("dd/MM/yyyy") };
                    GerCtrlProd_ProdTable.Rows.Add(tmpRow);
                }
            }
        }

        private void CarregaOfertas()
        {
            ClearTables();

            SQLConnect sql = new SQLConnect();
            if (sql.LoadAllProducts(out List<Produto> produtosDB))
            {
                if (sql.LoadAllOffers(out List<Oferta> ofertasDB))
                {
                    Produto[] produtosArray = produtosDB.ToArray();
                    Oferta[] ofertasArray = ofertasDB.ToArray();

                    foreach (Oferta oferta in ofertasArray)
                    {
                        string[] tmpRow = new string[] { oferta.productID.ToString(), oferta.nome, String.Format("{0:F1}", oferta.desconto), oferta.duracao.ToString("dd/MM/yyyy") };
                        GerCtrlOfer_OferTable.Rows.Add(tmpRow);
                    }

                    foreach (Produto produto in produtosArray)
                    {
                        bool add = true;

                        foreach (Oferta oferta in ofertasArray)
                        {
                            if (oferta.productID == produto.productID)
                            {
                                add = false;
                                break;
                            }
                        }
                        if (add)
                        {
                            string[] tmpRow = new string[] { produto.productID.ToString(), produto.nome };
                            GerCtrlOfer_OferTable.Rows.Add(tmpRow);
                        }
                    }
                }
            }
        }

        private void CadastraOfertas()
        {
            List<Oferta> list = new List<Oferta>();

            foreach (DataGridViewRow Datarow in GerCtrlOfer_OferTable.Rows)
            {
                if (Datarow.Cells[2].Value != null && Datarow.Cells[3].Value != null)
                {
                    try
                    {
                        int productIDGrid = int.Parse(Datarow.Cells[0].Value.ToString());
                        string nomeGrid = Datarow.Cells[1].Value.ToString();
                        float descontoGrid = float.Parse(Datarow.Cells[2].Value.ToString());
                        DateTime duracaoGrid = DateTime.Parse(Datarow.Cells[3].Value.ToString());

                        if (!(descontoGrid > 0 && descontoGrid <= 100))
                        {
                            throw new Exception();
                        }

                        list.Add(new Oferta()
                        {
                            productID = productIDGrid,
                            nome = nomeGrid,
                            desconto = descontoGrid,
                            duracao = duracaoGrid
                        });
                    }
                    catch
                    {
                        GerCtrlOfer_ErrorTextBox.Visible = true;
                        GerCtrlOfer_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        GerCtrlOfer_ErrorTextBox.Text = "Verificar dados inseridos!";
                        return;
                    }
                }
            }

            SQLConnect sql = new SQLConnect();

            if (sql.SaveOffers(list))
            {
                GerCtrlOfer_ErrorTextBox.Visible = true;
                GerCtrlOfer_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
                GerCtrlOfer_ErrorTextBox.Text = "Ofertas atualizadas com sucesso!";

                return;
            }
            GerCtrlOfer_ErrorTextBox.Visible = true;
            GerCtrlOfer_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
            GerCtrlOfer_ErrorTextBox.Text = "Erro ao atualizar ofertas!";
        }

        private void CarregaConsulta()
        {
            ClearTables();
            GerCtrlCons_ComboBox.SelectedIndex = 0;
            GerCtrlCons_ConsTable.Visible = false;
        }

        private void ClearTables()
        {
            GerCtrlCons_ConsTable.Rows.Clear();
            GerCtrlCons_ConsTable.Columns.Clear();

            GerCtrlProd_ProdTable.Rows.Clear();
            GerCtrlOfer_OferTable.Rows.Clear();
            GerCtrlOfer_ErrorTextBox.Visible = false;
        }

        private void GerenteCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GerenteCtrl.SelectedTab.Text == "Produtos")
            {
                CarregaProdutos();
            }
            else if (GerenteCtrl.SelectedTab.Text == "Ofertas")
            {
                CarregaOfertas();
            }
            else if (GerenteCtrl.SelectedTab.Text == "Consultar")
            {
                CarregaConsulta();
            }
        }

        private void GerCtrlOfer_CancelBtn_Click(object sender, EventArgs e)
        {
            CarregaOfertas();
        }

        private void GerCtrlOfer_CadastrarBtn_Click(object sender, EventArgs e)
        {
            CadastraOfertas();
        }

        private void GerCtrlCons_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLConnect sql = new SQLConnect();
            ClearTables();

            switch (GerCtrlCons_ComboBox.SelectedItem.ToString())
            {
                case "Clientes":
                    if (sql.ReturnAllClients(out List<Cliente> clientesDB, out List<InfoBasica> infoBasicasDB))
                    {
                        Cliente[] clientesSort = clientesDB.OrderBy(o => o.infoID).ToArray();
                        InfoBasica[] infoSort = infoBasicasDB.OrderBy(o => o.infoID).ToArray();
                        GerCtrlCons_ConsTable.Columns.Add("Column1", "Nome");
                        GerCtrlCons_ConsTable.Columns.Add("Column2", "CPF");
                        GerCtrlCons_ConsTable.Columns.Add("Column3", "Email");
                        GerCtrlCons_ConsTable.Columns.Add("Column4", "Telefone");
                        GerCtrlCons_ConsTable.Columns.Add("Column5", "Endereço");
                        GerCtrlCons_ConsTable.Visible = true;

                        foreach (InfoBasica info in infoSort)
                        {
                            foreach (Cliente cliente in clientesSort)
                            {
                                if(info.infoID == cliente.infoID)
                                {
                                    string[] tmpRow = new string[] { info.nome, info.cadastro.ToString(), info.email, info.telefone.ToString(), cliente.endereco_cobranca };
                                    GerCtrlCons_ConsTable.Rows.Add(tmpRow);
                                    break;
                                }
                            } 
                        }
                    }
                    break;
                case "Fornecedores":
                    if (sql.ReturnAllFornGer(out List<InfoBasica> infoForsDB, 1))
                    {
                        InfoBasica[] infoSort = infoForsDB.OrderBy(o => o.infoID).ToArray();
                        GerCtrlCons_ConsTable.Columns.Add("Column1", "Nome");
                        GerCtrlCons_ConsTable.Columns.Add("Column2", "CNPJ");
                        GerCtrlCons_ConsTable.Columns.Add("Column3", "Email");
                        GerCtrlCons_ConsTable.Columns.Add("Column4", "Telefone");
                        GerCtrlCons_ConsTable.Visible = true;

                        foreach (InfoBasica info in infoSort)
                        {
                            string[] tmpRow = new string[] { info.nome, info.cadastro.ToString(), info.email, info.telefone.ToString() };
                            GerCtrlCons_ConsTable.Rows.Add(tmpRow);
                        }
                    }
                    break;
                case "Gerentes":
                    if (sql.ReturnAllFornGer(out List<InfoBasica> infoGerDB, 2))
                    {
                        InfoBasica[] infoSort = infoGerDB.OrderBy(o => o.infoID).ToArray();
                        GerCtrlCons_ConsTable.Columns.Add("Column1", "Nome");
                        GerCtrlCons_ConsTable.Columns.Add("Column2", "CPF");
                        GerCtrlCons_ConsTable.Columns.Add("Column3", "Email");
                        GerCtrlCons_ConsTable.Columns.Add("Column4", "Telefone");
                        GerCtrlCons_ConsTable.Visible = true;

                        foreach (InfoBasica info in infoSort)
                        {
                            string[] tmpRow = new string[] { info.nome, info.cadastro.ToString(), info.email, info.telefone.ToString() };
                            GerCtrlCons_ConsTable.Rows.Add(tmpRow);
                        }
                    }
                    break;
                case "Vendas":
                    if (sql.ReturnAllSells(out List<Venda> vendasDB))
                    {
                        Venda[] vendasSort = vendasDB.OrderBy(o => o.nota_fiscal).ToArray();
                        GerCtrlCons_ConsTable.Columns.Add("Column1", "Cliente");
                        GerCtrlCons_ConsTable.Columns.Add("Column2", "Valor");
                        GerCtrlCons_ConsTable.Columns.Add("Column3", "Nota Fiscal");
                        GerCtrlCons_ConsTable.Visible = true;

                        foreach (Venda venda in vendasSort)
                        {
                            string[] tmpRow = new string[] { venda.nome, string.Format("{0:F2}", venda.preco_total), venda.nota_fiscal.ToString() };
                            GerCtrlCons_ConsTable.Rows.Add(tmpRow);
                        }
                    }
                    break;
                default:
                    ClearTables();
                    GerCtrlCons_ConsTable.Visible = false;
                    break;

            }
        }
    }
}
