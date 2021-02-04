using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Interfaces_GII
{
    /// <summary>
    /// Lógica de interacción para CuadroModal.xaml
    /// </summary>
    public partial class CuadroModal : Window
    {
        public ObservableCollection<Coordenadas> datos;
        public CuadroModal()
        {
            InitializeComponent();
            datos = new ObservableCollection<Coordenadas>();
            DataContext = this;
               
        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        public void cargaDatos ()
        {
            CustomerGrid.ItemsSource = datos;
        }

        private void btnAceptar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void CustomerGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            if (datos.Count == 0)
            {
                Coordenadas coor1 = new Coordenadas();
                
                //DataGridViewRow row = CustomerGrid.
                //string value = row.Cells["IPID"].Value.ToString();

            }
        }

        private void xTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var theKeyAsAString = e.Key.ToString();
            if (theKeyAsAString.Length > 1 && theKeyAsAString.Contains("D"))
            {
                theKeyAsAString = theKeyAsAString.Substring(1);
            }

            if (theKeyAsAString.Contains("Oem") || theKeyAsAString.Length > 2)
            {
                if (theKeyAsAString.Equals("OemPeriod"))
                {
                    theKeyAsAString = ".";
                } else
                {
                    theKeyAsAString = "D";
                }
            }
            var theKeyAsAChar = char.Parse(theKeyAsAString);
            if ((theKeyAsAChar == 46 && xTextBox.Text.IndexOf('.') != -1) || (theKeyAsAChar == 46 && xTextBox.Text.Length == 0))
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(theKeyAsAChar) && theKeyAsAChar != 8 && theKeyAsAChar != 46)
            {
                e.Handled = true;
            }
        }

        private void yTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            var theKeyAsAString = e.Key.ToString();
            if (theKeyAsAString.Length > 1 && theKeyAsAString.Contains("D"))
            {
                theKeyAsAString = theKeyAsAString.Substring(1);
            }

            if (theKeyAsAString.Contains("Oem") || theKeyAsAString.Length > 2)
            {
                if (theKeyAsAString.Equals("OemPeriod"))
                {
                    theKeyAsAString = ".";
                }
                else
                {
                    theKeyAsAString = "D";
                }
            }
            var theKeyAsAChar = char.Parse(theKeyAsAString);
            if ((theKeyAsAChar == 46 && yTextBox.Text.IndexOf('.') != -1) || (theKeyAsAChar == 46 && yTextBox.Text.Length == 0))
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(theKeyAsAChar) && theKeyAsAChar != 8 && theKeyAsAChar != 46)
            {
                e.Handled = true;
            }
        }

        private void btnAnadir_Click(object sender, RoutedEventArgs e)
        {
            if (xTextBox.Text.Length != 0 && yTextBox.Text.Length != 0)
            {
                double x = double.Parse(xTextBox.Text.Replace(".", ","));
                double y = double.Parse(yTextBox.Text.Replace(".", ","));

                Coordenadas c = new Coordenadas();
                c.coorX = x;
                c.coorY = y;

                datos.Add(c);
                xTextBox.Text = "";
                yTextBox.Text = "";
                cargaDatos();
                
            } else
            {
                if (xTextBox.Text.Length == 0)
                {
                    
                }
            }
        }
    }
}
