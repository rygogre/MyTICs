using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MyTICs.View
{
    public partial class CentroDetail : ContentPage
    {
        Models.CentroEducativo centroEducativo = new Models.CentroEducativo();
        public CentroDetail(Models.CentroEducativo centroEducativo)
        {
            InitializeComponent();

            this.centroEducativo = centroEducativo;
            GetCentroEducativo();
            SetPinMap();
        }
      
        private void GetCentroEducativo()
        {
            centroLabel.Text =  centroEducativo.NombreCentro;
            direccionLabel.Text = centroEducativo.Direccion;
        }

        private void SetPinMap()
        {
            var pin = new Pin
            {
                Position = new Position(centroEducativo.Latitud, centroEducativo.Longitud),
                Label = centroEducativo.NombreCentro,                
                Address = centroEducativo.Direccion
            };

            mainMap.Pins.Add(pin);
        }

        public async void OnEditClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new View.Centro(centroEducativo));
        }

        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            var result = await this.DisplayAlert("Eliminar", "Esta seguro desea eliminar?", "Si", "No");

            if (result)
            {
                DataBaseManager.CentroEducativoDB centroEducativoDB = new DataBaseManager.CentroEducativoDB();
                centroEducativoDB.Delete(centroEducativo);
                await Navigation.PopToRootAsync(true);
            }
        }
    }
}
