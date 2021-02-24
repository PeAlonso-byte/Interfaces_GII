using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Interfaces_GII
{
    public class Modelo
    {
        public Modelo()
        {

        }

        public bool isTbValid (String value, int mode)
        {
            double valor;
            
            if (value == null || value.Length == 0 && mode == 0) return true;
            try
            {
                if (value.Length == 0) value = "0"; 
                value = value.Replace(".", ",");
                var array = value.Split(',');
                if (array.Length > 2) return true;
                valor = double.Parse(value);
                return false;
            } catch (Exception)
            {
                return true;
            }
        }
        public static void SortDataGrid(DataGrid dataGrid, int columnIndex = 0, ListSortDirection sortDirection = ListSortDirection.Ascending)
        {
            var column = dataGrid.Columns[columnIndex];

            // Clear current sort descriptions
            dataGrid.Items.SortDescriptions.Clear();

            // Add the new sort description
            dataGrid.Items.SortDescriptions.Add(new SortDescription(column.SortMemberPath, sortDirection));

            // Apply sort
            foreach (var col in dataGrid.Columns)
            {
                col.SortDirection = null;
            }
            column.SortDirection = sortDirection;

            // Refresh items to display sort
            dataGrid.Items.Refresh();
        }
    }
}
