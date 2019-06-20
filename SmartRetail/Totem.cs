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

        //private void Wait(int time)
        //{
        //    System.Threading.Thread thread = new System.Threading.Thread(delegate ()
        //    {
        //        System.Threading.Thread.Sleep(time);
        //    });
        //    thread.Start();
        //    while (thread.IsAlive)
        //        Application.DoEvents();
        //}

        private void IdleTab()
        {
            TabCtrl.SelectedIndex = 0;
        }
        private void TotemTab(Image image)
        {
            TabCtrl.SelectedIndex = 1;
            FacialRecPictureBox.Image = image;

            ClearTable();
            //ClearComboBox(); // Limpar ofertas

            SQLConnect sql = new SQLConnect();

            if (sql.ReturnProductsSacola(out List<Produto> produtosSacola, out float preco_total, infoID))
            {
                Produto[] produtosArray = produtosSacola.ToArray();

                foreach (Produto produto in produtosArray)
                {
                    string[] tmpRow = new string[]{produto.nome, String.Format("{0:F2}", produto.preco), produto.quantidade.ToString(), String.Format("{0:F2}", produto.preco * produto.quantidade)};
                    ClienteCarrinhoTable.Rows.Add(tmpRow);
                }

                ClienteCarrinhoTotalValue.Text = String.Format("{0:F2}", preco_total);
            }
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
