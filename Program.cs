<<<<<<< HEAD
namespace CyberBites
=======
namespace Krypton_Test
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            DatabaseHelper.InitializeDatabase();
=======
>>>>>>> ed5880bb680c0ac93c3e3758ea4eda431d084b6a
            Application.Run(new LoginForm());
        }
    }
}