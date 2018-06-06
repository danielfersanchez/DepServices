﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DepServices
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btnMessage.Clicked += BtnMessage_Clicked;

        }


        private async void BtnMessage_Clicked(object sender, EventArgs e)
        {
            var service = DependencyService.Get<IPlatMessage>();
            var message = service.GetMessage();
            await DisplayAlert("dependecy service", message, "ok");

        }

        private Task DisplayAlert(string v1, object message, string v2)
        {
            throw new NotImplementedException();
        }
    }
}

