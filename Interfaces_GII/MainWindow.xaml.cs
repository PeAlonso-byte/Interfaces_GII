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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Interfaces_GII.Views;
using Interfaces_GII.ViewModels;

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
            
        }
    }
}
