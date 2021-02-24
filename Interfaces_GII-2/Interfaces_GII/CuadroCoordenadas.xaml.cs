using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Interfaces_GII
{
    /// <summary>
    /// Lógica de interacción para CuadroModal.xaml
    /// </summary>
    public partial class CuadroCoordenadas : Window
    {
        private ObservableCollection<Coordenada> _coordenadas;
        private double _xrealMax;
        private double _xpant;
        private double _xrangoMin = -20;
        private double _xrangoMax = 20;
        private double _x4value;
        private double _x3value;
        private double _x2value;
        private double _xvalue;
        private double _cvalue;
        private PointCollection _puntos;
        private Coordenada _selectedItem;
        private ObservableCollection<int> _gradoPolinomio;
        private int _gradoPolinomioSelected = 0;
        private int _maximogrado = 4;
        private int _selectedIndex = -1;
        private int _selectedTab;
        Style stR, st;
        private Modelo _modelo;

        public int GradoPolinomioSelected
        {
            get
            {
                return _gradoPolinomioSelected;
            }
            set
            {
                _gradoPolinomioSelected = value;
            }
        }
        public ObservableCollection<int> GradoPolinomio
        {
            get
            {
                if (_gradoPolinomio == null)
                {
                    _gradoPolinomio = new ObservableCollection<int>();
                    for (int i=0; i <= _maximogrado; i++)
                    {
                        _gradoPolinomio.Add(i);
                    }
                }
                return _gradoPolinomio;
            }
            set
            {
                _gradoPolinomio = value;
            }
        }
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;
            }
        }
        public double XRangoMax
        {
            get
            {
                return _xrangoMax;
            }
            set
            {
                _xrangoMax = value;
            }
        }
        public double XRangoMin
        {
            get
            {
                return _xrangoMin;
            }
            set
            {
                _xrangoMin = value;
            }
        }
        public int SelectedTab
        {
            get
            {
                return _selectedTab;
            }
            set
            {
                _selectedTab = value;
            }
        }
        public double XRealMax
        {
            get
            {
                return _xrealMax;
            }
            set
            {
                _xrealMax = value;
            }
        }
        public double XRealMin
        {
            get
            {
                return -_xrealMax;
            }
        }

        public double XPant
        {
            get
            {
                return _xpant;
            }
            set
            {
                _xpant = value;
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
            }
        }
        public ObservableCollection<Coordenada> Coordenadas 
        {
            get
            {
                if (_coordenadas == null) _coordenadas = new ObservableCollection<Coordenada>();
                return _coordenadas;
            }
            set
            {
                _coordenadas = value;
            }
        }
        public Coordenada SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;
                if (_selectedItem != null && SelectedTab == 0)
                {
                    btnAnadir.Content = "Editar";
                    btnDeSeleccionar.Visibility = Visibility.Visible;
                    yTextBox.Text = _selectedItem.CoorY.ToString();
                    xTextBox.Text = _selectedItem.CoorX.ToString();
                    btnEliminar.Visibility = Visibility.Visible;
                } else
                {
                    btnAnadir.Content = "Añadir";
                    btnDeSeleccionar.Visibility = Visibility.Collapsed;
                    btnEliminar.Visibility = Visibility.Collapsed;
                    yTextBox.Text = "";
                    xTextBox.Text = "";
                }
                if (_selectedItem != null && SelectedTab == 1)
                {
                    btnDeSeleccionar.Visibility = Visibility.Visible;
                } else if (_selectedItem == null && SelectedTab == 1)
                {
                    btnDeSeleccionar.Visibility = Visibility.Collapsed;
                }
            }
        }
        public CuadroCoordenadas(ObservableCollection<Coordenada> coordenadas, PointCollection puntos)
        {
            InitializeComponent();
            _coordenadas = coordenadas;
            _puntos = puntos;
            stR = FindResource("styleRed") as Style;
            st = FindResource("styleA") as Style;
            DataContext = this;
            _modelo = new Modelo();
            rangeSlider.HigherValueChanged += rangeSlider_HigherValueChanged;
            rangeSlider.LowerValueChanged += rangeSlider_LowerValueChanged;

        }

        private void btnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            var boton = ((Button)sender).Content;
            if (boton.Equals("Añadir"))
            {
                if (!_modelo.isTbValid(xTextBox.Text, 0) && !_modelo.isTbValid(yTextBox.Text, 0))
                {
                    xTextBox.Style = st;
                    yTextBox.Style = st;
                    double x = double.Parse(xTextBox.Text.Replace(".", ","));
                    double y = double.Parse(yTextBox.Text.Replace(".", ","));

                    Coordenada c = new Coordenada();
                    c.CoorX = x;
                    c.CoorY = y;
                    SelectedIndex = -1;
                    SelectedItem = null;
                    Coordenadas.Add(c);
                    if (Coordenadas.Count == 1)
                    {

                    }
                    xTextBox.Text = "";
                    yTextBox.Text = "";
                }
                else
                {
                    xTextBox.Style = stR;
                    yTextBox.Style = stR;
                    xTextBox.Text = "";
                    yTextBox.Text = "";
                }
            }
            else
            {
                if (!_modelo.isTbValid(xTextBox.Text, 0) && !_modelo.isTbValid(yTextBox.Text, 0))
                {
                    int index = 0;
                    Coordenada c = new Coordenada();
                    if (SelectedIndex != -1) index = SelectedIndex;
                    double x = double.Parse(xTextBox.Text.Replace(".", ","));
                    double y = double.Parse(yTextBox.Text.Replace(".", ","));
                    c.CoorX = x;
                    c.CoorY = y;
                    Coordenadas.Remove(SelectedItem);
                    Coordenadas.Insert(index, c);
                    SelectedItem = null;
                    SelectedIndex = -1;
                }
                else
                {
                    xTextBox.Style = stR;
                    yTextBox.Style = stR;
                    xTextBox.Text = "";
                    yTextBox.Text = "";
                }
            }
        }

        private void btnDeSeleccionar_Click(object sender, RoutedEventArgs e)
        {
            SelectedItem = null;
            SelectedIndex = -1;
        }

        private void btnGenerar_Click(object sender, RoutedEventArgs e)
        {
            double x4 = 0, x3 = 0, x2 = 0, x = 0, c = 0;
            
            if (yCBox.Text.Length == 0) yCBox.Text = "0";
            if (yXBox.Text.Length == 0) yCBox.Text = "0";
            if (yX2Box.Text.Length == 0) yCBox.Text = "0";
            if (yX3Box.Text.Length == 0) yCBox.Text = "0";
            if (yX4Box.Text.Length == 0) yCBox.Text = "0";
            switch (GradoPolinomioSelected)
            {
                case 0:
                    return;
                case 1:
                    if (!_modelo.isTbValid(yXBox.Text, 1) && !_modelo.isTbValid(yCBox.Text, 1))
                    {
                        yXBox.Style = yCBox.Style = st; 
                        x = double.Parse(yXBox.Text.Replace(".", ","));
                        c = double.Parse(yCBox.Text.Replace(".", ","));
                        _x4value = _x3value = _x2value = 0;
                        _xvalue = x;
                        _cvalue = c;
                    } else
                    {
                        yXBox.Style = yCBox.Style = stR;
                        yXBox.Text = yCBox.Text = yX2Box.Text = yX3Box.Text = yX4Box.Text = "0";
                    }
                    break;
                case 2:
                    if (!_modelo.isTbValid(yXBox.Text, 1) && !_modelo.isTbValid(yCBox.Text, 1) && !_modelo.isTbValid(yX2Box.Text, 1))
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style =st;
                        try
                        {
                            x2 = double.Parse(yX2Box.Text.Replace(".", ","));
                            x = double.Parse(yXBox.Text.Replace(".", ","));
                            c = double.Parse(yCBox.Text.Replace(".", ","));
                        } catch (Exception) { }
                        
                        _x4value = _x3value = 0;
                        _x2value = x2;
                        _xvalue = x;
                        _cvalue = c;
                    }
                    else
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style = stR;
                        yXBox.Text = yCBox.Text = yX2Box.Text = yX3Box.Text = yX4Box.Text = "0";
                    }
                    break;
                case 3:
                    if (!_modelo.isTbValid(yXBox.Text, 1) && !_modelo.isTbValid(yCBox.Text, 1) && !_modelo.isTbValid(yX2Box.Text, 1) && !_modelo.isTbValid(yX3Box.Text, 1))
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style = yX3Box.Style = st;
                        x3 = double.Parse(yX3Box.Text.Replace(".", ","));
                        x2 = double.Parse(yX2Box.Text.Replace(".", ","));
                        x = double.Parse(yXBox.Text.Replace(".", ","));
                        c = double.Parse(yCBox.Text.Replace(".", ","));
                        _x4value = 0;
                        _x3value = x3;
                        _x2value = x2;
                        _xvalue = x;
                        _cvalue = c;
                    }
                    else
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style = yX3Box.Style = stR;
                        yXBox.Text = yCBox.Text = yX2Box.Text = yX3Box.Text = yX4Box.Text = "0";
                    }
                    break;
                case 4:
                    if (!_modelo.isTbValid(yXBox.Text, 1) && !_modelo.isTbValid(yCBox.Text, 1) && !_modelo.isTbValid(yX2Box.Text, 1) && !_modelo.isTbValid(yX3Box.Text, 1) && !_modelo.isTbValid(yX4Box.Text, 1))
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style = yX3Box.Style = yX4Box.Style = st;
                        x4 = double.Parse(yX4Box.Text.Replace(".", ","));
                        x3 = double.Parse(yX3Box.Text.Replace(".", ","));
                        x2 = double.Parse(yX2Box.Text.Replace(".", ","));
                        x = double.Parse(yXBox.Text.Replace(".", ","));
                        c = double.Parse(yCBox.Text.Replace(".", ","));
                        _x4value = x4;
                        _x3value = x3;
                        _x2value = x2;
                        _xvalue = x;
                        _cvalue = c;
                    }
                    else
                    {
                        yXBox.Style = yCBox.Style = yX2Box.Style = yX3Box.Style = yX4Box.Style = stR;
                        yXBox.Text = yCBox.Text = yX2Box.Text = yX3Box.Text = yX4Box.Text = "0";
                    }
                    break;
            }
            if (Coordenadas != null || Coordenadas.Count > 0)
            {
                Coordenadas.Clear();
                Puntos.Clear();
            }
            for (double xv = XRangoMin; xv < XRangoMax; xv+=0.2)
            {
                Coordenada c1 = new Coordenada();
                c1.CoorX = xv;
                c1.CoorY = (_x4value * (Math.Pow(xv,4))) + (_x3value * (Math.Pow(xv, 3))) + (_x2value * (Math.Pow(xv, 2))) + (_xvalue * xv) + _cvalue;
                Coordenadas.Add(c1);
            }
             yXBox.Text = yCBox.Text = yX2Box.Text = yX3Box.Text = yX4Box.Text = "0";
            _x4value = _x3value = _x2value = _xvalue = _cvalue = 0;
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedItem != null)
            {
                Coordenadas.Remove(SelectedItem);
            }
        }

        private void rangeSlider_HigherValueChanged(object sender, RoutedEventArgs e)
        {
            XRangoMax = rangeSlider.HigherValue;
            xrangoMax.Text = XRangoMax.ToString();
        }

        private void rangeSlider_LowerValueChanged(object sender, RoutedEventArgs e)
        {
            XRangoMin = rangeSlider.LowerValue;
            xrangoMin.Text = XRangoMin.ToString();
        }

        private void cbGradoPolinomio_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GradoPolinomioSelected = cbGradoPolinomio.SelectedIndex;
            switch (GradoPolinomioSelected)
            {
                case 0:
                    x_Text.Visibility = x4Text.Visibility = x3Text.Visibility = x2Text.Visibility = cText.Visibility = Visibility.Collapsed;
                    yX4Box.Visibility = yX3Box.Visibility = yX2Box.Visibility = yCBox.Visibility = yXBox.Visibility = Visibility.Collapsed;
                    yX4Box.Text = yX3Box.Text = yX2Box.Text = yCBox.Text = yXBox.Text = "";
                    break;
                case 1:
                    x_Text.Visibility = cText.Visibility = yXBox.Visibility = yCBox.Visibility = Visibility.Visible;
                    break;
                case 2:
                    x2Text.Visibility = yX2Box.Visibility = x_Text.Visibility = cText.Visibility = yXBox.Visibility = yCBox.Visibility = Visibility.Visible;
                    break;
                case 3:
                    x3Text.Visibility = yX3Box.Visibility = x2Text.Visibility = yX2Box.Visibility = x_Text.Visibility = cText.Visibility = yXBox.Visibility = yCBox.Visibility = Visibility.Visible;
                    break;
                case 4:
                    x4Text.Visibility = yX4Box.Visibility = x3Text.Visibility = yX3Box.Visibility = x2Text.Visibility = yX2Box.Visibility = x_Text.Visibility = cText.Visibility = yXBox.Visibility = yCBox.Visibility = Visibility.Visible;
                    break;
            }

        }

        private void btnLimpiar_Click(object sender, RoutedEventArgs e)
        {
            if (Coordenadas != null)
            {
                Coordenadas.Clear();
                Puntos.Clear();
            }
        }
    }
}
