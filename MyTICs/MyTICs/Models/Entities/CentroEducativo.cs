using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTICs.Models
{
    public class CentroEducativo
    {
        [PrimaryKey, AutoIncrement]
        public int IDCentroEducativo { get; set; }
        public string NombreCentro { get; set; }
        //public string url { get; set; } = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/male3-512.png";
        public string Direccion { get; set; }
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        //public List<CentroEducativo> GetCentroEducativo()
        //{
        //    var centroEducativo = new List<CentroEducativo>
        //    {
        //        new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Luis Yanguela"
        //        },
        //        new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Ercilia Pepin"
        //        },
        //        new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //          new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //            new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //              new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                  new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                    new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                      new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                        new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                          new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                            new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                              new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                                new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                                  new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        },
        //                                    new CentroEducativo
        //        {
        //            IDCentroEducativo = 1,
        //            NombreCentro = "Eugenio Cruz"
        //        }

        //    };

        //    return centroEducativo;
        //}
    }
}
