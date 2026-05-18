using LibUsbDotNet.Main;
using LibUsbDotNet;
using CustomDriverStation.UI;

namespace CustomDriverStation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}