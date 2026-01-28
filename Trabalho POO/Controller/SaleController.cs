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
        /// <param name="sales"> List of sales. </param>
        /// <param name="customers"> List of costumers. </param>
        /// <param name="products"> List of products.  </param>
        /// <param name="view"> Sale View. </param>
         List<Sale> sales;
         List<Customer> customers;
         List<Product> products;
         ISaleView view;


        /// <summary>
        /// Register sale method.
        /// </summary>
        public bool RegisterSale()
        {

            if (customers.Count == 0)
            {
                return;
            }

            if (products.Count == 0)
            {
                return;
            }

            ///<param name="nif"> Customer NIF to find. </param>
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
                return;
            }
            /// <summary> 
            /// New list only for the items for the sale.
            /// </summary>
            List<Product> saleItems = new List<Product>();

            do
            {
                /// <param name="reference"> Asking the reference of the product. </param>
                string reference = view.AskProductRef(products);

                if (reference == null)
                    break;

                /// <param name="selectedProduct"> Product to select. </param>
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
                    continue;
                }

                saleItems.Add(selectedProduct);//add selected product to sale items

            } while (view.AskMoreProducts());


            if (saleItems.Count == 0)
            {
                return;
            }

            Sale newSale = new Sale(nif, DateTime.Now, saleItems);
            sales.Add(newSale); //add new sale to sales list
            return true;
            //view.ShowSaleDetails(newSale, customers, products);
        }

        /*public void ListSales()
        {
            view.ShowSales(sales);
        }*/
    }
}