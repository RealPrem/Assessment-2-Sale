using System;

namespace Assessment_2_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesPerson[] salesPeople = new SalesPerson[6];
            salesPeople[0] = new SalesPerson("100");
            salesPeople[1] = new SalesPerson("101");
            salesPeople[2] = new SalesPerson("102");
            salesPeople[0].setSalesHistory(new Sales("A100", 300.00, 10));
            salesPeople[0].setSalesHistory(new Sales("A200", 1000.00, 2));
            salesPeople[1].setSalesHistory(new Sales("A300", 2550.40, 10));
            Console.WriteLine(salesPeople[2].GetID());
            Console.WriteLine(salesPeople[0].GetCount());
            Console.WriteLine(salesPeople[1].GetSalesHistory(0).GetValue());
            Console.WriteLine(salesPeople[0].calcTotalSales());

            Console.WriteLine("HIGHEST");
            Highest(salesPeople);

        }
        public static string Highest(SalesPerson[] salesPeople)
        {
            double Highest;
            string Person = "";
            Highest = salesPeople[0].calcTotalSales();
            for (int i = 0; i < salesPeople.Length; i += 1)
            {
                if (salesPeople[i] == null)
                {
                    break;
                }
                if (salesPeople[i].calcTotalSales() > Highest)
                {
                    Console.WriteLine(salesPeople[i].GetID());
                    Console.WriteLine(salesPeople[i].calcTotalSales());

                    Highest = salesPeople[i].calcTotalSales();
                    Person = salesPeople[i].GetID();
                }
            }
            return Person;
        }
    }
}
