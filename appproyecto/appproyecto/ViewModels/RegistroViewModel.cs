using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using appproyecto.Services;
using Xamarin.Forms;
using appproyecto.Models;
using System.Threading.Tasks;

namespace appproyecto.ViewModels
{

    public class RegistroViewModel : BaseViewModel
    {
        private ApiService apiService;
        public RegistroModel InfoUsuario { get; set; }


        public RegistroViewModel()
        {
            this.apiService = new ApiService();
            this.InfoUsuario = new RegistroModel();
        }


   
        public ICommand RegistroCommand => new Command(Registrarse);


        private async void Registrarse()
        {
            // validacion de que los campos 
            if (await this.Validar())
            {
                return;
            }

            var response = await this.apiService.Post("citytour/registro_usuarios/", this.InfoUsuario);
            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert("Error", response.Message, "Accept");
                return;
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Exitoso", "Usuario registrado exitosamente", "Accept");
                return;
            }

        }

        public async Task<bool> Validar()
        {
            if (this.InfoUsuario.user == null)
            {
                await Application.Current.MainPage.DisplayAlert("Advertencia", "Ingrese el usuario", "Aceptar");
                return true;
            }

            if (this.InfoUsuario.pass == null)
            {
                await Application.Current.MainPage.DisplayAlert("Advertencia", "Ingrese la contrseña", "Aceptar");
                return true;
            }
            return false;
        }



    }


}
