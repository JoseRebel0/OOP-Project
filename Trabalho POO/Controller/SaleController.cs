/*
*	<copyright file="SaleController.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>01/01/2026</date>
*	<description>Sale management controller</description>
**/

using System;
using System.Collections.Generic;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO.Controller
{
    public class SaleController
    {
         List<Sale> sales;
         List<Customer> customers;
         List<Product> products;
         ISaleView view;

        public SaleController(List<Sale> salesList, List<Customer> customersList, 
            List<Product> productsList, ISaleView saleView)
        {
            sales = salesList;
            customers = customersList;
            products = productsList;
            view = saleView;
        }

        public void RegisterSale()
        {
            Console.WriteLine("\nNew Sale");

            if (customers.Count == 0)
            {
                Console.WriteLine("No customers.");
                return;
            }

            if (products.Count == 0)
            {
                Console.WriteLine("No products.");
                return;
            }

            string nif = view.AskNIFCustomer();

            bool found = false;

            foreach (Customer c in customers)
            {
                if (c.Nif.ToString() == nif)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine("Customer not found.");
                return;
            }

            List<Product> saleItems = new List<Product>();

            do
            {
                string reference = view.AskProductRef(products);

                if (reference == null)
                    break;

                Product selectedProduct = null;
                foreach (Product p in saleItems)
                {
                    if (p.Reference == reference)
                    {
                        selectedProduct = p;
                        break;
                    }
                }


                if (selectedProduct == null)
                {
                    Console.WriteLine("Product not found.");
                    continue;
                }

                saleItems.Add(selectedProduct);//add selected product to sale items
                Console.WriteLine($"Added: {selectedProduct.Manufacturer} {selectedProduct.Reference} - {selectedProduct.Price:F2}€");

            } while (view.AskMoreProducts());


            if (saleItems.Count == 0)
            {
                Console.WriteLine("No products added.");
                return;
            }

            Sale newSale = new Sale(nif, DateTime.Now, saleItems);
            sales.Add(newSale); //add new sale to sales list

            Console.WriteLine("Sale registered successfully!");
            view.ShowSaleDetails(newSale, customers, products);
        }

        public void ListSales()
        {
            view.ShowSales(sales);
        }
    }
}