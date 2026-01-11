/*
*	<copyright file="SaleView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:34</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using Trabalho_POO.Model;

namespace Trabalho_POO.View
{
    public class SaleView : ISaleView
    {
        public void ShowSales(List<Sale> sales)
        {
            if (sales.Count == 0)
            {
                Console.WriteLine("No sales.");
                return;
            }

            Console.WriteLine("\n List of Sales");
            foreach (var s in sales)
            {
                ShowSaleDetails(s, null, null);
            }
        }

        public void ShowSaleDetails(Sale sale, List<Customer> customers, List<Product> products)
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

            Console.WriteLine("Sale on " + sale.SaleDate.ToString("dd/MM/yyyy") +
                " | Customer: " + customerName);


            Console.WriteLine("Products:");
            foreach (var p in sale.Products)
            {
                Console.WriteLine($" - {p.Manufacturer} {p.Reference} - {p.Price:F2}€");
            }
            Console.WriteLine($"Total: {sale.GetTotal():F2}€\n");
        }

        public int AskNIFCustomer()
        {
            Console.Write("Customer NIF: ");
            string input = Console.ReadLine().Trim();

            int nif = int.Parse(input);
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
                Console.Write("Product Reference: ");
                string refInput = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(refInput))
                    return null; //end input (nothing on it)

                foreach (var p in products)
                {
                    if (p.Reference.ToLower() == refInput.ToLower())
                    {
                        return refInput;
                    }
                }


                Console.WriteLine("Invalid. Try again.");

            }
        }

        public bool AskMoreProducts()
        {
            while (true)
            {
                Console.Write("Do you want to add more products? (y/n): ");
                string answ = Console.ReadLine().Trim().ToLower();

                if (answ == "y")
                    return true;

                else if (answ == "n")
                    return false;
            }
        }
    }
}