#region Copyright Syncfusion Inc. 2001 - 2019.
// Copyright Syncfusion Inc. 2001 - 2019. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace VisualStylesDemo
{
    using System;
    using System.Collections.Generic;

    #region Product Sales

    public class ProductSales
    {
        public string Product { get; set; }

        public string Date { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public int Quantity { get; set; }

        public double Amount { get; set; }

        public double UnitPrice { get; set; }

        public double TotalPrice { get; set; }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}", Country, State, Product);
        }
    }

    #endregion

    #region Product Sales Collection

    public class ProductSalesCollection : List<ProductSales>
    {
    }

    #endregion

    #region ProductSalesData

    class ProductSalesData
    {
        public static ProductSalesCollection GetSalesData()
        {
            // Geography
            string[] countries = {"Canada", "France", "Germany", "United Kingdom"};
            string[] ausStates = {"New South Wales", "Queensland", "Tasmania", "Victoria"};
            string[] canadaStates = {"British Columbia", "Brunswick"};
            string[] franceStates = {"Charente Maritime", "Essonne", "Garonne (Haute)", "Gers"};
            string[] germanyStates = {"Bayern", "Brandenburg", "Hamburg"};
            string[] ukStates = {"England"};
            string[] ussStates = {"North Carolina", "Alabama", "California", "Colorado"};

            // Time
            string[] dates = {"FY 2006", "FY 2007", "FY 2008"};

            // Products
            string[] products = {"Bike", "Car"};
            Random r = new Random(1233);

            int numberOfRecords = 2000;
            ProductSalesCollection listOfProductSales = new ProductSalesCollection();
            for (int i = 0; i < numberOfRecords; i++)
            {
                ProductSales sales = new ProductSales();
                sales.Country = countries[r.Next(1, countries.GetLength(0))];
                sales.Quantity = r.Next(1, 12);
                // 1 percent discount for 1 quantity
                double discount = (300 * sales.Quantity) * (double.Parse(sales.Quantity.ToString()) / 100);
                sales.Amount = (300 * sales.Quantity) - discount;
                sales.TotalPrice = sales.Amount * sales.Quantity;
                sales.UnitPrice = sales.Amount / sales.Quantity;
                sales.Date = dates[r.Next(r.Next(dates.GetLength(0) + 1))];
                sales.Product = products[r.Next(r.Next(products.GetLength(0) + 1))];
                switch (sales.Country)
                {
                    case "Australia":
                    {
                        sales.State = ausStates[r.Next(ausStates.GetLength(0))];
                        break;
                    }
                    case "Canada":
                    {
                        sales.State = canadaStates[r.Next(canadaStates.GetLength(0))];
                        break;
                    }
                    case "France":
                    {
                        sales.State = franceStates[r.Next(franceStates.GetLength(0))];
                        break;
                    }
                    case "Germany":
                    {
                        sales.State = germanyStates[r.Next(germanyStates.GetLength(0))];
                        break;
                    }
                    case "United Kingdom":
                    {
                        sales.State = ukStates[r.Next(ukStates.GetLength(0))];
                        break;
                    }
                    case "United States":
                    {
                        sales.State = ussStates[r.Next(ussStates.GetLength(0))];
                        break;
                    }
                }
                listOfProductSales.Add(sales);
            }

            return listOfProductSales;
        }
    }

    #endregion
}