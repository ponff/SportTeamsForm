using MySql.Data.MySqlClient;
using SportTeamsProg;

namespace SportTeamsForm
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
            Application.Run(new Form1()); string ConnectionString = "Server = localhost; Database = MyTeam; User = root; Password =; Port = 3306;";

        }
    }
}