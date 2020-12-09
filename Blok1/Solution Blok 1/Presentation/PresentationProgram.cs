using Logic;
using System;
using System.Windows.Forms;

namespace Presentation
{
    static class PresentationProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory inv = new Inventory();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentation(inv));
        }
    }
}
