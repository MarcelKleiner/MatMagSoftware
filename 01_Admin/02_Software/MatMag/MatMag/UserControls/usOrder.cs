using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MatMag
{
    public partial class usOrder : UserControl
    {
        public usOrder()
        {
            InitializeComponent();
            listView1.Columns[1].Width = -2;
        }

        private void CmdNewOrder_Click(object sender, EventArgs e)
        {

        }


        private void ListView1_Resize(object sender, EventArgs e)
        {
          //  listView1.Columns[listView1.Columns.Count-1].Width = -2;
        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void Button6_Click(object sender, EventArgs e)
        {
   
        }
    }
}
