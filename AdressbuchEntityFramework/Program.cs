using AdressbuchEntityFramework.Model;
using AdressbuchEntityFramework.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdressbuchEntityFramework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UpdateDb();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        private static void UpdateDb()
        {
            using var appCtx = new AppDbContext();
            appCtx.Database.Migrate();
        }
    }
}