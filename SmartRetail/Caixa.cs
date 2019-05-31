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
    public partial class Caixa : Form
    {
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
                TabCtrl.SelectedIndex = 3;
                FacialRecPictureBox.Image = image;
            }
        }
    }
}
