using Conversor.Services;
using Conversor.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Conversor
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            // MainPage = new AppShell();
            //MainPage = new Menuprincipal();
            MainPage = new Convertir();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
