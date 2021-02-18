using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Interfaces_GII.Model
{
    public class CoordenadasLineas : Shape, INotifyPropertyChanged
    {
        #region Atributos
        private static double fromX = 0;
        private static double fromY = 0;
        private static double toX = 0;
        private static double toY = 0;
        #endregion

        #region Propiedades
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
        #endregion

        #region Constructor
        public CoordenadasLineas() { }
        #endregion

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

        #region Override Line
        private LineGeometry line = new LineGeometry(new Point(fromX, fromY), new Point(toX, toY));
        protected override Geometry DefiningGeometry
        {
            get
            {
                return line;
            }
        }
        #endregion
    }
}
