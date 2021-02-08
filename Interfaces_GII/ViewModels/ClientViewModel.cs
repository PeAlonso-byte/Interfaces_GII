using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Interfaces_GII.Model;
using Interfaces_GII.ViewModels;
using Interfaces_GII.Views;


namespace Interfaces_GII.ViewModels
{
    public class ClientViewModel : ObservableCollection<Coordenada>, INotifyPropertyChanged
    {

        #region Atributos
        //private int selectedIndex;

        //private int id;
        private double coorX;
        private double coorY;
        private ICommand addCoordCommand;
        private ICommand clearListCommand;
        private ICommand openCoordDialogCommand;
        #endregion

        #region Propiedades
        /*public int SelectedIndexOfCollection
        {
            get
            {
                return selectedIndex;
            }//Fin de get.
            set
            {
                selectedIndex = value;
                OnPropertyChanged("SelectedIndexOfCollection");

                //Activa el evento OnPropertyChanged de los atributos para refrescar las propiedades segun el indice seleccionado.
                //OnPropertyChanged("CoorX");
                //OnPropertyChanged("CoorY");
            }//Fin de set.
        }//Fin de propiedad Selected.
        */
        public double CoorX
        {
            get
            {
                return coorX;
            }
            set
            {
                if (this.Items.Count == 0)
                {
                    coorX = value;
                } 
                else
                {
                    coorX = value;
                }
                OnPropertyChanged("CoorX");
            }
        }//Fin de propiedad CoorX.

        public double CoorY
        {
            get
            {
                if (this.Items.Count == 0)
                {
                    return coorY;
                }
                
                else
                {
                    return coorY;
                }
            }
            set
            {
                if (this.Items.Count == 0)
                {
                    coorY = value;
                }
                
                else
                {
                    coorY = value;
                }
                OnPropertyChanged("CoorY");
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
        #endregion

        #region Constructores
        public ClientViewModel()
        {
            

            AddCoordCommand = new CommandBase(param => this.AddCoord());
            ClearListCommand = new CommandBase(new Action<Object>(ClearCoordList));
            OpenCoordDialogCommand = new CommandBase(param => this.OpenDialog());
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
            coor.CoorX = CoorX;
            coor.CoorY = CoorY;
            this.Add(coor);
            ClearCoordFields(null);
        }//Fin de AddClient.

        private void OpenDialog()
        {
            CuadroCoordenadas c = new CuadroCoordenadas(this);
            c.ShowDialog();
        }

        private void ClearCoordFields(object obj)
        {
            //SelectedIndexOfCollection = -1;
            CoorY = 0;
            CoorX = 0;
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
        #endregion
    }//Fin de clase.
}//Fin de namespace.
