using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Interfaces_GII
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ancho, alto;
        Polyline linea, lineaX, lineaY;
        private CuadroCoordenadas cuadroCoordenadas;
        private SolidColorBrush brush;
        private Color color1, color2;
        private ObservableCollection<Coordenada> _coordenadas;
        private PointCollection _puntos;

        private double _xrealMax;
        private double _yrealMax;
        private double _xISeleccion;
        private double _yISeleccion;
        private double _xFSeleccion;
        private double _yFSeleccion;


        public double XISeleccion
        {
            get
            {
                return _xISeleccion;
            }
            set
            {
                _xISeleccion = value;
            }
        }
        public double YISeleccion
        {
            get
            {
                return _yISeleccion;
            }
            set
            {
                _yISeleccion = value;
            }
        }
        public double XFSeleccion
        {
            get
            {
                return _xFSeleccion;
            }
            set
            {
                _xFSeleccion = value;
            }
        }
        public double YFSeleccion
        {
            get
            {
                return _yFSeleccion;
            }
            set
            {
                _yFSeleccion = value;
            }
        }
        
        public double XRealMax
        {
            get
            {
                if (_coordenadas != null && _coordenadas.Count > 0)
                {
                    _yrealMax = 0;
                    _xrealMax = 0;
                    foreach (Coordenada c in _coordenadas)
                    {
                        if (Math.Abs(c.CoorX) > _xrealMax) _xrealMax = Math.Abs(c.CoorX);
                        if (Math.Abs(c.CoorY) > _yrealMax) _yrealMax = Math.Abs(c.CoorY);
                    }
                }
                return _xrealMax;
            }
            set
            {
                _xrealMax = value;
            }
        }
        public double YRealMax
        {
            get
            {
                if (XRealMax == 0) return 0;
                return _yrealMax;
            }
            set
            {
                _yrealMax = value;
            }
        }
        public double YRealMin
        {
            get
            {
                if (XRealMax == 0) return 0;
                return -_yrealMax;
            }
        }
        public double XRealMin
        {
            get
            {
                if (XRealMax == 0) return 0;
                return -_xrealMax;
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
        public MainWindow()
        {
            InitializeComponent();
            ancho = miCanvas.ActualWidth;
            alto = miCanvas.ActualHeight;
            linea = null;
            lineaX = null;
            lineaY = null;
            color1 = (Color)ColorConverter.ConvertFromString("#eaecff");
            color2 = (Color)ColorConverter.ConvertFromString("#3a3d57");
            brush = new SolidColorBrush(color1);
            Coordenadas.CollectionChanged += this.OnCollectionChanged;
        }

        /* METODOS PARA DIBUJAR LA GRAFICA */
        void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            obtenerCoordenadas(Coordenadas);
            miCanvas.Children.Clear();
            if (MEjes.Header.Equals("Ejes-On"))
            {
                dibuja_ejes();
            }
            //dibujaBarras();
            if (MTipo.Header.Equals("Puntos"))
            {
                dibujaBarras();
            }
            else
            {
                dibujaPuntos();
            }
            
        }
        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            miCanvas.Children.Clear();
            ancho = miCanvas.ActualWidth;
            alto = miCanvas.ActualHeight;
            obtenerCoordenadas(Coordenadas);
            if ((MEjes.Header.Equals("Ejes-On")))
            {
                dibuja_ejes();
            }
            if (MTipo.Header.Equals("Puntos"))
            {
                dibujaBarras();
            } else
            {
                dibujaPuntos();
            }
        }

        private void MTipo_Click(object sender, RoutedEventArgs e)
        {
            miCanvas.Children.Clear();
            obtenerCoordenadas(Coordenadas);
            if (MEjes.Header.Equals("Ejes-On")) dibuja_ejes();
            if (MTipo.Header.Equals("Puntos"))
            {
                
                MTipo.Header = "Polilinea";
                if (Coordenadas == null || Coordenadas.Count == 0) return;
                dibujaPuntos();
            } else
            {
                MTipo.Header = "Puntos";
                if (Coordenadas == null || Coordenadas.Count == 0) return;
                dibujaBarras();
            }
        }

        private void MEjes_Click(object sender, RoutedEventArgs e)
        {
            var menuItem = (MenuItem)e.OriginalSource;
            if (menuItem.Header.Equals("Ejes-Off"))
            {
                dibuja_ejes();
                menuItem.Header = "Ejes-On";
            } else
            {
                miCanvas.Children.Remove(lineaX);
                miCanvas.Children.Remove(lineaY);
                menuItem.Header = "Ejes-Off";
            }
        }

        private void dibujaBarras()
        {
            brush = new SolidColorBrush(color1);
            obtenerCoordenadas(Coordenadas);
            foreach (Coordenada c in Coordenadas)
            {
                Line barra = new Line();
                barra.Stroke = brush;
                barra.StrokeThickness = 2;
                barra.X1 = c.CoorXPant;
                barra.Y1 = alto / 2;
                barra.X2 = c.CoorXPant;
                barra.Y2 = c.CoorYPant;
                miCanvas.Children.Add(barra);
            }
           // miCanvas.Children.Add(linea);
        }
        private void dibujaPuntos()
        {
            brush = new SolidColorBrush(color1);
            if (linea == null)
            {
                linea = new Polyline();
                linea.Stroke = brush;
                linea.StrokeThickness = 2;

            } else
            {
                linea.Points.Clear();
            }
            foreach (Point p in Puntos)
            {
                linea.Points.Add(p);
            }
            miCanvas.Children.Add(linea);
        }

        private void MOrdenar_Click(object sender, RoutedEventArgs e)
        {
            if (cuadroCoordenadas != null)
            Modelo.SortDataGrid(cuadroCoordenadas.CustomerGrid);
            for (int i = 0; i <= Coordenadas.Count - 1; i++)
            {
                for (int j = 0; j < Coordenadas.Count - i - 1; j++)
                {
                    if ((Coordenadas[j].CoorX) > (Coordenadas[j + 1].CoorX))
                    {
                        Coordenada tem = Coordenadas[j];
                        Coordenadas[j] = Coordenadas[j + 1];
                        Coordenadas[j + 1] = tem;
                    }
                }
            }
        }

        private void miCanvas_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var position = e.GetPosition(miCanvas);
            XISeleccion = position.X;
            YISeleccion = position.Y;

        }

        private void miCanvas_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            var position = e.GetPosition(miCanvas);
            XFSeleccion = position.X;
            YFSeleccion = position.Y;

            if (Coordenadas != null && Coordenadas.Count > 0)
            {
                double maxX = (XFSeleccion > XISeleccion) ? XFSeleccion : XISeleccion;
                double maxY = (YFSeleccion > YISeleccion) ? YFSeleccion : YISeleccion;
                double minX = (XFSeleccion < XISeleccion) ? XFSeleccion : XISeleccion;
                double minY = (YFSeleccion < YISeleccion) ? YFSeleccion : YISeleccion;
                ObservableCollection<Coordenada> _aux = new ObservableCollection<Coordenada>();
                foreach (Coordenada c in Coordenadas)
                {
                    if (!(c.CoorXPant > maxX || c.CoorXPant < minX) || !(c.CoorYPant < minY || c.CoorYPant > maxY))
                    {
                        _aux.Add(c);
                    }
                }
                Coordenadas.Clear();
                Puntos.Clear();
                foreach (Coordenada c in _aux)
                {
                    Coordenadas.Add(c);
                }
            }
        }

        private void MOscuro_Click(object sender, RoutedEventArgs e)
        {

        }

        private void obtenerCoordenadas(ObservableCollection<Coordenada> lista)
        {
            if (Coordenadas == null || Coordenadas.Count == 0) return;
            Puntos.Clear();
            foreach (Coordenada c in lista)
            {
                c.CoorXPant = (miCanvas.ActualWidth - 0) * ((c.CoorX - XRealMin) / (XRealMax - XRealMin));
                c.CoorYPant = (0 - miCanvas.ActualHeight) * ((c.CoorY - YRealMin) / (YRealMax - YRealMin)) + miCanvas.ActualHeight;

                Puntos.Add(new Point(c.CoorXPant, c.CoorYPant));
            }
        }

        private void dibuja_ejes()
        {
            Point p;
            double x;
            brush = new SolidColorBrush(color2);
            ancho = miCanvas.ActualWidth;
            alto = miCanvas.ActualHeight;
            if (lineaX == null)
            {
                lineaX = new Polyline();
                lineaX.Stroke = brush;
                lineaX.StrokeThickness = 2;

            }
            else
            {
                lineaX.Points.Clear();
            }
            for (x = 0; x <= ancho; x++)
            {
                p = new Point();
                p.X = x;
                p.Y = alto / 2;
                lineaX.Points.Add(p);
                
            }

            if (lineaY == null)
            {
                lineaY = new Polyline();
                lineaY.Stroke = brush;
                lineaY.StrokeThickness = 2;

            }
            else
            {
                lineaY.Points.Clear();
            }
            for (x = 0; x <= ancho; x++)
            {
                p = new Point();
                p.X = ancho / 2;
                p.Y = x;
                lineaY.Points.Add(p);

            }
            if (!miCanvas.Children.Contains(lineaX)) miCanvas.Children.Add(lineaX);
            if (!miCanvas.Children.Contains(lineaY)) miCanvas.Children.Add(lineaY);
        }

        /* FIN METODOS PARA DIBUJAR LA GRAFICA */

        /* METODOS CUADRO MODAL */
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == CDCoordenadas)
            {
                if (cuadroCoordenadas != null)
                {
                    return;
                }

                cuadroCoordenadas = new CuadroCoordenadas(Coordenadas, Puntos);
                cuadroCoordenadas.Owner = this;
                cuadroCoordenadas.Closed += Cdnm_Closed;
                cuadroCoordenadas.Show();
            }
        }
        private void Cdnm_Closed(object sender, EventArgs e)
        {
            cuadroCoordenadas = null;
        }
        /* FIN METODOS CUADRO MODAL */
    }
}
