using MyTICs.Models;
using MyTICs.Models.Interface;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyTICs.DataBaseManager
{
    public class PersonDB
    {
        SQLiteConnection cnn;
        public PersonDB()
        {
            cnn = DependencyService.Get<ISQLite>().GetConnection();
            cnn.CreateTable<Person>();            
        }

        public bool Save(Person person)
        {
            var result = (from per in cnn.Table<Person>().AsEnumerable<Person>()
                       where per.Cedula == person.Cedula
                       select per).ToList();

            if (result.Count == 0)
            {
                try
                {
                    cnn.Insert(person);

                    return true;
                }
                catch { return false; }
                }
            else
                try
                {
                    cnn.Update(person);

                    return true;
                }
                catch { return false; }
        }

        public void Delete(Person person)
        {
            var per = (from p in cnn.Table<Person>().AsEnumerable<Person>()
                       where p.Cedula == person.Cedula
                       select p).ToList();

            if (per.Count == 1)
                cnn.Delete(person);
            else
                throw new Exception("Item not found");               
        }

        public List<Person> GetPersons()
        {
            return cnn.Table<Person>().AsEnumerable<Person>().ToList();
        }

        public Person GetPerson(string cedula)
        {
            var result = (from per in cnn.Table<Person>().AsEnumerable<Person>()
                          where per.Cedula == cedula
                          select per).FirstOrDefault();

            return result;
        }
    }
}
