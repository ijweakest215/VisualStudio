using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YPANTO_Midterm.Views;

namespace YPANTO_Midterm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new NewUser());
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
