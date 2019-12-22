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

        /// <summary>
        /// CmdOrder Eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdOrder.Background = darkBlue;
        }
        private void cmdOrder_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdOrder.Background = Brushes.Transparent;
        }
        private void cmdOrder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //ToDo
        }


        private void cmdArticle_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdArticle.Background = darkBlue;
        }
        private void cmdArticle_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdArticle.Background = Brushes.Transparent;
        }
        private void cmdArticle_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdBoxes_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdBoxes.Background = darkBlue;
        }
        private void cmdBoxes_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdBoxes.Background = Brushes.Transparent;
        }
        private void cmdBoxes_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdAddress_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdAddress.Background = darkBlue;
        }
        private void cmdAddress_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdAddress.Background = Brushes.Transparent;
        }
        private void cmdAddress_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdBill_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdBill.Background = darkBlue;
        }
        private void cmdBill_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdBill.Background = Brushes.Transparent;
        }
        private void cmdBill_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdHelp.Background = darkBlue;
        }
        private void cmdHelp_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdHelp.Background = Brushes.Transparent;
        }
        private void cmdHelp_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdUser_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdUser.Background = darkBlue;
        }
        private void cmdUser_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdUser.Background = Brushes.Transparent;
        }
        private void cmdUser_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void cmdSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.cmdSettings.Background = darkBlue;
        }
        private void cmdSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.cmdSettings.Background = Brushes.Transparent;
        }
        private void cmdSettings_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }



        private void mainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if(mainWindow.Width < 1000)
            {
                mainWindow.gridMain.ColumnDefinitions[1].Width = new GridLength(20);
            }
            else
            {
                mainWindow.gridMain.ColumnDefinitions[1].Width = new GridLength(160);
            }
        }
    }
}
