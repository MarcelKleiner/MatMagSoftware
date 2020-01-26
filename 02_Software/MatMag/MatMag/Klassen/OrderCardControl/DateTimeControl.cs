using MatMag;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;



    class DateTimeControl
    {
        private readonly CardOrder cardOrderFrame;
        public DateTimeControl(CardOrder cardOrderFrame){
            this.cardOrderFrame = cardOrderFrame;

            cardOrderFrame.lblTimePickup.MouseLeftButtonDown += new MouseButtonEventHandler(this.LblTimePickup_MouseLeftButtonDown);
            cardOrderFrame.lblDatePickup.MouseLeftButtonDown += new MouseButtonEventHandler(this.LblDatePickup_MouseLeftButtonDown);

            cardOrderFrame.lblTimeReturn.MouseLeftButtonDown += new MouseButtonEventHandler(this.LblTimeReturn_MouseLeftButtonDown);
            cardOrderFrame.lblDateReturn.MouseLeftButtonDown += new MouseButtonEventHandler(this.LblDateReturn_MouseLeftButtonDown);

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
                cardOrderFrame.lblTimePickup.Content = t.Answert.Split('/')[1];
                string answertDate = t.Answert.Split('/')[0];
                string[] anwertDateSplit = answertDate.Split('.');
                cardOrderFrame.lblDatePickup.Content = anwertDateSplit[0] + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(anwertDateSplit[1])) + " " + anwertDateSplit[2];
            }
        }


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
                cardOrderFrame.lblTimeReturn.Content = t.Answert.Split('/')[1];
                string answertDate = t.Answert.Split('/')[0];
                string[] anwertDateSplit = answertDate.Split('.');
                cardOrderFrame.lblDateReturn.Content = anwertDateSplit[0] + " " + CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(Convert.ToInt32(anwertDateSplit[1])) + " " + anwertDateSplit[2];
            }
        }

    }

