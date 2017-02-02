using MyTICs.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MyTICs.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<CentroEducativo> cEducativo;
        public List<CentroEducativo> centroEducativoList
        {
            get { return cEducativo; }
            set { cEducativo = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel()
        {
            //var centroEducativoService = new CentroEducativo();

            //centroEducativoList = centroEducativoService.GetCentroEducativo();

        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
