using System;
using System.IO;
using Xamarin.Forms;
using TareasApp.Services;
using App2.Services;
using App2;

namespace TareasApp
{
    public partial class App : Application
    {
        public static DatabaseService Database { get; private set; }

        public App()
        {
            InitializeComponent();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tareas.db3");
            Database = new DatabaseService(dbPath);

            MainPage = new NavigationPage(new MainPage());
        }
    }
}
