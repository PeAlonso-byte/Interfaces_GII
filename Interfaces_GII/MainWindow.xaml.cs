using System.Windows;
using Interfaces_GII.ViewModels;
using System.Collections.ObjectModel;
using Interfaces_GII.Model;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace Interfaces_GII
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CoordViewModel cv;
        public MainWindow()
        {
            cv = new CoordViewModel();
            DataContext = cv;
            InitializeComponent();
            //controlCanvas.ItemsSource = cv.Coordenadas;

        }

        public CoordViewModel ViewModel
        {
            get { return (CoordViewModel)DataContext; }
        }
    }
}
