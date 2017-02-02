using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyTICs.View
{
    public partial class CentroList : ContentPage
    {
        public CentroList()
        {
            InitializeComponent();
            //centroListView.ItemSelected += CentroListView_ItemSelected;
            centroListView.ItemTapped += CentroListView_ItemTapped;              
        }

        private void CentroListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new CentroDetail((Models.CentroEducativo)e.Item));
        }

        protected override void OnAppearing()
        {
            //centroListView.ItemsSource
            ViewModels.CentroVM centroVM = new ViewModels.CentroVM();
            BindingContext = centroVM;
        }        

        //private void CentroListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    Navigation.PushAsync(new CentroDetail((Models.CentroEducativo)e.SelectedItem));
        //}

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new View.Centro(null));
        }
    }
}
