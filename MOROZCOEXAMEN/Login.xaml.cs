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
            string user = txtUsuario.Text;
            string pass = txtPassword.Text;

            if (user == "estudiante2021" && pass == "uisrael2021")
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