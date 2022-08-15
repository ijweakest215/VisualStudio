using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Ypanto_MultiPage.Views;

namespace Ypanto_MultiPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PersonInfoView());
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
