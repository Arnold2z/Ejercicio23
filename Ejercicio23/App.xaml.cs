﻿namespace Ejercicio23
{
    public partial class App : Application
    {
        private static Controllers.DBProc dbProc;

        public static Controllers.DBProc Instancia
        {
            get
            {
                if (dbProc == null)
                {
                    string dbname = "AudiosDB.db3";
                    string dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    string dbfull = Path.Combine(dbpath, dbname);
                    dbProc = new Controllers.DBProc(dbfull);
                }

                return dbProc;
            }
        }

        public App()
        {
            InitializeComponent();

            //MainPage = new PaginaInicio();

            MainPage = new NavigationPage(new view.PaginaInicio());
        }
    }
}
