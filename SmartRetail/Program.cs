using System;
using System.Threading;
using System.Windows.Forms;

namespace SmartRetail
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>

	    static void ThreadCaixa()
        {
            Caixa caixaForm = new Caixa();
            Application.Run(caixaForm);
        }
        static void ThreadTotem()
        {
            Totem totemForm = new Totem();
            Application.Run(totemForm);
        }
        static void ThreadApp()
        {
            App appForm = new App();
            Application.Run(appForm);
        }
        static void ThreadPrateleira()
        {
            Prateleira prateleiraForm = new Prateleira();
            Application.Run(prateleiraForm);
        }


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Thread caixaThread = new Thread(new ThreadStart(ThreadCaixa));
            Thread totemThread = new Thread(new ThreadStart(ThreadTotem));
            Thread appThread = new Thread(new ThreadStart(ThreadApp));
            Thread prateleiraThread = new Thread(new ThreadStart(ThreadPrateleira));

            caixaThread.SetApartmentState(ApartmentState.STA);
            totemThread.SetApartmentState(ApartmentState.STA);
            appThread.SetApartmentState(ApartmentState.STA);
            prateleiraThread.SetApartmentState(ApartmentState.STA);

            caixaThread.Start();
            totemThread.Start();
            appThread.Start();
            prateleiraThread.Start();

        }
    }
}
