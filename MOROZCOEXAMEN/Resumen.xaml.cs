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
    public partial class Resumen : ContentPage
    {
        public Resumen(String Nombre, String Cuota)
        {
            InitializeComponent();
            lblNombre.Text = "" + Nombre;
            txtPagoMensual.Text = "" + Cuota;
        }
    }
}