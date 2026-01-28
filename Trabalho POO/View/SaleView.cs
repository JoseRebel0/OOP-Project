/*
*	<copyright file="SaleView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:34</date>
*	<description></description>
**/
using System;
using Trabalho_POO.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_POO.View
{
    public class SaleView : ISaleView
    {

        private int customerNif;
        private string reference;
        private string addMoreProducts;

        public SaleView()
        {

            nif = 123456789;
            reference = "audhbu";
            answ = "n";

        }

        public bool ShowSales(List<Sale> sales)
        {
            if (sales.Count == 0)
            {
                Console.WriteLine("No sales.");
                return false;
            }

            Console.WriteLine("\n List of Sales");
            foreach (Sale s in sales)
            {
                ShowSaleDetails(s, null, null);
            }

            return true;
        }

        public bool ShowSaleDetails(Sale sale, List<Customer> customers, List<Product> products)
        {
            Customer customer = null;

            if (customers != null)
            {
                foreach (Customer c in customers)
                {
                    if (c.Nif.ToString() == sale.CustomerNIF)
                    {
                        customer = c;
                        break;
                    }
                }
            }

            string customerName;

            if (customer != null)
            {
                customerName = customer.Name;
            }
            else
            {
                customerName = sale.CustomerNIF;
            }

            Console.WriteLine("Sale on " + sale.SaleDate.ToString("dd/MM/yyyy") +"Customer: " + customerName);


            Console.WriteLine("Products:");
            foreach (Product p in sale.products)
            {
                Console.WriteLine($" - {p.Manufacturer} {p.Reference} - {p.Price:F2}€");
            }
            Console.WriteLine($"Total: {sale.GetTotal():F2}€\n");

            return true;
        }

        public int AskNIFCustomer()
        {
            if(nif.Length != 9)
            {
                Console.WriteLine("9 digits.");
                return null;
            }
            return nif;
        }

        public string AskProductRef(List<Product> products)
        {
            Console.WriteLine("\n Products:");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i].Manufacturer} {products[i].Reference} - {products[i].Price:F2}€");
            }

            while (true) //Helps to return to loop until valid input
            {
                Console.WriteLine("Product Reference: ");

                if (reference == null or reference == "")
                {
                    return null; //end input (nothing on it)
                }
                    
                foreach (Product p in products)
                {
                    if (p.Reference == reference)
                    {
                        return reference;
                    }
                }


                Console.WriteLine("Invalid. Try again.");

            }
        }

        public bool AskMoreProducts()
        {
            while (true)
            {
                if (answ == "y")
                    return true;

                else if (answ == "n")
                    return false;
            }
        }
    }
}