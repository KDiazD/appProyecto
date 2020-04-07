﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appproyecto.Views;

namespace appproyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : MasterDetailPage
    {
        public Home()
        {
            InitializeComponent();

            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());

            App.MasterD = this;
        }


    }
}