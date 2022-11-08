using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas_WPF
{
    public class Avisos : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
        
        private String nombre, apellido, nombre_completo;

        private void OnPropertyChanged(string property)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged("Nombre_Completo");
            }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value;
                OnPropertyChanged("Nombre_Completo");
            }
        }

        public string Nombre_Completo
        {
            get {
                nombre_completo = Nombre +" " + Apellido; 
                return nombre_completo;
            }
            set { }
        }
    }
}
