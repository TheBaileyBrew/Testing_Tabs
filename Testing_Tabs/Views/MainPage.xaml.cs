using System;
using System.ComponentModel;
using Testing_Tabs.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Testing_Tabs.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    [DesignTimeVisible(false)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public AppTabsViewModel viewModel;

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new AppTabsViewModel();
        }
    }
}