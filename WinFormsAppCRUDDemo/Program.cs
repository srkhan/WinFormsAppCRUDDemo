namespace WinFormsAppCRUDDemo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread] // Indicates that the COM threading model for the application is single-threaded apartment.
        static void Main()
        {
            // Initializes application configuration, such as high DPI settings and default font.
            ApplicationConfiguration.Initialize();

            // Starts the application and opens the main form (Form1).
            Application.Run(new Form1());
        }
    }
}