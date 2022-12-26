using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SlimeMVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FatherPage : ContentPage
    {
        public FatherPage()
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            PopupNavigation.Instance.PushAsync(new SonPage());
        }
    }
}