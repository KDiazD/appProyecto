﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using appproyecto.ViewModels;


namespace appproyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lugares : ContentPage
    {
        LugaresViewModel ViewModel;

        public Lugares()
        {
            InitializeComponent();
            BindingContext = ViewModel = new LugaresViewModel();
        }


    }
}