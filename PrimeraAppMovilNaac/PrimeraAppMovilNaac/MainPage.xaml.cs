using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PrimeraAppMovilNaac
{
    public partial class MainPage : ContentPage
    {
        public Persona Persona { get; set; }

        public MainPage()
        {
            Persona = new Persona()
            {
                Apellido = "Alvarez",
                Nombre = "Nicolas"
            };
            BindingContext = new  {Persona};
            

        InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var Texto = Entrada.Text;
            DisplayAlert("Alerta", "Caputardo: "+Texto+" Objeto con binding: "+Persona.Nombre, "Aceptar", "Cancelar");
        }

        private void BotonSegundaPagina_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pagina_secundaria(Persona));
        }
    }
}
