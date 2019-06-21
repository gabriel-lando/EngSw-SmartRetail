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
    public partial class Totem : Form
    {
        private int infoID = 0;

        private FacialRecognition facialRec = new FacialRecognition();

        public Totem()
        {
            InitializeComponent();
        }
        private void Totem_DragEnter(object sender, DragEventArgs e)
        {
            facialRec.OnDragEnter(sender, e);
        }

        private void Totem_DragDrop(object sender, DragEventArgs e)
        {
            Image image = facialRec.OnDragDrop(sender, e);

            if (image != null)
            {
                SQLConnect sql = new SQLConnect();
                int cliente = sql.DetectaCliente(facialRec.RetFilename());

                if (cliente > 0)
                {
                    infoID = cliente;
                    TotemTab(image);
                }
                else
                {
                    IdleTab();
                }
            }
        }

        private void IdleTab()
        {
            TabCtrl.SelectedIndex = 0;
        }
        private void TotemTab(Image image)
        {
            TabCtrl.SelectedIndex = 1;
            FacialRecPictureBox.Image = image;

            ClearTable();
            ClearOffersBox();

            CarregarCarrinho();
            CarregarOfertas();

        }

        private void CarregarCarrinho()
        {
            SQLConnect sql = new SQLConnect();

            if (sql.ReturnProductsSacola(out List<Produto> produtosSacola, out float preco_total, out int carrinhoID, infoID))
            {
                Produto[] produtosArray = produtosSacola.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    string[] tmpRow = new string[] { produto.nome, String.Format("{0:F2}", produto.preco), produto.quantidade.ToString(), String.Format("{0:F2}", produto.preco * produto.quantidade) };
                    ClienteCarrinhoTable.Rows.Add(tmpRow);
                }

                ClienteCarrinhoTotalValue.Text = String.Format("{0:F2}", preco_total);
            }
        }
        private void CarregarOfertas()
        {
            SQLConnect sql = new SQLConnect();

            if (sql.LoadSpecialOffers(out List<Oferta> ofertasDB))
            {
                Oferta[] ofertas = ofertasDB.ToArray();
                List<int> produtosID = new List<int>();

                if(ofertasDB.Count() == 0)
                {
                    //string sem_oferta = String.Format("\n\n\n Nenhuma oferta disponível no momento!");
                    ClienteOfertaTextBox1.Text = "";
                    ClienteOfertaTextBox2.Text = "";
                    return;
                }
                
                foreach (Oferta oferta in ofertas)
                {
                    produtosID.Add(oferta.productID);
                }

                if(sql.LoadSomeProducts(out List<Produto> produtosDB, produtosID))
                {
                    Produto[] produto = produtosDB.ToArray();
                    switch (ofertasDB.Count())
                    {
                        case 1:
                            string oferta = string.Format("Produto:\t\t{0} \n\nValidade:\t\t{1:dd/MM/yyyy} \nPrateleira:\t\t{2} \nEstoque:\t\t{3}\n\nSem desconto :\tR$ {4:F2} \nCom desconto :\tR$ {5:F2} \nDesconto :\t\t{6:F1} %", produto[0].nome, produto[0].validade, produto[0].prateleira, produto[0].quantidade, produto[0].preco, produto[0].preco * (1 - (ofertas[0].desconto)/100), ofertas[0].desconto);
                            ClienteOfertaTextBox1.Text = oferta;
                            ClienteOfertaTextBox2.Text = "";
                            break;
                        case 2:
                            string oferta1 = string.Format("Produto:\t\t{0} \n\nValidade:\t\t{1:dd/MM/yyyy} \nPrateleira:\t\t{2} \nEstoque:\t\t{3}\n\nSem desconto :\tR$ {4:F2} \nCom desconto :\tR$ {5:F2} \nDesconto :\t\t{6:F1} %", produto[0].nome, produto[0].validade, produto[0].prateleira, produto[0].quantidade, produto[0].preco, produto[0].preco * (1 - (ofertas[0].desconto) / 100), ofertas[0].desconto);
                            string oferta2 = string.Format("Produto:\t\t{0} \n\nValidade:\t\t{1:dd/MM/yyyy} \nPrateleira:\t\t{2} \nEstoque:\t\t{3}\n\nSem desconto :\tR$ {4:F2} \nCom desconto :\tR$ {5:F2} \nDesconto :\t\t{6:F1} %", produto[1].nome, produto[1].validade, produto[1].prateleira, produto[1].quantidade, produto[1].preco, produto[1].preco * (1 - (ofertas[1].desconto) / 100), ofertas[1].desconto);
                            ClienteOfertaTextBox1.Text = oferta1;
                            ClienteOfertaTextBox2.Text = oferta2;
                            break;
                    }
                }
            }
        }

        private void ClearOffersBox()
        {
            ClienteOfertaTextBox1.Text = "";
            ClienteOfertaTextBox2.Text = "";
        }

        private void ClearTable()
        {
            ClienteCarrinhoTable.Rows.Clear();
            ClienteCarrinhoTotalValue.Text = "0,00";
        }

        private void FacialRecPictureBox_Click(object sender, EventArgs e)
        {
            IdleTab();
        }
    }
}
