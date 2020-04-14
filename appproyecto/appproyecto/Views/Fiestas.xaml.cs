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
    public partial class Fiestas : ContentPage
    {
        private Api api = new Api();
        public Fiestas()
        {
            InitializeComponent();
            GetFiestas();
        }

        private async void GetFiestas()
        {
            HttpClient cliente = new HttpClient();
            string response = await cliente.GetStringAsync(api.url + "/citytour/listar_fiestas");
            var listar_fiestas = JsonConvert.DeserializeObject<List<Listar_fiestas>>(response);
            Listado_fiestas.ItemsSource = listar_fiestas;
        }
    }
}