using System;
using System.Collections;
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
    public partial class Prateleira : Form
    {
        private List<Produto> produtos;
        private int infoID = 0;

        private FacialRecognition facialRec = new FacialRecognition();
        public Prateleira()
        {
            InitializeComponent();
        }
        private void Prateleira_DragEnter(object sender, DragEventArgs e)
        {
            facialRec.OnDragEnter(sender, e);
        }
        private void Prateleira_DragDrop(object sender, DragEventArgs e)
        {
            Image image = facialRec.OnDragDrop(sender, e);

            if (image != null)
            {
                SQLConnect sql = new SQLConnect();
                int cliente = sql.DetectaCliente(facialRec.RetFilename());

                if (cliente > 0)
                {
                    infoID = cliente;
                    PrateleiraTab(image);
                }
                else
                {
                    IdleTab();
                }

                //ClientInfoTextSaida.Text = facialRec.RetFilename();
            }
        }

        private void IdleTab()
        {
            TabCtrl.SelectedIndex = 0;
        }
        private void PrateleiraTab(Image image)
        {
            TabCtrl.SelectedIndex = 1;
            FacialRecPictureBoxPrateleira.Image = image;

            ClearDetailsTextBox();
            ClearComboBox();

            if (CarregaPrateleiras())
            {
                PrateleiraComboBox.Enabled = true;
            }
        }

        private void ClearComboBox()
        {
            PrateleiraComboBox.Enabled = false;
            ProdutoComboBox.Enabled = false;
            QtdeComboBox.Enabled = false;
            PrateleiraComboBox.Items.Clear();
            ProdutoComboBox.Items.Clear();
            QtdeComboBox.Items.Clear();
            PrateleiraComboBox.Items.Add("(Selecione)");
            ProdutoComboBox.Items.Add("(Selecione)");
            QtdeComboBox.Items.Add("(Selecione)");
            PrateleiraComboBox.SelectedIndex = 0;
            ProdutoComboBox.SelectedIndex = 0;
            QtdeComboBox.SelectedIndex = 0;

            DetailsTextBox.Text = "";
            ResultTextBox.Visible = false;
        }

        private void ClearDetailsTextBox()
        {
            DetailsTextBox.Text = "";
            ResultTextBox.Visible = false;
        }

        private bool CarregaPrateleiras()
        {
            SQLConnect sql = new SQLConnect();

            if (sql.LoadAllProducts(out List<Produto> produtosDB))
            {
                PrateleiraComboBox.Items.Clear();
                
                List<Produto> produtoSort = produtosDB.OrderBy(o => o.prateleira).ToList();
                produtos = produtoSort;

                Produto[] produtosArray = produtoSort.ToArray();

                int prev = -1;
                foreach(Produto produto in produtosArray)
                {
                    if (prev != produto.prateleira)
                    {
                        PrateleiraComboBox.Items.Add(produto.prateleira.ToString());
                        prev = produto.prateleira;
                    }
                }
                return true;
            }
            else
            {
                ClearComboBox();
            }
            return false;
        }

        //private void AtualizarProdutos()
        //{
        //    SQLConnect sql = new SQLConnect();

        //    if (sql.LoadAllProducts(out List<Produto> produtosDB))
        //    {
        //        List<Produto> produtoSort = produtosDB.OrderBy(o => o.prateleira).ToList();
        //        produtos = produtoSort;
        //    }
        //}

        private void CarregaProdutos(int prateleira)
        {
            ProdutoComboBox.Items.Clear();
            Produto[] produtosArray = produtos.ToArray();

            foreach (Produto produto in produtosArray)
            {
                if (prateleira == produto.prateleira)
                {
                    ProdutoComboBox.Items.Add(produto.nome);
                }
            }
            ProdutoComboBox.Enabled = true;
            QtdeComboBox.Enabled = false;
            ProdutoComboBox.SelectedIndex = 0;
        }

        private void CarregaQtde(string productName)
        {
            QtdeComboBox.Items.Clear();
            Produto[] produtosArray = produtos.ToArray();

            foreach (Produto produto in produtosArray)
            {
                if (productName == produto.nome)
                {
                    for (int i = 1; i <= produto.quantidade; i++)
                    {
                        QtdeComboBox.Items.Add(i.ToString());
                    }
                    QtdeComboBox.Enabled = true;
                    QtdeComboBox.SelectedIndex = 0;
                }
            }
        }

        private void PrateleiraComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PrateleiraComboBox.Enabled)
            {
                CarregaProdutos(int.Parse(PrateleiraComboBox.SelectedItem.ToString()));
            }
        }

        private void ProdutoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProdutoComboBox.Enabled)
            {
                CarregaQtde(ProdutoComboBox.SelectedItem.ToString());
            }
        }
        private void QtdeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QtdeComboBox.Enabled)
            {
                Produto[] produtosArray = produtos.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    if (ProdutoComboBox.SelectedItem.ToString() == produto.nome)
                    {
                        int qtde = int.Parse(QtdeComboBox.SelectedItem.ToString());
                        DetailsTextBox.Text = String.Format("Produto:\t{0} \n\nValidade:\t{1:dd/MM/yyyy} \n\nValor un:\tR$ {2:F2} \n\nTotal:\t\tR$ {3:F2}", produto.nome, produto.validade, produto.preco, produto.preco * qtde);
                    }
                }
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            ClearComboBox();
            ClearDetailsTextBox();
            IdleTab();
        }
        private void AddBtn_Click(object sender, EventArgs e) // TODO: Adicionar itens no carrinho da pessoa
        {
            if (PrateleiraComboBox.Enabled && ProdutoComboBox.Enabled && QtdeComboBox.Enabled) // Enviar infoID do cliente, productID e quantidade
            {
                Produto[] produtosArray = produtos.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    if (ProdutoComboBox.SelectedItem.ToString() == produto.nome)
                    {
                        SQLConnect sql = new SQLConnect();
                        int qtde = int.Parse(QtdeComboBox.SelectedItem.ToString());

                        if (sql.AddProdutoCarrinho(infoID, produto, qtde))
                        {
                            ResultTextBox.Visible = true;
                            ResultTextBox.ForeColor = System.Drawing.Color.Green;
                            ResultTextBox.Text = "Produto adicionado!";

                            CarregaPrateleiras();
                        }
                        else
                        {
                            ResultTextBox.Visible = true;
                            ResultTextBox.ForeColor = System.Drawing.Color.Red;
                            ResultTextBox.Text = "Erro ao adicionar!";
                        }
                    }
                }
            }
        }
    }
}
