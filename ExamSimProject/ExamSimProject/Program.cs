using ExamSimProject.Forms;

namespace ExamSimProject
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


            LoginForm loginForm = new();

            Application.Run(loginForm);

            if (loginForm.UserSuccessfullyAuthenticated)
            {
                Application.Run(new Dashboard());
            }
        }
    }
}