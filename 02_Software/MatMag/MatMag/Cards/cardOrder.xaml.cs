using MahApps.Metro.Controls;
using MatMag.Klassen.oCardControl;
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
    public partial class CardOrder : UserControl
    {
        public CardOrder()
        {
            InitializeComponent();
            new DateTimeControl(this);
            new DataGridOrderOverwiev(this);
            new QuantityControl(this);
        }

       
    }
}
