using MyTICs.DataBaseManager;
using MyTICs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTICs.ViewModels
{
    public class CentroVM
    {
        private List<CentroEducativo> pCentroEducativo;
        public List<Models.CentroEducativo> CentroEducativoList
        {
            get { return pCentroEducativo; }
            set
            {
                pCentroEducativo = value;
                //OnPropertyChanged();
            }
        }
        public CentroVM()
        {
            var centroEducativo = new CentroEducativoDB();
           
            CentroEducativoList = centroEducativo.GetCentrosEducativos();
        }
    }
}
