using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MOROZCOEXAMEN
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string password = txtPassword.Text;

            if (usuario == "estudiante2021" && password == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro());
            }
            else
            {
                await DisplayAlert("Error", "Datos incorrectos", "OK");
            }


        }
    }
}