using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyTICs.Cells
{
    class PersonsListItemCell : ViewCell
    {
        public PersonsListItemCell()
        {
            var IDPersonLabel = new Label
            {
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Start
            };

            IDPersonLabel.SetBinding(Label.TextProperty, new Binding("IDPerson"));

            var cedulaLabel = new Label
            {
                TextColor = Color.Black,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.Fill
            };

            cedulaLabel.SetBinding(Label.TextProperty, new Binding("Cedula"));

            var nombreLabel = new Label
            {
                TextColor = Color.Red,
               FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                HorizontalOptions = LayoutOptions.CenterAndExpand
                
            };

            nombreLabel.SetBinding(Label.TextProperty, new Binding("Nombre"));

            var panel = new StackLayout {

                Children = { nombreLabel },
                Orientation = StackOrientation.Horizontal
            };

            View = new StackLayout
            {
                Children = { IDPersonLabel, panel, cedulaLabel },
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}
