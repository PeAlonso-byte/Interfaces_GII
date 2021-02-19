using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_GII.Model
{
    public class Coordenada : CoordenadasLineas
    {

        #region Atributos
        private double coorX;
        private double coorY;
        ViewModels.CoordViewModel vm;
        #endregion

        #region Propiedades
        public double CoorX
        {
            get
            {
                return coorX;
            }//Fin de get.
            set
            {
                coorX = value;
                vm.ObtenerCoordenadas(this);
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
                vm.ObtenerCoordenadas(this);
                OnPropertyChanged("CoorY");
            }//Fin de set.
        }//Fin de propiedad LastName.

        //Fin de la propiedad readonly DisplayName.
        #endregion

        #region Constructor
        public Coordenada () { }
        public Coordenada (ViewModels.CoordViewModel padre)
        {
            vm = padre;
        }
        #endregion

    }//Fin de clase.

}//Fin de namespace.
