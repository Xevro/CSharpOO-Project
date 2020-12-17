using Datalayer;
using Logic;
using System;
using System.Windows.Forms;

namespace PresentationForm
{
    static class Presentation
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var logic = new LogicHandler(new DataLoader());

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PresentationForm(logic));
        }
    }
}
