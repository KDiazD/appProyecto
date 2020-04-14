﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.Net.Http;
using appproyecto.Models;
using appproyecto.Views;

namespace appproyecto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lugares : ContentPage
    {
        private Api api = new Api();
        public Lugares()
        {
            InitializeComponent();
            GetLugares();
        }

        private async void GetLugares()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api.url + "/citytour/listar_lugares");
            var listar_lugares = JsonConvert.DeserializeObject<List<Listar_lugares>>(response);
            Listado_lugares.ItemsSource = listar_lugares;

        }
    }
}