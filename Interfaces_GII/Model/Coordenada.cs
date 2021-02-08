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
        ///*private int id;
        private double coorX;
        private double coorY;
        #endregion

        #region Propiedades
        /*public int Id
        {
            get
            {
                return id;
            }//Fin de get.
            set
            {
                id = value;
                OnPropertyChanged("Id");
                OnPropertyChanged("DisplayName");
            }

        }*/
        //Fin de propiedad Id.

        public double CoorX
        {
            get
            {
                return coorX;
            }//Fin de get.
            set
            {
                coorX = value;
                OnPropertyChanged("CoorX");
                OnPropertyChanged("DisplayName");
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
                OnPropertyChanged("CoorY");
                OnPropertyChanged("DisplayName");
            }//Fin de set.
        }//Fin de propiedad LastName.

        /*public string DisplayName
        {
            get
            {
                return Id + "-" + CoorX + " " + CoorY;
            }
        }*/
        //Fin de la propiedad readonly DisplayName.
        #endregion

    }//Fin de clase.
}//Fin de namespace.
