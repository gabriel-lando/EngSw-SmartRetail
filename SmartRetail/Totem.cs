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

            FacialRecPictureBox.Image = image;
        }
    }
}
