using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SmartRetail
{
    public partial class Caixa : Form
    {
        private int infoID = 0;

        private FacialRecognition facialRec = new FacialRecognition();
        public Caixa()
        {
            InitializeComponent();
        }
        private void Caixa_DragEnter(object sender, DragEventArgs e)
        {
            facialRec.OnDragEnter(sender, e);
        }
        private void Caixa_DragDrop(object sender, DragEventArgs e)
        {
            Image image = facialRec.OnDragDrop(sender, e);

            if (image != null)
            {
                SQLConnect sql = new SQLConnect();
                int valida = sql.ValidaCliente(facialRec.RetFilename());

                if (valida == -1) // Cadastra cliente
                {
                    CadastroTab(image);
                }
                else if (valida == 0)
                {
                    EntradaTab(image);
                }
                else if (valida > 0)
                {
                    infoID = valida;
                    SaidaTab(image);
                }

                //ClientInfoTextSaida.Text = facialRec.RetFilename();
            }
        }

        private void Wait(int time)
        {
            System.Threading.Thread thread = new System.Threading.Thread(delegate ()
            {
                System.Threading.Thread.Sleep(time);
            });
            thread.Start();
            while (thread.IsAlive)
                Application.DoEvents();
        }

        private void IdleTab()
        {
            TabCtrl.SelectedIndex = 0;
        }
        private void CadastroTab(Image image)
        {
            CadastroLimparBtn_Click(null, null);

            TabCtrl.SelectedIndex = 1;
            FacialRecPictureBoxCadastro.Image = image;

        }
        private void EntradaTab(Image image)
        {
            TabCtrl.SelectedIndex = 2;
            FacialRecPictureBoxEntrada.Image = image;

            Wait(3000); // Delay para leitura da tela antes de voltar pra Idle
            IdleTab();

        }
        private void SaidaTab(Image image)
        {
            TabCtrl.SelectedIndex = 3;
            FacialRecPictureBoxSaida.Image = image;

            SQLConnect sql = new SQLConnect();

            if (sql.ReturnProductsSacola(out List<Produto> produtosSacola, out float preco_total, infoID))
            {
                Produto[] produtosArray = produtosSacola.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    //ClienteCarrinhoTable
                }

                ClienteCarrinhoTotalValue.Text = String.Format("{0:F2}", preco_total);
            }

            Wait(5000); // Delay para leitura da tela antes de voltar pra Idle
            IdleTab();
        }

        private void CadastroLimparBtn_Click(object sender, EventArgs e)
        {
            ErrorCadastroTextBox.Visible = false;
            CadastroNomeText.Text = "";
            CadastroCPFText.Text = "";
            CadastroEmailText.Text = "";
            CadastroTelefoneText.Text = "";
            CadastroEnderecoText.Text = "";
            CadastroCartaoText.Text = "";
        }

        private void CadastroSubmitBtn_Click(object sender, EventArgs e)
        {

            if (CadastroNomeText.Text == "" || CadastroCPFText.Text == "" || CadastroEmailText.Text == "" || CadastroTelefoneText.Text == "" || CadastroEnderecoText.Text == "" || CadastroCartaoText.Text == "")
            {
                ErrorCadastroTextBox.Visible = true;
                ErrorCadastroTextBox.ForeColor = System.Drawing.Color.Red;
                ErrorCadastroTextBox.Text = "Verifique os dados inseridos!";
            }

            Cliente cliente = new Cliente();
            cliente.info.email = CadastroEmailText.Text;

            if (cliente.info.ValidaEmail())
            {
                try
                {
                    cliente.info.nome = CadastroNomeText.Text;
                    cliente.info.cadastro = long.Parse(CadastroCPFText.Text);
                    cliente.info.telefone = long.Parse(CadastroTelefoneText.Text);
                    cliente.info.funcao = 0;
                    cliente.endereco_cobranca = CadastroEnderecoText.Text;
                    cliente.nro_carta_de_credito = long.Parse(CadastroCartaoText.Text);
                    cliente.facial_data = facialRec.RetFilename();
                }
                catch
                {
                    ErrorCadastroTextBox.Visible = true;
                    ErrorCadastroTextBox.ForeColor = System.Drawing.Color.Red;
                    ErrorCadastroTextBox.Text = "Verifique os dados inseridos!";
                    return;
                }

                SQLConnect sql = new SQLConnect();
                bool insere = sql.InserirCliente(cliente);

                if (insere)
                {
                    ErrorCadastroTextBox.Visible = true;
                    ErrorCadastroTextBox.ForeColor = System.Drawing.Color.Green;
                    ErrorCadastroTextBox.Text = "Cadastro realizado com sucesso, entrada permitida!";

                    Wait(4000); // Delay para leitura da tela antes de voltar pra Idle
                    IdleTab();
                }
                else
                {
                    ErrorCadastroTextBox.Visible = true;
                    ErrorCadastroTextBox.ForeColor = System.Drawing.Color.Red;
                    ErrorCadastroTextBox.Text = "Erro ao realizar o cadastro!";
                }
            }
            else
            {
                ErrorCadastroTextBox.Visible = true;
                ErrorCadastroTextBox.ForeColor = System.Drawing.Color.Red;
                ErrorCadastroTextBox.Text = "Email inválido!";
            }
        }

        private void CadastroCancelarBtn_Click(object sender, EventArgs e)
        {
            IdleTab();
        }

        
    }
}
