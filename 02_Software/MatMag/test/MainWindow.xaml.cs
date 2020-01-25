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

namespace test
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var dg = new DataGrid();
            this.MainGrid.Children.Add(dg);

            // create four columns here with same names as the DataItem's properties
            for (int i = 1; i <= 4; ++i)
            {
                var column = new DataGridTextColumn();
                column.Header = "Column" + i;
                column.Binding = new Binding("Column" + i);
                dg.Columns.Add(column);
            }

            // create and add two lines of fake data to be displayed, here
            dg.Items.Add(new DataItem { Column1 = "a.1", Column2 = "a.2", Column3 = "a.3", Column4 = "a.4" });
            dg.Items.Add(new DataItem { Column1 = "b.1", Column2 = "b.2", Column3 = "b.3", Column4 = "b.4" });
        }
    }

    public class DataItem
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
    }
}
