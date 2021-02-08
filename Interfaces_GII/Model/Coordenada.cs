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
        private double fromX, fromY = 0; // Al instanciar la linea siempre va a ir desde y = 0 hasta x=value
        private double toX, toY; 
        #endregion

        #region Propiedades

        public double FromX
        {
            get { return fromX; }
        }
        public double FromY
        {
            get { return fromY; }
        }
        public double ToX
        {
            get { return toX; }
        }
        public double ToY
        {
            get { return toY; }
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
                fromX = value;
                toX = value;
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
                toY = value;
                OnPropertyChanged("CoorY");
            }//Fin de set.
        }//Fin de propiedad LastName.

        //Fin de la propiedad readonly DisplayName.
        #endregion

    }//Fin de clase.
}//Fin de namespace.
