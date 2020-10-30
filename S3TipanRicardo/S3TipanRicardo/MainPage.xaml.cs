using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace S3TipanRicardo
{
    public partial class MainPage : ContentPage
    {

        string errorMessage = null;
        public MainPage()
        {
            InitializeComponent();
        }

        void limpiar()
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private async void bntventana1_Clicked(object sender,EventArgs e)
        {
            //abrir vista dos
            string user = txtUser.Text;
            string pass = txtPass.Text;
            if (txtUser.Text=="estudiante2020" && txtPass.Text=="uisrael2020" )
            {
                await DisplayAlert("Acceso Correcto", errorMessage, "OK");
                await Navigation.PushAsync(new VistaDos(user, pass));

            }
            else
            {
                await DisplayAlert("Usuario o Contraseña Incorrecta", errorMessage, "OK");
                await Navigation.PushAsync(new MainPage());
                limpiar();
              
            }

            
        }

    }

}
