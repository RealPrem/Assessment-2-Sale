using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_2_Sale
{
    class SalesPerson
    {
        private string ID;
        private Sales[] SalesHistory;
        private int Count = 0;

        public SalesPerson(string ID)
        {
            this.ID = ID;
            SalesHistory = new Sales[1000];
        }
        public int GetCount()
        {
            return Count;
        }
        public string GetID()
        {
            return ID;
        }
        public void setSalesHistory(Sales s)
        {
            SalesHistory[Count] = s;
            Count += 1;
        }
        public double calcTotalSales()
        {
            double Total = 0;
            for (int i = 0; i < SalesHistory.Length; i += 1)
            {
                if (SalesHistory[i] != null)
                {
                    Total += (SalesHistory[i].GetValue() * SalesHistory[i].GetQuantity());
                }
                else
                {
                    break;
                }
            }
            return Total;
        }
        public Sales GetSalesHistory(int i)
        {
            return SalesHistory[i];
        }
    }
}
