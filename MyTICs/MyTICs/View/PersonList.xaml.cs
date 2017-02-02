using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyTICs.View
{
    public partial class PersonList : ContentPage
    {
        public PersonList()
        {
            InitializeComponent();

            //personListView.ItemSelected += PersonListView_ItemSelected;
            personListView.ItemTapped += PersonListView_ItemTapped;
        }

        private void PersonListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushAsync(new PersonDetail((Models.Person)e.Item));
        }

        protected override void OnAppearing()
        {            
            ViewModels.PersonVM personVM = new ViewModels.PersonVM();
            BindingContext = personVM;

            //personListView.
        }
        //private void PersonListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{   
        //    Navigation.PushAsync(new PersonDetail((Models.Person)e.SelectedItem));          
        //}

        public void OnNewClicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Person(null));
        }
    }
}
