using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MatMag.Klassen
{
    class CardControl
    {
        private MainWindow mainWindow;

        private readonly Brush darkBlue = new SolidColorBrush(Color.FromRgb(16,24,106));
        private readonly Brush lightBlue = new SolidColorBrush(Color.FromRgb(99, 160, 222));
        private readonly Brush lightBlue1 = new SolidColorBrush(Color.FromRgb(47, 122, 196));

        private bool[] cmdClicked = new bool[10];

        public CardControl(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            addEventHandler();
        }


        private void addEventHandler()
        {
            mainWindow.cmdOrder.MouseEnter += new MouseEventHandler(this.cmdOrder_MouseEnter);
            mainWindow.cmdOrder.MouseLeave += new MouseEventHandler(this.cmdOrder_MouseLeave);
            mainWindow.cmdOrder.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdOrder_MouseUp);

            mainWindow.cmdArticle.MouseEnter += new MouseEventHandler(this.cmdArticle_MouseEnter);
            mainWindow.cmdArticle.MouseLeave += new MouseEventHandler(this.cmdArticle_MouseLeave);
            mainWindow.cmdArticle.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdArticle_MouseUp);

            mainWindow.cmdBoxes.MouseEnter += new MouseEventHandler(this.cmdBoxes_MouseEnter);
            mainWindow.cmdBoxes.MouseLeave += new MouseEventHandler(this.cmdBoxes_MouseLeave);
            mainWindow.cmdBoxes.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdBoxes_MouseUp);

            mainWindow.cmdAddress.MouseEnter += new MouseEventHandler(this.cmdAddress_MouseEnter);
            mainWindow.cmdAddress.MouseLeave += new MouseEventHandler(this.cmdAddress_MouseLeave);
            mainWindow.cmdAddress.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdAddress_MouseUp);

            mainWindow.cmdBill.MouseEnter += new MouseEventHandler(this.cmdBill_MouseEnter);
            mainWindow.cmdBill.MouseLeave += new MouseEventHandler(this.cmdBill_MouseLeave);
            mainWindow.cmdBill.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdBill_MouseUp);

            mainWindow.cmdHelp.MouseEnter += new MouseEventHandler(this.cmdHelp_MouseEnter);
            mainWindow.cmdHelp.MouseLeave += new MouseEventHandler(this.cmdHelp_MouseLeave);
            mainWindow.cmdHelp.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdHelp_MouseUp);

            mainWindow.cmdUser.MouseEnter += new MouseEventHandler(this.cmdUser_MouseEnter);
            mainWindow.cmdUser.MouseLeave += new MouseEventHandler(this.cmdUser_MouseLeave);
            mainWindow.cmdUser.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdUser_MouseUp);

            mainWindow.cmdSettings.MouseEnter += new MouseEventHandler(this.cmdSettings_MouseEnter);
            mainWindow.cmdSettings.MouseLeave += new MouseEventHandler(this.cmdSettings_MouseLeave);
            mainWindow.cmdSettings.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdSettings_MouseUp);

            mainWindow.SizeChanged += new SizeChangedEventHandler(this.mainWindow_SizeChanged);
        }


        private void resetCommand()
        {
            mainWindow.cmdOrder.Background = Brushes.Transparent;
            mainWindow.cmdArticle.Background = Brushes.Transparent;
            mainWindow.cmdBoxes.Background = Brushes.Transparent;
            mainWindow.cmdAddress.Background = Brushes.Transparent;
            mainWindow.cmdBill.Background = Brushes.Transparent;
            mainWindow.cmdHelp.Background = Brushes.Transparent;
            mainWindow.cmdUser.Background = Brushes.Transparent;
            mainWindow.cmdSettings.Background = Brushes.Transparent;
            for(int i = 0; i < 10; i++)
            {
                cmdClicked[i] = false;
            }
        }

        /// <summary>
        /// CmdOrder Eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[1])
            {
                mainWindow.cmdOrder.Background = darkBlue;
            }
        }
        private void cmdOrder_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[1])
            {
                mainWindow.cmdOrder.Background = Brushes.Transparent;
            }   
        }
        private void cmdOrder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdOrder.Background = lightBlue1;
            cmdClicked[1] = true;
            //ToDo
        }


        private void cmdArticle_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[2])
            {
                mainWindow.cmdArticle.Background = darkBlue;
            }
        }
        private void cmdArticle_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[2])
            {
                mainWindow.cmdArticle.Background = Brushes.Transparent;
            }
        }
        private void cmdArticle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdArticle.Background = lightBlue;
            cmdClicked[2] = true;
        }



        private void cmdBoxes_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[3])
                mainWindow.cmdBoxes.Background = darkBlue;
        }
        private void cmdBoxes_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[3])
                mainWindow.cmdBoxes.Background = Brushes.Transparent;
        }
        private void cmdBoxes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdBoxes.Background = lightBlue;
            cmdClicked[3] = true;
        }



        private void cmdAddress_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[4])
                mainWindow.cmdAddress.Background = darkBlue;
        }
        private void cmdAddress_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[4])
                mainWindow.cmdAddress.Background = Brushes.Transparent;
        }
        private void cmdAddress_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdAddress.Background = lightBlue;
            cmdClicked[4] = true;
        }



        private void cmdBill_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[5])
                mainWindow.cmdBill.Background = darkBlue;
        }
        private void cmdBill_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[5])
                mainWindow.cmdBill.Background = Brushes.Transparent;
        }
        private void cmdBill_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdBill.Background = lightBlue;
            cmdClicked[5] = true;
        }



        private void cmdHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[6])
                mainWindow.cmdHelp.Background = darkBlue;
        }
        private void cmdHelp_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[6])
                mainWindow.cmdHelp.Background = Brushes.Transparent;
        }
        private void cmdHelp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdHelp.Background = lightBlue;
            cmdClicked[6] = true;
        }



        private void cmdUser_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[7])
                mainWindow.cmdUser.Background = darkBlue;
        }
        private void cmdUser_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[7])
                mainWindow.cmdUser.Background = Brushes.Transparent;
        }
        private void cmdUser_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdUser.Background = lightBlue;
            cmdClicked[7] = true;
        }



        private void cmdSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[8])
                mainWindow.cmdSettings.Background = darkBlue;
        }
        private void cmdSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[8])
                mainWindow.cmdSettings.Background = Brushes.Transparent;
        }
        private void cmdSettings_MouseUp(object sender, MouseButtonEventArgs e)
        {
            resetCommand();
            mainWindow.cmdSettings.Background = lightBlue;
            cmdClicked[8] = true;
        }



        private void mainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(mainWindow.Width < 1000)
            {
                mainWindow.gridMain.ColumnDefinitions[1].Width = new GridLength(20);
                mainWindow.lblAddress.Content = "";
                mainWindow.lblArticle.Content = "";
                mainWindow.lblBill.Content = "";
                mainWindow.lblBox.Content = "";
                mainWindow.lblHelp.Content = "";
                mainWindow.lblOrder.Content = "";
                mainWindow.lblSettings.Content = "";
                mainWindow.lblUser.Content = "";
            }
            else
            {
                mainWindow.gridMain.ColumnDefinitions[1].Width = new GridLength(160);
                mainWindow.lblAddress.Content = "Adressen";
                mainWindow.lblArticle.Content = "Artikel";
                mainWindow.lblBill.Content = "Rechnung";
                mainWindow.lblBox.Content = "Kisten";
                mainWindow.lblHelp.Content = "Hilfe";
                mainWindow.lblOrder.Content = "Bestellung";
                mainWindow.lblSettings.Content = "Einstellungen";
                mainWindow.lblUser.Content = "Benutzer";
            }
        }
    }
}
