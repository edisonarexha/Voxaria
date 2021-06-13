using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Voxaria.Views;
using Voxaria.Views.Song_Likes;


namespace Voxaria
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
<<<<<<< Updated upstream
            MainPage = new HomePage();
=======
            MainPage = new Playlist();
>>>>>>> Stashed changes
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
