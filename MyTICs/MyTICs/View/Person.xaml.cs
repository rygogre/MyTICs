using MyTICs.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace MyTICs.View
{
    public partial class Person : ContentPage
    {
        PersonVM personVM;
        Models.Person person = new Models.Person();
        Dictionary<string, int> centros;
        int idCentroSelect = 0;

        public Person(Models.Person person)
        {
            InitializeComponent();

            GetCentrosEducativos();
            centroEducativoPicker.SelectedIndexChanged += this.centroEducativoPickerSelectedIndexChanged;

            if (person != null)
                EditPerson(person);
        }

        void EditPerson(Models.Person person)
        {
            this.person = person;
            cedulaEntry.Text = person.Cedula;
            nombreEntry.Text = person.Nombre;
            apellidosEntry.Text = person.Apellidos;
            telefonoEntry.Text = person.Telefono;
            emailEntry.Text = person.Email;
            //centroEducativoPicker

            foreach (var item in centros)
            {
                int i = 1;
                if (item.Value == person.IDCentroEducativo)
                    centroEducativoPicker.SelectedIndex = i;

                i++;
            }
        }

        public void centroEducativoPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var idCentro = centroEducativoPicker.Items[centroEducativoPicker.SelectedIndex];
                idCentroSelect = centros[idCentro];
            }
            catch { }
        }

        void GetCentrosEducativos()
        {
            personVM = new ViewModels.PersonVM();

            centros = personVM.CentrosEducativos();
            centroEducativoPicker.Items.Clear();

            centroEducativoPicker.Items.Add("Seleccionar centro");
            centroEducativoPicker.TextColor = Color.Gray;
            foreach (var item in centros.Keys)
            {
                centroEducativoPicker.Items.Add(item);
            }

            centroEducativoPicker.SelectedIndex = 0;
        }

        public async void OnSaveClicked(object sender, EventArgs args)
        {
            if (Valid())
            {
                person.Cedula = cedulaEntry.Text;
                person.Nombre = nombreEntry.Text.Trim();
                person.Apellidos = apellidosEntry.Text.Trim();
                person.Telefono = telefonoEntry.Text;
                person.IDCentroEducativo = idCentroSelect;
                person.Email = emailEntry.Text.Trim().ToLower();

                DataBaseManager.PersonDB personDB = new DataBaseManager.PersonDB();

                if (personDB.Save(person))
                    await DisplayAlert("Guardar", "Guardado satisfactoriamente", "OK");
                else
                    await DisplayAlert("Guardar", "No se pudo guardar", "OK");

                await Navigation.PopToRootAsync(true);
            }
        }

        /// <summary>
        /// Validar entradas.
        /// </summary>
        /// <returns>bool</returns>
        bool Valid()
        {
            if (string.IsNullOrEmpty(cedulaEntry.Text))
            {
                DisplayAlert("Validar", "Definir cédula", "OK");
                cedulaEntry.Focus();
                return false;
            }

            if (cedulaEntry.Text.Length != 11)
            {
                DisplayAlert("Validar", "Cédula incompleta", "OK");
                cedulaEntry.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(nombreEntry.Text))
            {
                DisplayAlert("Validar", "Definir nombre", "OK");
                nombreEntry.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(apellidosEntry.Text))
            {
                DisplayAlert("Validar", "Definir apellidos", "OK");
                apellidosEntry.Focus();
                return false;
            }

            return true;
        }
    }
}
