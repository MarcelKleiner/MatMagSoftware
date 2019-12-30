using System;
using System.Windows;
using System.Windows.Input;

namespace MatMag.Klassen.oCardControl
{
    class QuantityControl
    {
        private int quantity = 1;
        private readonly CardOrder cardOrder;

        public QuantityControl(CardOrder cardOrder)
        {
            this.cardOrder = cardOrder;
          //  cardOrder.cmdQuantityUp.Click += new RoutedEventHandler(this.CmdQuantityUp_EventHandler);
          // cardOrder.cmdQuantityDown.Click += new RoutedEventHandler(this.CmdQuantityDown_EventHandler);
          //  cardOrder.txtQuantity.PreviewKeyDown += new KeyEventHandler(this.TxtQuantity_PreviewKeyDown);
        }

        /// <summary>
        /// up Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdQuantityUp_EventHandler(object sender, RoutedEventArgs e)
        {
          //  cardOrder.txtQuantity.Text = Convert.ToString(++quantity);
        }

        /// <summary>
        /// down Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmdQuantityDown_EventHandler(object sender, RoutedEventArgs e)
        {
            if (quantity > 1)
            {
              //  cardOrder.txtQuantity.Text = Convert.ToString(--quantity);
            }
        }

        /// <summary>
        /// PreviewKeyDown
        /// Erlaubt nur Zahlen von NumerBlock & 10er Block und den Buchstaben D für diverses
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtQuantity_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key >= (Key)74 && e.Key <= (Key)83 || e.Key >= (Key)34 && e.Key <= (Key)43 || e.Key == Key.D)
            {
                /*
                e.Handled = false;
                if (cardOrder.txtQuantity.Text == "Diverse")
                {
                    cardOrder.txtQuantity.Text = "";
                }
                if (e.Key == Key.D)
                {
                    cardOrder.txtQuantity.Text = "Diverse";
                    quantity = 1;
                    e.Handled = true;
                }
                */
            }
            else
            {
                e.Handled = true;
            }
        }




    }
}
