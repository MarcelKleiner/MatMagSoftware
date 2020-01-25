using MahApps.Metro.Controls;
using MatMag.Klassen;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        private int quantity;

        public cardOrder()
        {
            InitializeComponent();

            new OrderDataGridControl(this);
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            dataGrid.Columns[4].Width = dataGrid.Columns[1].Width;
        }

        private void DataGrid_LayoutUpdated(object sender, EventArgs e)
        {
            lenght = dataGrid.ActualWidth - dataGrid.Columns[0].ActualWidth - dataGrid.Columns[1].ActualWidth - dataGrid.Columns[2].ActualWidth - dataGrid.Columns[3].ActualWidth - 2;
            if (lenght > 80)
            {
                dataGrid.Columns[4].Width = lenght;
            }
            
        }



        private void LblTimePickup_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTimePickuptChanged();
        }
        private void LblDatePickup_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTimePickuptChanged();
        }

        private void DateTimePickuptChanged()
        {
            DateTimePicker t = new DateTimePicker();
            t.ShowDialog();
            if ((bool)t.DialogResult)
            {
                lblTimePickup.Content = t.Answert.Split('/')[1];
                string answertDate = t.Answert.Split('/')[0];
               string[] anwertDateSplit = answertDate.Split('.');
                lblDatePickup.Content = anwertDateSplit[0] + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(anwertDateSplit[1])) + " " + anwertDateSplit[2];
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblTimeReturn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTimeReturnChanged();
        }

        private void LblDateReturn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTimeReturnChanged();
        }


        private void DateTimeReturnChanged()
        {
            DateTimePicker t = new DateTimePicker();
            t.ShowDialog();
            if ((bool)t.DialogResult)
            {
                lblTimeReturn.Content = t.Answert.Split('/')[1];
                string answertDate = t.Answert.Split('/')[0];
                string[] anwertDateSplit = answertDate.Split('.');
                lblDateReturn.Content = anwertDateSplit[0] + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(anwertDateSplit[1])) + " " + anwertDateSplit[2];
            }
        }

        private void LblDatePickup_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
        }


        private void CmdQuantityUp_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
            txtQuantity.Text = Convert.ToString(quantity + 1);
        }

        private void CmdQuantityDown_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
            if (quantity > 0)
            {
                txtQuantity.Text = Convert.ToString(quantity - 1);
            }
        }

        private void Image2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
        }

        private void CmdQuantityUp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
