using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MatMag.Klassen
{
    class MainFrameControl
    {
        private MainWindow mainWindow;


        //GridTop steuerung
        private Point mainWindowSize = new Point(0, 0);
        private Point gridTopPosition = new Point(0, 0);
        private bool gridTopClick;

        //MainWindow steuerung Min/Max/Close
        private readonly Brush lightRed = new SolidColorBrush(Color.FromRgb(232, 17, 35));
        private readonly Brush lightGray = new SolidColorBrush(Color.FromRgb(230, 230, 230));
        private readonly ImageSource imgNormal = new BitmapImage(new Uri("Icon/Restore Window_64px.png", UriKind.Relative));
        private readonly ImageSource imgMaximize = new BitmapImage(new Uri("Icon/Maximize Window_64px.png", UriKind.Relative));


        public MainFrameControl(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            addEventHandler();
        }

        private void addEventHandler()
        {
            this.mainWindow.gridTop.MouseLeftButtonDown += new MouseButtonEventHandler(this.gridTop_MouseDown);
            this.mainWindow.gridTop.MouseMove += new MouseEventHandler(this.gridTop_MouseMove);

            this.mainWindow.cmdClose.MouseEnter += new MouseEventHandler(this.cmdClose_MouseEnter);
            this.mainWindow.cmdClose.MouseLeave += new MouseEventHandler(this.cmdClose_MouseLeave);
            this.mainWindow.cmdClose.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdClose_MouseUp);

            this.mainWindow.cmdMinMax.MouseEnter += new MouseEventHandler(this.cmdMinMax_MouseEnter);
            this.mainWindow.cmdMinMax.MouseLeave += new MouseEventHandler(this.cmdMinMax_MouseLeave);
            this.mainWindow.cmdMinMax.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdMinMax_MouseUp);

            this.mainWindow.cmdMinimize.MouseEnter += new MouseEventHandler(this.cmdMinimize_MouseEnter);
            this.mainWindow.cmdMinimize.MouseLeave += new MouseEventHandler(this.cmdMinimize_MouseLeave);
            this.mainWindow.cmdMinimize.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdMinimize_MouseUp);

            this.mainWindow.SizeChanged += new SizeChangedEventHandler(this.mainWindow_SizeChanged);

            this.mainWindow.cmdSearch.MouseEnter += new MouseEventHandler(this.cmdSearch_MouseEnter);
            this.mainWindow.cmdSearch.MouseLeave += new MouseEventHandler(this.cmdSearch_MouseLeave);
            this.mainWindow.cmdSearch.MouseLeftButtonUp += new MouseButtonEventHandler(this.cmdSearch_MouseUp);
            this.mainWindow.txtSearch.KeyDown += new KeyEventHandler(this.cmdSearch_KeyDown);

        }


        /// <summary>
        /// MainFrame Steuerung Close
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdClose_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.gridClose.Background = Brushes.Transparent;
        }
        private void cmdClose_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.gridClose.Background = lightRed;
        }
        private void cmdClose_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }


        /// <summary>
        /// MainWindow Steuerung MinMax
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinMax_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.gridMinMax.Background = lightGray;
        }
        private void cmdMinMax_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.gridMinMax.Background = Brushes.Transparent;
        }
        //Change WindowState depending on current Windowstate
        private void cmdMinMax_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (mainWindow.WindowState == WindowState.Maximized)
            {
                mainWindow.WindowState = WindowState.Normal;
            }
            else
            {
                mainWindow.WindowState = WindowState.Maximized;
            }
        }

        /// <summary>
        /// MainWindow Steuerung Minimize
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdMinimize_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.gridMinimize.Background = lightGray;
        }
        private void cmdMinimize_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.gridMinimize.Background = Brushes.Transparent;
        }
        private void cmdMinimize_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mainWindow.WindowState = WindowState.Minimized;
        }

        /// <summary>
        /// MainWindow size changed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (mainWindow.WindowState == WindowState.Maximized)
            {
                mainWindow.cmdMinMax.Source = imgNormal;
            }
            else if (mainWindow.WindowState == WindowState.Normal)
            {
                mainWindow.cmdMinMax.Source = imgMaximize;
            }
        }


        /// <summary>
        /// MainWindow Top Grid Steuerung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridTop_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (mainWindow.WindowState == WindowState.Maximized)
            {
                gridTopClick = true;
                mainWindow.Width = mainWindowSize.X;
                mainWindow.Height = mainWindowSize.Y;
                mainWindow.Left = e.GetPosition(mainWindow).X - mainWindowSize.X / 2;
                mainWindow.Top = e.GetPosition(mainWindow).Y - 20;
            }
            else
            {
                this.mainWindowSize.X = mainWindow.Width;
                this.mainWindowSize.Y = mainWindow.Height;
                if (e.ClickCount == 2)
                {
                    mainWindow.WindowState = WindowState.Maximized;
                }
            }
            mainWindow.DragMove();
        }

        private void gridTop_MouseMove(object sender, MouseEventArgs e)
        {
            if( gridTopClick)
            {
                mainWindow.WindowState = WindowState.Normal;
                gridTopClick = false;
            }
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                mainWindow.DragMove();
            }
            
        }

        /// <summary>
        /// MainWindow Search Steuerung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSearch_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.gridSearch.Background = lightGray;
        }
        private void cmdSearch_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.gridSearch.Background = Brushes.Transparent;
        }
        private void cmdSearch_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //Search methode
        }


        /// <summary>
        /// Search textbox key press Eventhandler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                MessageBox.Show("keyPrewsst");
            }   
        }



    }
}
