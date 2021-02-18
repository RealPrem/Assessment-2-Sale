using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2_Sale
{
    class Sales
    {
        private string ItemID;
        private double Value;
        private int Quantity;

        public Sales(string ItemID, double Value, int Quantity)
        {
            this.ItemID = ItemID;
            this.Value = Value;
            this.Quantity = Quantity;
        }
        public double GetValue()
        {
            return Value;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
    }
}
