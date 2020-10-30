using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3GaloDiazB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_ventana_dos_Clicked(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            string user_validacion = "estudiante2020";
            string pass_validacion = "uisrael2020";

            if (user == user_validacion & pass == pass_validacion)
            {
                await Navigation.PushAsync(new Ventana_2());

            }
            else
            {
                ErrorLabel.Text = "Usuario y contraseña invalidos";
            }
        }

        private void btnAbrir_ventana_dos_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}
