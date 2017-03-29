using System;
using System.Windows.Forms;

namespace TaskManagementFinal
{
    static class Program
    {
        /// <summary>
        ///     STAThreadAttribute indicates that the COM threading model for the application is 
        ///     single-threaded apartment. This attribute must be present on the entry point of 
        ///     any application that uses Windows Forms; if it is omitted, the Windows components 
        ///     might not work correctly. If the attribute is not present, the application uses 
        ///     the multithreaded apartment model, which is not supported for Windows Forms.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //  Allows themes to be applied to windows form components. 
            Application.EnableVisualStyles();
            //  The UseCompatibleTextRendering property is intended to provide visual compatibility 
            //  between Windows Forms controls that render text using the TextRenderer class and .NET 
            //  Framework 1.0 and .NET Framework 1.1 applications that perform custom text rendering 
            //  using the Graphics class.
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
