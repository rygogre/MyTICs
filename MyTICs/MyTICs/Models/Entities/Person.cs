using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTICs.Models
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int IDPerson { get; set; }
        [NotNull]
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        [Ignore]
        public string NombreCompleto { get { return Nombre + " " + Apellidos; } }
        public string ImagenName { get; set; } = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/male3-512.png";        
        public int IDCentroEducativo { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }


        //public List<Person> GetPersons()
        //{
        //    var p = new List<Person>
        //    {
        //        new Person
        //        {
        //            IDPerson = 1,
        //            Cedula = "056-0133414-6",
        //            Nombre = "Juan Perez",
        //            Apellidos = "Moronta"
        //        },
        //         new Person
        //        {
        //            IDPerson = 2,
        //            Cedula = "056-0133414-7",
        //            Nombre = "Josefina",
        //            Apellidos = "Duarte"
        //        },
        //          new Person
        //        {
        //            IDPerson = 3,
        //            Cedula = "056-0133414-8",
        //            Nombre = "Domingo",
        //            Apellidos = "Javier"
        //        }
        //    };



        //    return p;
        //}
    }
}
