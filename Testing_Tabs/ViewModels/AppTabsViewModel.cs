using System;
using PropertyChanged;

namespace Testing_Tabs.ViewModels
{

    [AddINotifyPropertyChangedInterface]
    public class AppTabsViewModel : Sharpnado.Presentation.Forms.ViewModels.Bindable
    {
        public int SelectedViewModelIndex { get; set; }

        public AppTabsViewModel()
        {
        }
    }
}
