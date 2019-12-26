using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace MatMag
{
    /// <summary>
    /// Interaktionslogik für cardOrder.xaml
    /// </summary>
    public partial class cardOrder : UserControl
    {


        private double lenght;
        private int previousInput = 1;
        private int position = 1;
        public cardOrder()
        {
            InitializeComponent();
         
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid.Columns[4].Width = dataGrid.Columns[1].Width;
        }

        private void Grid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
           
        }

        private void DataGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //dataGrid.Columns[4].Width = dataGrid.Columns[1].Width;
        }

        private void DataGrid_LayoutUpdated(object sender, EventArgs e)
        {
            lenght = dataGrid.ActualWidth - dataGrid.Columns[0].ActualWidth - dataGrid.Columns[1].ActualWidth - dataGrid.Columns[2].ActualWidth - dataGrid.Columns[3].ActualWidth - 2;
            if (lenght > 80)
            {
                dataGrid.Columns[4].Width = lenght;
            }
            
        }

     

        private void TextBox1_Copy6_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            DateTimePicker t = new DateTimePicker();
            t.Show();

        }
    }
}
