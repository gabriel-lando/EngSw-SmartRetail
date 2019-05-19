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
            EmailTextBox.Text = "Email";
            PwdTextBox.Text = "Password";
            ErrorLoginTextBox.Visible = false;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LoginData login = new LoginData();
            login.email = EmailTextBox.Text;
            login.senha = PwdTextBox.Text;

            SQLConnect sql = new SQLConnect();
            int valida = sql.ValidarLogin(login);

            if (valida > 0)
            {
                TabCtrl.SelectedIndex = valida;
                GerCtrlCad_ComboBox.SelectedIndex = 0;
                //LoginPanelDock.Visible = false;
            }
            else
            {
                ErrorLoginTextBox.Visible = true;
                ErrorLoginTextBox.Text = "Usuário ou senha incorretos!";
            }
            //this.LoginPanelDock.Visible = false;
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
                if (gerente.info.ValidaEmail(gerente.info.email))
                {
                    gerente.info.nome = GerCtrlCad_Nome.Text;
                    gerente.info.cadastro = long.Parse(GerCtrlCad_Cadastro.Text);
                    gerente.info.email = GerCtrlCad_Email.Text;
                    gerente.info.telefone = long.Parse(GerCtrlCad_Telefone.Text);
                    gerente.info.funcao = GerCtrlCad_ComboBox.SelectedIndex;
                    gerente.senha = GerCtrlCad_Senha.Text;

                    SQLConnect sql = new SQLConnect();
                    bool insere = sql.InserirGerente(gerente);

                    if (insere)
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Green;
                        GerCtrlCad_ErrorTextBox.Text = "Dados inseridos com sicesso!";
                    }
                    else
                    {
                        GerCtrlCad_ErrorTextBox.Visible = true;
                        GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                        GerCtrlCad_ErrorTextBox.Text = "Erro ao armazenar os dados!";
                    }
                }
                else
                {
                    GerCtrlCad_ErrorTextBox.Visible = true;
                    GerCtrlCad_ErrorTextBox.ForeColor = System.Drawing.Color.Red;
                    GerCtrlCad_ErrorTextBox.Text = "Email inválido!";
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
        }
    }
}
