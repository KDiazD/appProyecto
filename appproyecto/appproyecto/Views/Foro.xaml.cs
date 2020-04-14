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
    public partial class Foro : ContentPage
    {
        private Api api = new Api();
        public Foro()
        {
            InitializeComponent();
            GetForo();
        }

        private async void GetForo()
        {
            HttpClient cliente = new HttpClient();
            string response = await cliente.GetStringAsync(api.url + "/citytour/listar_comentarios");
            var foro = JsonConvert.DeserializeObject<List<Listar_foro>>(response);
            Lista_Foro.ItemsSource = foro;

        }
    }
}