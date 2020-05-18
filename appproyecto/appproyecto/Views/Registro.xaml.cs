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
    public partial class Registro : ContentPage
    {
        RegistroViewModel ViewModel;

        public Registro()
        {
            InitializeComponent();
            // alternativa mas simple que el locator
            BindingContext = ViewModel = new RegistroViewModel();

        }
    }
}