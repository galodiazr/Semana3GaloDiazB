using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3GaloDiazB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Ventana_2 : ContentPage
    {
        public Ventana_2()
        {
            InitializeComponent();
            btnTotal.Clicked += BtnTotal_Clicked;
        }

        private void BtnTotal_Clicked(object sender, EventArgs e)
        {
            try
            {                //Parcial uno

                double dato1 = Convert.ToDouble(txtSeguimiento1.Text);
                double dato2 = Convert.ToDouble(txtExamen1.Text);
                double parcial1 = (dato1 * 0.3) + (dato2 * 0.2);

                txtParcial1.Text = parcial1.ToString();


                //Parcial dos
                double dato3 = Convert.ToDouble(txtSeguimiento2.Text);
                double dato4 = Convert.ToDouble(txtExamen2.Text);
                double parcial2 = (dato3 * 0.3) + (dato4 * 0.2);

                txtParcial2.Text = parcial2.ToString();

                //Nota Final
                double final = parcial1 + parcial2;

                txtFinal.Text = final.ToString();

                //Aprobado

                if (final >= 7)
                {
                    txtEstado.Text = "Aprobado";

                }
                else
                {
                    txtEstado.Text = "Reprobado";
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje", "ERROR " + ex.Message, "ok");
            }
        }
    }
}