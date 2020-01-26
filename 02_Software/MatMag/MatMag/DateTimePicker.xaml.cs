using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace MatMag
{
    /// <summary>
    /// Interaktionslogik für DateTimePicker.xaml
    /// </summary>
    public partial class DateTimePicker : Window
    {
        private readonly int actualTimeMinute;
        private readonly int actualTimeHour;

        private readonly List<Label> hourLblList = new List<Label>();
        private readonly List<Label> minuteLblList = new List<Label>();

        private String selectedDate;

        public DateTimePicker()
        {
            InitializeComponent();
            //Akutelles Datum ermitteln
            actualTimeHour = DateTime.Now.Hour;
            //aktuelle minute auf 5minuten Runden
            actualTimeMinute = Convert.ToInt32(Math.Round(((double)DateTime.Now.Minute / 5), 0) * 5);

            //Stunden Label in liste eintragen und initialisieren
            hourLblList.Add(lblHr0);
            hourLblList.Add(lblHr1);
            hourLblList.Add(lblHr2);
            hourLblList.Add(lblHr3);
            hourLblList.Add(lblHr4);
            hourLblList.Add(lblHr5);
            hourLblList.Add(lblHr6);
            HourChange(actualTimeHour);

            //Minuten Label in liste eintragen und initialisieren
            minuteLblList.Add(lblMin0);
            minuteLblList.Add(lblMin1);
            minuteLblList.Add(lblMin2);
            minuteLblList.Add(lblMin3);
            minuteLblList.Add(lblMin4);
            minuteLblList.Add(lblMin5);
            minuteLblList.Add(lblMin6);
            MinuteChange(actualTimeMinute);

            selectedDate = DateTime.Now.ToString("dd.MM.yyyy");

        }

        /// <summary>
        /// Stunden wechseln
        /// </summary>
        /// <param name="timeHour"> Aktuelle Zeit an auswahlposition</param>
        private void HourChange(int timeHour)
        {
            int hourCounter = 0;
            int hourPos0 = timeHour - 3;
            foreach(Label lbl in hourLblList)
            {
               if(timeHour - 3 < 0)
                {
                    if(hourPos0+hourCounter < 0)
                    {
                        lbl.Content = 24 + hourPos0+hourCounter;
                    }
                    else
                    {
                        lbl.Content = hourPos0 + hourCounter;
                    }
                }else if(timeHour + 3 > 23)
                {
                    if (hourPos0 + hourCounter > 23)
                    {
                        lbl.Content = timeHour - 27 + hourCounter;
                    }
                    else
                    {
                        lbl.Content = timeHour - 3 + hourCounter;
                    }
                }
                else
                {
                    lbl.Content = (hourPos0 + hourCounter);
                }

                if (Convert.ToInt32(lbl.Content) < 10)
                {
                    lbl.Content = "0" + lbl.Content;
                }
                hourCounter++;
            }
            lblTime.Content = lblHr3.Content + ":" + lblMin3.Content;
        }

        /// <summary>
        /// Minuten Wechsel
        /// </summary>
        /// <param name="timeMinute"></param>
        private void MinuteChange(int timeMinute)
        {
            int minuteCounter = 0;
            int minutePos0 = timeMinute - 15;
            foreach (Label lbl in minuteLblList)
            {
                if (timeMinute - 15 < 0)
                {
                    if (minutePos0 + minuteCounter*5 < 0)
                    {
                        lbl.Content = 60 + minutePos0 + minuteCounter*5;
                    }
                    else
                    {
                        lbl.Content = minutePos0 + minuteCounter*5;
                    }
                }
                else if (timeMinute + 15 > 55)
                {
                    if (minutePos0 + minuteCounter*5 > 55)
                    {
                        lbl.Content = timeMinute - 75 + minuteCounter*5;
                    }
                    else
                    {
                        lbl.Content = timeMinute - 15 + minuteCounter*5;
                    }
                }
                else
                {
                    lbl.Content = (minutePos0 + minuteCounter*5);
                }

                if (Convert.ToInt32(lbl.Content) < 10)
                {
                    lbl.Content = "0" + lbl.Content;
                }
                minuteCounter++;

            }
            lblTime.Content = lblHr3.Content + ":" + lblMin3.Content;
        }


        /// <summary>
        /// Stunden Grid Mouse Wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridMainHour_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if(e.Delta < 0)
            {
                HourChange(Convert.ToInt32(lblHr3.Content) + 1);
            }
            else
            {
                HourChange(Convert.ToInt32(lblHr3.Content) - 1);
            }
            
        }
        /// <summary>
        /// Minuten Grid Mouse Wheel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridMainMinute_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (e.Delta < 0)
            {
                MinuteChange(Convert.ToInt32(lblMin3.Content) + 5);
            }
            else
            {
                MinuteChange(Convert.ToInt32(lblMin3.Content) - 5);
            }
        }

        /// <summary>
        /// Frame Move
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }


        /// <summary>
        /// Stunden Click steuerung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LblHr0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr0.Content));
        }

        private void LblHr1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr1.Content));
        }

        private void LblHr2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr2.Content));
        }

        private void LblHr3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr3.Content));
        }

        private void LblHr4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr4.Content));
        }

        private void LblHr5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr5.Content));
        }

        private void LblHr6_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            HourChange(Convert.ToInt32(lblHr6.Content));
        }



        /// <summary>
        /// Minuten click steuerung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void LblMin0_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin0.Content));
        }

        private void LblMin1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin1.Content));
        }

        private void LblMin2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin2.Content));
        }

        private void LblMin3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin3.Content));
        }

        private void LblMin4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin4.Content));
        }

        private void LblMin5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin5.Content));
        }

        private void LblMin6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MinuteChange(Convert.ToInt32(lblMin6.Content));
        }





        //Fenster Steuerung OK/Abbrechen
        private void CmdCancle_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }

        private void CmdOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        /// <summary>
        /// Dialog Antwort (datum + zeit)
        /// </summary>
        public string Answert
        {
              get{ return selectedDate + "/" + lblTime.Content; }
        }

  
        /// <summary>
        /// Gewähltes Datum in Lable Speichern
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            this.selectedDate = (calendar.SelectedDate.Value).ToString("dd.MM.yyyy"); ;
            lblDate.Content = 
                calendar.SelectedDate.Value.Day + 
                " " +  CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(calendar.SelectedDate.Value.Month) + 
                " " + calendar.SelectedDate.Value.Year;
        }
    }
}
