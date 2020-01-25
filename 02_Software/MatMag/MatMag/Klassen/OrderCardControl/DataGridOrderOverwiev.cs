using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;

namespace MatMag.Klassen.oCardControl
{
    class DataGridOrderOverwiev
    {
        private readonly CardOrder cardOrder;
        private double lenght;
        private readonly ObservableCollection<DataGridColumn> dgColumn;
        public DataGridOrderOverwiev(CardOrder cardOrder)
        {
            this.cardOrder = cardOrder;
            this.dgColumn = cardOrder.dgOrderOverview.Columns;

            cardOrder.dgOrderOverview.LayoutUpdated += new EventHandler(this.DataGrid_LayoutUpdated);
            AddDataToGrid();
        }


        private void DataGrid_LayoutUpdated(object sender, EventArgs e)
        {
            lenght = cardOrder.dgOrderOverview.ActualWidth - dgColumn[0].ActualWidth - dgColumn[1].ActualWidth - dgColumn[2].ActualWidth - dgColumn[3].ActualWidth - 2;
            if (lenght > 80)
            {
                dgColumn[4].Width = lenght;
            }
        }



        public void AddDataToGrid()
        {

            for (int i = 1; i <= 4; ++i)
            {
                var column = new DataGridTextColumn();
                column.Header = "Column" + i;
                column.Binding = new Binding("Column" + i);
                cardOrder.dgOrderOverview.Columns.Add(column);
            }

            // create and add two lines of fake data to be displayed, here
            cardOrder.dgOrderOverview.Items.Add(new DGOverviewContent { name = "a.1", vorname = "a.2" });
            cardOrder.dgOrderOverview.Items.Add(new DGOverviewContent { name = "b.1", vorname = "b.2"});



            var data = new DGOverviewContent { name = "Test1", vorname = "Test2" };

            cardOrder.dgOrderOverview.Items.Add(data);
        }

    }

    public class DGOverviewContent
    {
        public string name { get; set; }
        public string vorname { get; set; }
    }
}
