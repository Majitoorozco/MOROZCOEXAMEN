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
    public partial class Registro : ContentPage
    {
        public Registro()
        {
            InitializeComponent();
           
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                double pagoinicial = Convert.ToDouble(txtMontoinicial.Text);
                double montomensual = Convert.ToDouble(txtPagoMensual.Text);

                double cuota = ((montomensual + 90) * 5) + pagoinicial;
                txtPagoMensual.Text = cuota.ToString();
                await DisplayAlert("Alerta", "Elemento Guardado con Exito", "Aceptar");
                await Navigation.PushAsync(new Resumen(txtNombre.Text, txtPagoMensual.Text));
            }
            catch (Exception)
            {
                await DisplayAlert("Advertencia", "Ingrese informacion", "Aceptar");
            }

        }

        }
}