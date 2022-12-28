﻿using SlimeMVVM.Pages;
using SlimeMVVM.Services;
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
    public partial class SonPage : PopupPage
    {
        public SonPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SonPage());
        }
    }
}