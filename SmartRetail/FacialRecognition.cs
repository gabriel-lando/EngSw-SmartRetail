using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SmartRetail
{
    class FacialRecognition
    {
        protected bool validData;

        protected string path, file;
        protected Image image;
        protected Thread getImageThread;

        public void OnDragEnter(object sender, DragEventArgs e)
        {
            validData = GetFilename(out string filename, out string filepath, e);
            if (validData)
            {
                path = filepath;
                file = filename;
                getImageThread = new Thread(new ThreadStart(LoadImage));
                getImageThread.Start();
                e.Effect = DragDropEffects.Copy;
            }
            else
                e.Effect = DragDropEffects.None;
        }
        private bool GetFilename(out string filename, out string filepath, DragEventArgs e)
        {
            bool ret = false;
            filepath = String.Empty;
            filename = String.Empty;
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                if (((IDataObject)e.Data).GetData("FileDrop") is Array data)
                {
                    if ((data.Length == 1) && (data.GetValue(0) is String))
                    {
                        filepath = ((string[])data)[0];
                        filename = Path.GetFileName(filepath);
                        string ext = Path.GetExtension(filepath).ToLower();
                        if ((ext == ".jpg") || (ext == ".png") || (ext == ".bmp"))
                        {
                            ret = true;
                        }
                    }
                }
            }
            return ret;
        }
        public Image OnDragDrop(object sender, DragEventArgs e)
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

        public string RetFilename()
        {
            return file;
        }

    }
}
