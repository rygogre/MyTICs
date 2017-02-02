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
    public class CentroEducativoDB
    {
        SQLiteConnection cnn;
        public CentroEducativoDB()
        {
            cnn = DependencyService.Get<ISQLite>().GetConnection();
            cnn.CreateTable<CentroEducativo>();
        }

        public bool Save(CentroEducativo centroEducativo)
        {
            var result = (from centro in cnn.Table<CentroEducativo>().AsEnumerable<CentroEducativo>()
                          where centro.IDCentroEducativo == centroEducativo.IDCentroEducativo
                          select centro).ToList();

            if (result.Count == 0)
            {
                try
                {
                    cnn.Insert(centroEducativo);

                    return true;
                }
                catch { return false; }
            }
            else
                try
                {
                    cnn.Update(centroEducativo);

                    return true;
                }
                catch { return false; }
        }

        public void Delete(CentroEducativo centroEducativo)
        {
            var result = (from centro in cnn.Table<CentroEducativo>().AsEnumerable<CentroEducativo>()
                       where centro.IDCentroEducativo == centroEducativo.IDCentroEducativo
                       select centroEducativo).ToList();

            if (result.Count == 1)
                cnn.Delete(centroEducativo);
            else
                throw new Exception("Item not found");
        }

        public List<CentroEducativo> GetCentrosEducativos()
        {
            return cnn.Table<CentroEducativo>().AsEnumerable<CentroEducativo>().ToList();
        }

        public CentroEducativo GetCentroEducativo(int idCentroEducativo)
        {
            var result = (from centro in cnn.Table<CentroEducativo>().AsEnumerable<CentroEducativo>()
                          where centro.IDCentroEducativo == idCentroEducativo
                          select centro).FirstOrDefault();

            return result;
        }

        public static implicit operator CentroEducativoDB(PersonDB v)
        {
            throw new NotImplementedException();
        }
    }
}
