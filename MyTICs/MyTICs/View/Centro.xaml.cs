using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyTICs.View
{
    public partial class Centro : ContentPage
    {
        Models.CentroEducativo centroEducativo = new Models.CentroEducativo();
        public Centro(Models.CentroEducativo centroEducativo)
        {
            InitializeComponent();

            if (centroEducativo != null)
                GetCentroEducativo(centroEducativo);
        }

        private void GetCentroEducativo(Models.CentroEducativo centroEducativo)
        {
            this.centroEducativo = centroEducativo;
            nombreCentroEntry.Text = centroEducativo.NombreCentro;
            direcionEntry.Text = centroEducativo.Direccion;
            latitudEntry.Text = centroEducativo.Latitud.ToString();
            longitudEntry.Text = centroEducativo.Longitud.ToString();
        }

        public async void OnSaveClicked(object sender, EventArgs args)
        {
            if (Valid())
            {
                centroEducativo.NombreCentro = nombreCentroEntry.Text;
                centroEducativo.Direccion = direcionEntry.Text;
                centroEducativo.Latitud = Convert.ToDouble(latitudEntry.Text);
                centroEducativo.Longitud = Convert.ToDouble(latitudEntry.Text);

                DataBaseManager.CentroEducativoDB centroEducativoDB = new DataBaseManager.CentroEducativoDB();

                if (centroEducativoDB.Save(centroEducativo))
                    await DisplayAlert("Guardar", "Guardado satisfactoriamente", "OK");
                else
                    await DisplayAlert("Guardar", "No se puedo guardar", "OK");

                await Navigation.PopToRootAsync(true);
                    
                    //Navigation.PushModalAsync(new NavigationPage(new Tab()));

                //Navigation.PushAsync(new PersonList());
                //new NavigationPage(new PersonList());
            }
        }

        bool Valid()
        {
            if (string.IsNullOrEmpty(nombreCentroEntry.Text))
            {
                DisplayAlert("Validar", "Definir nombre centro", "OK");
                nombreCentroEntry.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(direcionEntry.Text))
            {
                DisplayAlert("Validar", "Definir dirección", "OK");
                direcionEntry.Focus();
                return false;
            }

            return true;
        }
    }
}
