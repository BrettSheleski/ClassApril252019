using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarathonApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MarathonListPage listPage = new MarathonListPage();

            NavigationPage navigationPage = new NavigationPage(listPage);

            MainPage = navigationPage;
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
