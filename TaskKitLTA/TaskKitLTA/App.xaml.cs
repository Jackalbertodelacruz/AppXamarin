using System;
using TaskKitLTA.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TaskKitLTA.BD;
[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TaskKitLTA
{
    public partial class App : Application
    {
        public App(String Filename)
        {
            InitializeComponent();

            TaskRepository.Inicializador(Filename);
            //Coment
            MainPage = new InicioPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
