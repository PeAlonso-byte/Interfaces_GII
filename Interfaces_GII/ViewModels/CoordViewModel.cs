using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;
using Interfaces_GII.Model;
using Interfaces_GII.ViewModels;
using Interfaces_GII.Views;


namespace Interfaces_GII.ViewModels
{
    public class CoordViewModel : ObservableCollection<Coordenada>, INotifyPropertyChanged
    {

        #region Atributos
        //private int selectedIndex;

        //private int id;
        private double coorX;
        private double coorY;
        private double wid, hei; // Tamaño del canvas
        private Line linea;
        private ICommand addCoordCommand;
        private ICommand clearListCommand;
        private ICommand openCoordDialogCommand;
        private ICommand closeCoordDialogCommand;
        private CuadroCoordenadas c;
        #endregion

        #region Propiedades
        public double Wid
        {
            get { return wid; }
            set
            {
                wid = value;
            }
        }

        public double Hei
        {
            get { return hei; }
            set { hei = value; }
        }
        public string CoorX
        {
            get
            {
                if (coorX == 9999999) return "";
                return coorX.ToString();
            }
            set
            {
                try
                {
                    coorX = double.Parse(value);
                    OnPropertyChanged("CoorX");

                    // Llamo a un metodo
                } catch (Exception) {
                    coorX = 9999999;
                    OnPropertyChanged("CoorX");

                }

            }
        }//Fin de propiedad CoorX.

        public string CoorY
        {
            get
            {
                if (coorY == 9999999) return "";
                return coorY.ToString();
            }
            set
            {
                try
                {
                    coorY = double.Parse(value);
                    OnPropertyChanged("CoorY");
                } catch (Exception) {
                    coorY = 9999999;
                    OnPropertyChanged("CoorY");

                }

            }
        }//Fin de propiedad CoorY.

        public ICommand AddCoordCommand
        {
            get
            {
                return addCoordCommand;
            }
            set
            {
                addCoordCommand = value;
            }
        }//Fin de ICommand AddCoordCommand.

        public ICommand ClearListCommand
        {
            get
            {
                return clearListCommand;
            }
            set
            {
                clearListCommand = value;
            }
        }//Fin de ICommand ClearCommand.

        public ICommand OpenCoordDialogCommand
        {
            get { return openCoordDialogCommand; }
            set { openCoordDialogCommand = value; }
        } // Fin de ICommand OpenCoordDialog

        public ICommand CloseCoordDialogCommand
        {
            get { return closeCoordDialogCommand; }
            set { closeCoordDialogCommand = value; }
        }

        #endregion

        #region Constructores
        public CoordViewModel()
        {
            CoorX = "";
            CoorY = "";

            AddCoordCommand = new CommandBase(param => this.AddCoord());
            ClearListCommand = new CommandBase(new Action<Object>(ClearCoordList));
            OpenCoordDialogCommand = new CommandBase(param => this.OpenDialog());
            CloseCoordDialogCommand = new CommandBase(param => this.CloseDialog());
        }//Fin de constructor.

        
        #endregion

        #region Interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }//Fin de OnPropertyChanged.
        #endregion

        #region Metodos/Funcciones
        private void AddCoord()
        {
            Coordenada coor = new Coordenada();
            try
            {
                coor.CoorX = double.Parse(CoorX);
                coor.CoorY = double.Parse(CoorY);
                if (coor.CoorX < 9999999 && coor.CoorY < 9999999)
                    if (coor.CoorX > -9999999 && coor.CoorY > -9999999)
                        this.Add(coor);
                CoorX = "";
                CoorY = "";
            } catch (Exception) { }
            
        }//Fin de AddClient.

        private void OpenDialog()
        {
            if (c != null) return;                                      
            c = new CuadroCoordenadas(this);
            c.Closed += dialog_Closed;
            c.Show();
        }

        private void CloseDialog()
        {
            if (c != null)
            {
                c.Close();
                
            }
        }

        private void dialog_Closed(object sender, EventArgs e)
        {
            c = null;
        }

        private void ClearCoordFields(object obj)
        {
            //SelectedIndexOfCollection = -1;
            CoorY = "";
            CoorX = "";
        }//Fin de AddClient.


        private void addDefaultCoord()
        {
            Coordenada coor = new Coordenada();
            coor.CoorX = 10;
            coor.CoorY = 10;
            this.Add(coor);
            ClearCoordFields(null);
        }

        private void ClearCoordList(Object obj)
        {
            this.Clear();
        }

        private void MuestraCoordenadas()
        {
            
        }
        #endregion
    }//Fin de clase.
}//Fin de namespace.
