using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Voxaria.Views;

namespace Voxaria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PodDownloads());
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
