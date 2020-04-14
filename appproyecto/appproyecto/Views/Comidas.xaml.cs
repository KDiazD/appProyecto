using Newtonsoft.Json;
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
    public partial class Comidas : ContentPage
    {
        private Api api = new Api();
        public Comidas()
        {
            InitializeComponent();
            GetComidas();
        }

        private async void GetComidas()
        {
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(api.url + "/citytour/listar_comidas");
            var listar_comidas = JsonConvert.DeserializeObject<List<Listar_comidas>>(response);
            Listado_comidas.ItemsSource = listar_comidas;
        }


    }
}