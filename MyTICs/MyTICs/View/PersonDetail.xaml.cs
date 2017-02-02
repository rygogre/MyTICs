using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyTICs.View
{
    public partial class PersonDetail : ContentPage
    {
        Models.Person person = new Models.Person();
       
        public PersonDetail(Models.Person person)
        {
            InitializeComponent();

            this.person = person;
            SetPerson();
          
        }

        void SetPerson()
        {
            cedulaLabel.Text = person.Cedula;
            nombreLabel.Text = person.NombreCompleto;
            TelefonoLabel.Text = person.Telefono;
            EmailLabel.Text = person.Email;            
            GetCentrosEducativos();
        }


        public async void OnEditClicked(object sender, EventArgs args)
        {            
            await Navigation.PushAsync(new View.Person(person));            
        }

        public async void OnDeleteClicked(object sender, EventArgs args)
        {
            var result = await this.DisplayAlert("Eliminar", "Esta seguro desea eliminar?", "Si", "No");

            if (result)
            {
                DataBaseManager.PersonDB personDB = new DataBaseManager.PersonDB();
                personDB.Delete(person);
                await Navigation.PopToRootAsync(true);
            }
        }

        void GetCentrosEducativos()
        {
            ViewModels.PersonVM personVM = new ViewModels.PersonVM();
            Dictionary<string, int> centros = personVM.CentrosEducativos();
            
            foreach (var item in centros)
            {
                if (item.Value == person.IDCentroEducativo)
                    centroEducativoLabel.Text = item.Key;                
            }            
        }
    }
}
