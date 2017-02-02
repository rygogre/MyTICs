using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MyTICs.View
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        public void OnMapType(object sender, EventArgs args)
        {
            Button map = sender as Button;

            //switch map
                
                    mainMap.MapType = MapType.Street;               
            
        }

        public void OnMapType1(object sender, EventArgs args)
        {

            mainMap.MapType = MapType.Satellite;

        }

        public void OnMapType2(object sender, EventArgs args)
        {

            mainMap.MapType = MapType.Hybrid;

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            mainMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(19.291869, -70.245933),
                Distance.FromKilometers(5)));


            var pin = new Pin
            {
                Position = new Position(19.291869, -70.245933),
                Label = "Liceo",
                Address = "Av. Libetad No. 19"
                
            };

            var pin1 = new Pin
            {
                Position = new Position(19.290745, -70.259028),
                Label = "Escuela Padre Bre",
                Address = "Av. Libetad No. 19"

            };

            mainMap.Pins.Add(pin);
            mainMap.Pins.Add(pin1);
        }
    }
}
