using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio13
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //Guardar los datos en la base de datos de SQLite
        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                    var person = new Personas
                    {
                        nombre = this.nom.Text,
                        apellido = this.ape.Text,
                        edad = this.edad.Text,
                        mail = this.mail.Text,
                        direccion = this.address.Text
                    };

                    var resultado = await App.BD.GrabarPersonas(person);


                    if (resultado == 1)
                    {
                        ClearScreen();
                        await DisplayAlert("Mensaje", "Datos ingresados correctamente", "OK");
                    }
                    else
                    {
                        await DisplayAlert("Mensaje", "Error, No se logró guardar la información", "OK");

                    }
            }
             catch (Exception ex)
            {
                    await DisplayAlert("Mensaje", ex.Message.ToString(), "OK");

            }
        }

        //Limpiar pantalla
        private void ClearScreen()
        {
            this.nom.Text = String.Empty;
            this.ape.Text = String.Empty;
            this.edad.Text = String.Empty;
            this.mail.Text = String.Empty;
            this.address.Text = String.Empty;
        }
    }

    


}

