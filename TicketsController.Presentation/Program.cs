using System;
using System.Windows.Forms;
using TicketsController.Application.Controllers;

namespace TicketsController.Presentation
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            System.Windows.Forms.Application.SetHighDpiMode(HighDpiMode.SystemAware);
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            var controller = new FormController();
            controller.OpenHome();
            
        }
    }
}
