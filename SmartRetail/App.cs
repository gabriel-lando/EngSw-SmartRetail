using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            }
            else
            {
                infoID = 0;
                ErrorLoginTextBox.Visible = true;
                ErrorLoginTextBox.Text = "Usuário ou senha incorretos!";
            }
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
                        if (Datarow.Cells[0].Value != null && Datarow.Cells[1].Value != null && Datarow.Cells[2].Value != null)
                        {
                            string nomeGrid = Datarow.Cells[0].Value.ToString();
                            float precoGrid = float.Parse(Datarow.Cells[1].Value.ToString());
                            int qtdeGrid = int.Parse(Datarow.Cells[2].Value.ToString());
                            list.Add(new Produto() { nome = nomeGrid, preco = precoGrid, quantidade = qtdeGrid });
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
            TabCtrl.SelectedIndex = 0;
        }
    }
}
