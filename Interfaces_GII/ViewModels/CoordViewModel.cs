using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using Interfaces_GII.Model;
using Interfaces_GII.ViewModels;
using Interfaces_GII.Views;


namespace Interfaces_GII.ViewModels
{
    public class CoordViewModel :  INotifyPropertyChanged
    {

        #region Atributos
        private double coorX;
        private string _mTipo_Text;
        private string _mEjex_Text;
        private Visibility _ejes;
        private Visibility _barrasCanvas;
        private Visibility _poliCanvas;
        private ObservableCollection<Coordenada> coordenadas;
        private PointCollection _puntos;
        private double coorY;
        private double alturaCanvas;
        private double anchoCanvas;
        private double mitadAltura;
        private double mitadAnchura;
        private ICommand addCoordCommand;
        private ICommand clearListCommand;
        private ICommand openCoordDialogCommand;
        private ICommand closeCoordDialogCommand;
        private ICommand mejes_clickCommand;
        private ICommand mtipo_clickCommand;
        private ICommand _gridCellEditEndingCommand;
        private int selectedTab;
        private CuadroCoordenadas c;

        /* Atributos parte polinomio */
        private double rangeXMin;
        private double rangeXMax;
        private string funtionExpression;
        #endregion

        #region Propiedades
        public Visibility Ejes
        {
            get
            {
                return _ejes;
            }
            set
            {
                _ejes = value;
                OnPropertyChanged("Ejes");
            }
        }
        public Visibility BarrasCanvas
        {
            get
            {
                return _barrasCanvas;
            }
            set
            {
                _barrasCanvas = value;
                OnPropertyChanged("BarrasCanvas");
            }
        }
        public Visibility PoliCanvas
        {
            get
            {
                return _poliCanvas;
            }
            set
            {
                _poliCanvas = value;
                OnPropertyChanged("PoliCanvas");
            }
        }
        public string MTipo_Text
        {
            get
            {
                return _mTipo_Text;
            }
            set
            {
                _mTipo_Text = value;
                OnPropertyChanged("MTipo_Text");
            }
        }
        public string MEjes_Text
        {
            get
            {
                return _mEjex_Text;
            }
            set
            {
                _mEjex_Text = value;
                OnPropertyChanged("MEjes_Text");
            }
        }
        public PointCollection Puntos
        {
            get
            {
                if (_puntos == null) _puntos = new PointCollection();
                return _puntos;
            }
            set
            {
                _puntos = value;
                OnPropertyChanged("Puntos");
            }
        }
        public double MitadAltura
        {
            get
            {
                return mitadAltura;
            }
            set
            {
                mitadAltura = value;
                OnPropertyChanged("MitadAltura");
            }
        }
        public double MitadAnchura
        {
            get
            {
                return mitadAnchura;
            }
            set
            {
                mitadAnchura = value;
                OnPropertyChanged("MitadAnchura");
            }
        }
        public double RangeXMin
        {
            get
            {
                return rangeXMin;
            }
            set
            {
                rangeXMin = value;
                OnPropertyChanged("RangeXMin");
            }
        }
        public double RangeXMax
        {
            get
            {
                return rangeXMax;
            }
            set
            {
                rangeXMax = value;
                OnPropertyChanged("RangeXMax");
            }
        }
        public string FunctionExpression
        {
            get
            {
                return funtionExpression;
            }
            set
            {
                funtionExpression = value;
                OnPropertyChanged("FunctionExpression");
            }
        }
        public int SelectedTab
        {
            get { return selectedTab; }
            set
            {
                selectedTab = value;
                Coordenadas.Clear();
                OnPropertyChanged("SelectedTab");
            }
        }
        public double AlturaCanvas
        {
            get
            {
                return alturaCanvas;
            }
            set
            {
                alturaCanvas = value;
                if (alturaCanvas != 0) MitadAltura = alturaCanvas/2;
                if (Coordenadas != null && Coordenadas.Count > 0)
                {
                    Coordenadas = ObtenerCoordenadas(Coordenadas);
                }
                OnPropertyChanged("AlturaCanvas");
            }
        }
        public double AnchoCanvas
        {
            get
            {
                return anchoCanvas;
            }
            set
            {
                anchoCanvas = value;
                if (anchoCanvas != 0) MitadAnchura = anchoCanvas/2;
                if (Coordenadas != null && Coordenadas.Count > 0)
                {
                    Coordenadas = ObtenerCoordenadas(Coordenadas);
                }
                OnPropertyChanged("AnchoCanvas");
            }
        }
        public ObservableCollection<Coordenada> Coordenadas
        {
            get
            {
                if (coordenadas == null)
                {
                    coordenadas = new ObservableCollection<Coordenada>();
                } 
                return coordenadas;
            }
            set
            {
                coordenadas = value;
            }
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
        public ICommand GridCellEditEndingCommand
        {
            get
            {
                return _gridCellEditEndingCommand;
            }
            set
            {
                _gridCellEditEndingCommand = value;
            }
        }
        public ICommand MEjes_ClickCommand
        {
            get { return mejes_clickCommand; }
            set { mejes_clickCommand = value; }
        }
        public ICommand MTipo_ClickCommand
        {
            get { return mtipo_clickCommand; }
            set { mtipo_clickCommand = value; }
        }
        #endregion

        #region Constructores
        public CoordViewModel()
        {
            CoorX = "";
            CoorY = "";
            MTipo_Text = "Puntos";
            MEjes_Text = "Ejes-On";
            Ejes = Visibility.Visible;
            BarrasCanvas = Visibility.Visible;
            PoliCanvas = Visibility.Collapsed;
            AddCoordCommand = new CommandBase(param => this.AddCoord());
            ClearListCommand = new CommandBase(new Action<Object>(ClearCoordList));
            OpenCoordDialogCommand = new CommandBase(param => this.OpenDialog());
            CloseCoordDialogCommand = new CommandBase(param => this.CloseDialog());
            GridCellEditEndingCommand = new CommandBase(new Action<Object>(Grid_CellEditEnding));
            MEjes_ClickCommand = new CommandBase(new Action<Object>(MEjes_Click));
            MTipo_ClickCommand = new CommandBase(new Action<Object>(MTipo_Click));
            if (Coordenadas != null)
            {
                Coordenadas.CollectionChanged += OnCollectionChanged;
            }
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

        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Puntos.Clear();
            Coordenadas = ObtenerCoordenadas(Coordenadas);
            int i =Puntos.Count;
            int j = Coordenadas.Count;
        }
        #endregion

        #region Metodos/Funcciones
        private void Grid_CellEditEnding(object sender)
        {
            Puntos.Clear();
            if (Coordenadas != null && Coordenadas.Count > 0)
            {
                Coordenadas = ObtenerCoordenadas(Coordenadas);
            }
        }
        public void AddCoord()
        {
            Coordenada coor = new Coordenada();
            try
            {
                coor.CoorX = double.Parse(CoorX);
                coor.CoorY = double.Parse(CoorY);
                if (coor.CoorX < 9999999 && coor.CoorY < 9999999)
                    if (coor.CoorX > -9999999 && coor.CoorY > -9999999)
                    {
                        //coor = ObtenerCoordenadas(coor);
                        coordenadas.Add(coor);
                        
                    }
                ClearCoordFields();
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

        private void MEjes_Click(object sender)
        {
            
            if (MEjes_Text.Equals("Ejes-On"))
            {
                Ejes = Visibility.Collapsed;
                MEjes_Text = "Ejes-Off";
            }
            else
            {
                MEjes_Text = "Ejes-On";
                Ejes = Visibility.Visible;
            }
        }
        private void MTipo_Click(object sender)
        {
            
            if (MTipo_Text.Equals("Polilinea"))
            {

                MTipo_Text = "Puntos";
                BarrasCanvas = Visibility.Visible;
                PoliCanvas = Visibility.Collapsed;
            }
            else
            {
                MTipo_Text = "Polilinea";
                BarrasCanvas = Visibility.Collapsed;
                PoliCanvas = Visibility.Visible;
            }
        }
        private void dialog_Closed(object sender, EventArgs e)
        {
            c = null;
        }

        private void ClearCoordFields()
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
            coordenadas.Add(coor);
            ClearCoordFields();
        }

        private void ClearCoordList(Object obj)
        {
            coordenadas.Clear();
        }

        public ObservableCollection<Coordenada> ObtenerCoordenadas(ObservableCollection<Coordenada> lista)
        {
            PointCollection _aux = new PointCollection();
            foreach (Coordenada c in lista)
            {
                c.FromX = (AnchoCanvas) / 2 + c.CoorX;
                c.FromY = (AlturaCanvas) / 2;
                c.ToX = (AnchoCanvas) / 2 + c.CoorX;
                c.ToY = (AlturaCanvas) / 2 - c.CoorY;
                _aux.Add(new Point(c.ToX, c.ToY));
            }
            Puntos = _aux;
            return lista;
        }
        
        #endregion
    }//Fin de clase.

}//Fin de namespace.
