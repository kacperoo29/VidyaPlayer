using System;
using System.IO;
using OpenSubtitles.Client;
using SQLite;
using VidyaPlayer.Models;
using VidyaPlayer.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace VidyaPlayer
{
    public partial class App : Application
    {
        public static User CurrentUser;
        
        public App()
        {
            InitializeComponent();
            
            Configuration.Default.BasePath = "https://api.opensubtitles.com/api/v1";
            Configuration.Default.AddApiKey("Api-Key", "OKdgT6FofACk6YvCUOwm2OrPXqcxypqk");
            MainPage = new NavigationPage(new MainPage());
        }

        protected override async void OnStart()
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