using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace IsmtMultimediaMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
            Debug.WriteLine("A app foi executada...");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Debug.WriteLine("A app foi congelada!");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
            Debug.WriteLine("A app foi descongelada!");
        }
    }
}
