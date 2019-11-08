using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatMag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            usOrder orderPanel = new usOrder();


            this.spcMainScreen.Panel2.Controls.Add(orderPanel);
            orderPanel.Visible = true;
            orderPanel.BringToFront();
            orderPanel.Dock = DockStyle.Fill;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width < 800 && this.WindowState != FormWindowState.Minimized)
            {
                spcMainScreen.SplitterDistance = 60;
                cmdAddress.Text = "";
                cmdArticle.Text = "";
                cmdUser.Text = "";
                cmdSettings.Text = "";
                cmdOrder.Text = "";
                cmdBox.Text = "";
            }
            else if(this.WindowState != FormWindowState.Minimized)
            {
                spcMainScreen.SplitterDistance = 180;
                cmdAddress.Text = "Adresse";
                cmdArticle.Text = "Artikel";
                cmdUser.Text = "Benutzer";
                cmdSettings.Text = "Einstellungen";
                cmdOrder.Text = "Bestellungen";
                cmdBox.Text = "Kisten";
            }

        }
    }
}
