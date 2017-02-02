using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace MyTICs
{
    public class Tab : TabbedPage
    {
        public Tab()
        {
            Title = "My TICs";
            Icon = "icon.png";
            BarBackgroundColor = Color.FromHex("#d81b60");      
                      

            Children.Add(new View.PersonList());
            Children.Add(new View.CentroList());
            Children.Add(new View.CameraPage());
            
        }
    }
}
