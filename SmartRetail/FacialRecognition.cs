using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;


//namespace WindowsFormsApplication1

//{
//    public partial class Form1 : Form
//    {
        
//    }
//}


namespace SmartRetail
{
    class FacialRecognition
    {
        protected bool validData;

        string path;
        protected Image image;
        protected Thread getImageThread;

        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            validData = GetFilename(out string filename, e);
            if (validData)
            {
                path = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private bool GetFilename(out string filename, DragEventArgs e)
        {
            bool ret = false;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                if (((IDataObject)e.Data).GetData("FileDrop") is Array data)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filename = ((string[])data)[0];
                        string ext = Path.GetExtension(filename).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
        public Image Form_DragDrop(object sender, DragEventArgs e)
        {
            if (validData)
            {
                while (getImageThread.IsAlive)
                {
                    Application.DoEvents();
                    Thread.Sleep(0);
                }
                return image;
            }
            return null;
        }
        protected void LoadImage()
        {
            image = new Bitmap(path);
        }

    }
}
