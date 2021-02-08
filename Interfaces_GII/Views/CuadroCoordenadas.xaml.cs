using System;
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
using System.Windows.Shapes;
using Interfaces_GII.ViewModels;

namespace Interfaces_GII.Views
{
    /// <summary>
    /// Lógica de interacción para PruebaVentana.xaml
    /// </summary>
    public partial class CuadroCoordenadas : Window
    {
        public CuadroCoordenadas(CoordViewModel cv)
        {

            DataContext = cv;
            InitializeComponent();
            gridCoord.ItemsSource = cv;
        }
    }
}
