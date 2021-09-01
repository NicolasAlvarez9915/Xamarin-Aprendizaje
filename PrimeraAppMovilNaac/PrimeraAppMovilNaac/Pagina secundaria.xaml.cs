using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeraAppMovilNaac
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina_secundaria : ContentPage
    {
        
        public Pagina_secundaria()
        {
            InitializeComponent();
        }
        
        public Pagina_secundaria(Persona persona)
        {
            InitializeComponent();
            DisplayAlert("Llego", persona.Nombre, "Cancelar", "Aceptar");
        }
    }
}