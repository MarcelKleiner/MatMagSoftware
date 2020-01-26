using MatMag.Cards;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace MatMag.Klassen
{
    class CardControl
    {
        private readonly MainWindow mainWindow;

        private CardOrder cardOrder;
        private CardAddress cardAddress;
        private CardArticle cardArticle;




        private readonly Brush darkBlue = new SolidColorBrush(Color.FromRgb(16,24,106));
        private readonly Brush lightBlue = new SolidColorBrush(Color.FromRgb(99, 160, 222));
        private readonly Brush lightBlue1 = new SolidColorBrush(Color.FromRgb(47, 122, 196));

        private readonly  bool[] cmdClicked = new bool[10];

        public CardControl(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            AddEventHandler();
            AddCartControl();
        }


        private void AddCartControl()
        {
            cardOrder = new CardOrder();
            cardAddress = new CardAddress();
            cardArticle = new CardArticle();

            cardOrder.Height = Double.NaN;
            cardOrder.Width = Double.NaN;

            cardArticle.Height = Double.NaN;
            cardArticle.Width = Double.NaN;

            cardAddress.Height = Double.NaN;
            cardAddress.Width = Double.NaN;
            
            mainWindow.tabOrder.Children.Add(cardOrder);
            mainWindow.tabAddress.Children.Add(cardAddress);
            mainWindow.tabArticle.Children.Add(cardArticle);
        }


        private void AddEventHandler()
        {
            mainWindow.cmdOrder.MouseEnter += new MouseEventHandler(this.CmdOrder_MouseEnter);
            mainWindow.cmdOrder.MouseLeave += new MouseEventHandler(this.CmdOrder_MouseLeave);
            mainWindow.cmdOrder.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdOrder_MouseUp);

            mainWindow.cmdArticle.MouseEnter += new MouseEventHandler(this.CmdArticle_MouseEnter);
            mainWindow.cmdArticle.MouseLeave += new MouseEventHandler(this.CmdArticle_MouseLeave);
            mainWindow.cmdArticle.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdArticle_MouseUp);

            mainWindow.cmdBoxes.MouseEnter += new MouseEventHandler(this.CmdBoxes_MouseEnter);
            mainWindow.cmdBoxes.MouseLeave += new MouseEventHandler(this.CmdBoxes_MouseLeave);
            mainWindow.cmdBoxes.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdBoxes_MouseUp);

            mainWindow.cmdAddress.MouseEnter += new MouseEventHandler(this.CmdAddress_MouseEnter);
            mainWindow.cmdAddress.MouseLeave += new MouseEventHandler(this.CmdAddress_MouseLeave);
            mainWindow.cmdAddress.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdAddress_MouseUp);

            mainWindow.cmdBill.MouseEnter += new MouseEventHandler(this.CmdBill_MouseEnter);
            mainWindow.cmdBill.MouseLeave += new MouseEventHandler(this.CmdBill_MouseLeave);
            mainWindow.cmdBill.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdBill_MouseUp);

            mainWindow.cmdHelp.MouseEnter += new MouseEventHandler(this.CmdHelp_MouseEnter);
            mainWindow.cmdHelp.MouseLeave += new MouseEventHandler(this.CmdHelp_MouseLeave);
            mainWindow.cmdHelp.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdHelp_MouseUp);

            mainWindow.cmdUser.MouseEnter += new MouseEventHandler(this.CmdUser_MouseEnter);
            mainWindow.cmdUser.MouseLeave += new MouseEventHandler(this.CmdUser_MouseLeave);
            mainWindow.cmdUser.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdUser_MouseUp);

            mainWindow.cmdSettings.MouseEnter += new MouseEventHandler(this.CmdSettings_MouseEnter);
            mainWindow.cmdSettings.MouseLeave += new MouseEventHandler(this.CmdSettings_MouseLeave);
            mainWindow.cmdSettings.MouseLeftButtonUp += new MouseButtonEventHandler(this.CmdSettings_MouseUp);

            mainWindow.SizeChanged += new SizeChangedEventHandler(this.MainWindow_SizeChanged);
        }


        private void ResetCommand()
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
        private void CmdOrder_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[1])
            {
                mainWindow.cmdOrder.Background = darkBlue;
            }
        }
        private void CmdOrder_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[1])
            {
                mainWindow.cmdOrder.Background = Brushes.Transparent;
            }   
        }
        private void CmdOrder_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdOrder.Background = lightBlue1;
            cmdClicked[1] = true;
            mainWindow.tabControl.SelectedIndex = 0;
            //ToDo
        }


        private void CmdArticle_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[2])
            {
                mainWindow.cmdArticle.Background = darkBlue;
            }
        }
        private void CmdArticle_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[2])
            {
                mainWindow.cmdArticle.Background = Brushes.Transparent;
            }
        }
        private void CmdArticle_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdArticle.Background = lightBlue;
            cmdClicked[2] = true;
            mainWindow.tabControl.SelectedIndex = 1;
        }



        private void CmdBoxes_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[3])
                mainWindow.cmdBoxes.Background = darkBlue;
        }
        private void CmdBoxes_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[3])
                mainWindow.cmdBoxes.Background = Brushes.Transparent;
        }
        private void CmdBoxes_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdBoxes.Background = lightBlue;
            cmdClicked[3] = true;
            mainWindow.tabControl.SelectedIndex = 2;
        }



        private void CmdAddress_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[4])
                mainWindow.cmdAddress.Background = darkBlue;
        }
        private void CmdAddress_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[4])
                mainWindow.cmdAddress.Background = Brushes.Transparent;
        }
        private void CmdAddress_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdAddress.Background = lightBlue;
            cmdClicked[4] = true;
            mainWindow.tabControl.SelectedIndex = 3;
        }



        private void CmdBill_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[5])
                mainWindow.cmdBill.Background = darkBlue;
        }
        private void CmdBill_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[5])
                mainWindow.cmdBill.Background = Brushes.Transparent;
        }
        private void CmdBill_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdBill.Background = lightBlue;
            cmdClicked[5] = true;
            mainWindow.tabControl.SelectedIndex = 4;
        }



        private void CmdHelp_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[6])
                mainWindow.cmdHelp.Background = darkBlue;
        }
        private void CmdHelp_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[6])
                mainWindow.cmdHelp.Background = Brushes.Transparent;
        }
        private void CmdHelp_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdHelp.Background = lightBlue;
            cmdClicked[6] = true;
            mainWindow.tabControl.SelectedIndex = 5;
        }



        private void CmdUser_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[7])
                mainWindow.cmdUser.Background = darkBlue;
        }
        private void CmdUser_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[7])
                mainWindow.cmdUser.Background = Brushes.Transparent;
        }
        private void CmdUser_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdUser.Background = lightBlue;
            cmdClicked[7] = true;
            mainWindow.tabControl.SelectedIndex = 6;
        }



        private void CmdSettings_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[8])
                mainWindow.cmdSettings.Background = darkBlue;
        }
        private void CmdSettings_MouseLeave(object sender, MouseEventArgs e)
        {
            if (!cmdClicked[8])
                mainWindow.cmdSettings.Background = Brushes.Transparent;
        }
        private void CmdSettings_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ResetCommand();
            mainWindow.cmdSettings.Background = lightBlue;
            cmdClicked[8] = true;
            mainWindow.tabControl.SelectedIndex = 7;
        }



        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
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
