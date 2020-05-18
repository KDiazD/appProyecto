using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using appproyecto.Services;
using Xamarin.Forms;
using appproyecto.Models;
using System.Threading.Tasks;
using System.Collections.ObjectModel;   

namespace appproyecto.ViewModels
{
    public class LugaresViewModel : BaseViewModel
    {
        private ApiService apiService;

        private ObservableCollection<Listar_lugares> listado_lugares;


        public ObservableCollection<Listar_lugares> Listado_lugares
        {
            get { return this.listado_lugares; }
            set { this.SetValue(ref listado_lugares, value); }
        }

        public LugaresViewModel()
        {
            this.apiService = new ApiService();
            this.CargarLugares();
        }


        private async void CargarLugares()
        {
            var response = await this.apiService.GetList<Listar_lugares>("citytour/listar_lugares");
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Aceptar");
                return;
            }
            var list = (List<Listar_lugares>)response.Result;
            this.Listado_lugares = new ObservableCollection<Listar_lugares>(list);
        }


    }
}
