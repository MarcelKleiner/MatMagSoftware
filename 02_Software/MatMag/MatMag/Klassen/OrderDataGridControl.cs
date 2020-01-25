//Additional using statements
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace MatMag.Klassen
{
    class OrderDataGridControl
    {
        private cardOrder cardOrder;
         


        public OrderDataGridControl(cardOrder cardOrder)
        {
            this.cardOrder = cardOrder;

            Customer ct = new Customer();
            ct.BestellNr = 100;
            ct.name = "hans";
            ct.Vorname = "Peter";

            var data = new Customer { name = "Test1", Vorname = "Test2" , BestellNr = 100};


            //Bind the DataGrid to the customer data
            cardOrder.dataGrid.Items.Add(data);
            cardOrder.dataGrid.Items.Add(data);
            cardOrder.dataGrid.Items.Add(data);
            cardOrder.dataGrid.Items.Add(data);


        }

    }



    public class Customer
    {
        public string name { get; set; }
        public string Vorname { get; set; }
        public int BestellNr { get; set; }
    }

}
