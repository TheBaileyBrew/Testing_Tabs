using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Testing_Tabs.Services;
using Testing_Tabs.Views;

namespace Testing_Tabs
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage( new MainPage());
            NavigationPage.SetHasNavigationBar(MainPage, true);
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
