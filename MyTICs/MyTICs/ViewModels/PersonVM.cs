using MyTICs.DataBaseManager;
using MyTICs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTICs.ViewModels
{
   
    public class PersonVM
    {
        private List<Person> pPersonList;
        private List<CentroEducativo> pCentroEducativo;
        //Dictionary<string, int> Centros = new Dictionary<string, int>();
        public List<Models.Person> PersonList
        {
            get { return pPersonList; }
            set
            {
                pPersonList = value;
                //OnPropertyChanged();
            }
        }

        public List<Models.CentroEducativo> CentroEducativoList
        {
            get { return pCentroEducativo; }
            set
            {
                pCentroEducativo = value;
                //OnPropertyChanged();
            }
        }
        public PersonVM()
        {            
            var person = new PersonDB();
            var centroEducativo = new CentroEducativoDB();

            PersonList = person.GetPersons();
            CentroEducativoList = centroEducativo.GetCentrosEducativos();
        }

        public Dictionary<string, int> CentrosEducativos()
        {
            Dictionary<string, int> Centros = new Dictionary<string, int>();

            foreach (var item in pCentroEducativo)
            {
                Centros.Add(item.NombreCentro, item.IDCentroEducativo);
            }

            return Centros;
        }
    }
}
