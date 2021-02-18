using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_GII.Model
{
    public class Coordenada : NotifyBase
    {

        #region Atributos
        private double coorX;
        private double coorY;
        private Linea miLinea = new Linea();
        #endregion

        #region Propiedades
        public Linea MiLinea
        {
            get
            {
                return miLinea;
            }
            set
            {
                miLinea = value;
                OnPropertyChanged("MiLinea");
            }
        }
        public double CoorX
        {
            get
            {
                return coorX;
            }//Fin de get.
            set
            {
                coorX = value;
                miLinea.FromX = value;
                miLinea.ToX = value;
                OnPropertyChanged("CoorX");
                
            }//Fin de set.
        }//Fin de propiedad Name.

        public double CoorY
        {
            get
            {
                return coorY;
            }//Fin de get.
            set
            {
                coorY = value;
                miLinea.ToY = value;
                OnPropertyChanged("CoorY");
            }//Fin de set.
        }//Fin de propiedad LastName.

        //Fin de la propiedad readonly DisplayName.
        #endregion

    }//Fin de clase.

    public class Linea : NotifyBase
    {
        #region Atributos
        private double toX;
        private double fromX;
        private double toY;
        private double fromY = 0; // Siempre va a ir desde 0 hasta toY
        #endregion

        #region Propiedades
        public double ToX
        {
            get
            {
                return toX;
            }
            set
            {
                toX = value;
                OnPropertyChanged("ToX");
            }
        }
        public double ToY
        {
            get
            {
                return toY;
            }
            set
            {
                toY = value;
                OnPropertyChanged("ToY");
            }
        }
        public double FromX
        {
            get
            {
                return fromX;
            }
            set
            {
                fromX = value;
                OnPropertyChanged("FromX");
            }
        }
        public double FromY
        {
            get
            {
                return fromY;
            }
            set
            {
                fromY = value;
                OnPropertyChanged("FromY");
            }
        }
        #endregion


    }

}//Fin de namespace.
