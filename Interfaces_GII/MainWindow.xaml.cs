﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
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
        private CuadroModal cdm;
        public MainWindow()
        {
            InitializeComponent();
            ancho = 0;
            alto = 0;
            linea = null;
            lineaX = null;
            lineaY = null;
            cdm = null;
        }

        /* METODOS PARA DIBUJAR LA GRAFICA */
        private void btnDibujo_Click(object sender, RoutedEventArgs e)
        {
            if ((String)btnDibujo.Content == "Dibujar")
            {
                dibuja();
                dibuja_ejes();
                btnDibujo.Content = "Limpiar";
            }
            else
            {
                miCanvas.Children.Clear();
                btnDibujo.Content = "Dibujar";
            }
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (linea != null)
            {
                if ((String)btnDibujo.Content == "Limpiar")
                {
                    miCanvas.Children.Clear();
                    dibuja();
                    dibuja_ejes();
                }
            }
        }

        private void dibuja()
        {
            Point p;
            double x;

            ancho = miCanvas.ActualWidth;
            alto = miCanvas.ActualHeight;

            if (linea == null)
            {
                linea = new Polyline();
                linea.Stroke = Brushes.Red;
                linea.StrokeThickness = 2;

            }
            else
            {
                linea.Points.Clear();
            }

            for (x = -ancho / 2 + ancho / 22; x <= ancho / 2 - ancho / 22; x++)
            {
                p = new Point();
                p.X = x + ancho / 2;
                p.Y = alto * (100 - ((x * 22 / ancho) * (x * 22 / ancho))) / 110;
                linea.Points.Add(p);
            }

            miCanvas.Children.Add(linea);
        }

        private void dibuja_ejes()
        {
            Point p;
            double x;

            ancho = miCanvas.ActualWidth;
            alto = miCanvas.ActualHeight;
            if (lineaX == null)
            {
                lineaX = new Polyline();
                lineaX.Stroke = Brushes.Black;
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
                lineaY.Stroke = Brushes.Black;
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

            miCanvas.Children.Add(lineaX);
            miCanvas.Children.Add(lineaY);

        }

        /* FIN METODOS PARA DIBUJAR LA GRAFICA */

        /* METODOS CUADRO MODAL */
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            if (sender == CDModal)
            {
                cdm = new CuadroModal();
                cdm.Owner = this; // Propietario ventana principal.
                cdm.ShowDialog();

                if (cdm.DialogResult == true)
                { 
                 // Cuando aceptas
                }
            }
        }
        /* FIN METODOS CUADRO MODAL */
    }
}
