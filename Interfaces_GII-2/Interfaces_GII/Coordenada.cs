using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_GII
{
    public class Coordenada : INotifyPropertyChanged
    {
        #region Atributos
        private double _coorX;
        private double _coorY;
        private double _coorXPant;
        private double _coorYPant;
        #endregion

        #region Propiedades
        public double CoorXPant
        {
            get
            {
                return _coorXPant;
            }
            set
            {
                _coorXPant = value;
                OnPropertyChanged("CoorXPant");
            }
        }
        public double CoorYPant
        {
            get
            {
                return _coorYPant;
            }
            set
            {
                _coorYPant = value;
                OnPropertyChanged("CoorYPant");
            }
        }
        public double CoorX
        {
            get
            {
                return _coorX;
            }
            set
            {
                _coorX = value;
                OnPropertyChanged("CoorX");
            }
        }
        public double CoorY
        {
            get
            {
                return _coorY;
            }
            set
            {
                _coorY = value;
                OnPropertyChanged("CoorY");
            }
        }

        #endregion
        public Coordenada()
        {

        }

        #region Notify
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }

}
