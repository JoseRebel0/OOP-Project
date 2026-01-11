/*
*   < copyright file = "ProductController.cs" company = "IPCA" >
*   Copyright(c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 23:21:54 </ date >
*   < description ></ description >
**/
using System;
using System.Collections.Generic;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO.Controller
{
    public class ProductController
    {
        private List<Product> products;
        private IProductView view;

        public ProductController(List<Product> productsList, IProductView productView)
        {
            products = productsList;
            view = productView;
        }

        public void AddProduct()
        {
            double price = view.AskPrice();
            string manufacturer = view.AskManufacturer();
            string reference = view.AskReference();

            Console.WriteLine("Select Product Type:");
            Console.WriteLine("-> Jersey");
            Console.WriteLine("-> Polo");
            Console.WriteLine("-> Pants");
            string type = Console.ReadLine();

            Product newProduct;

            switch (type)
            {
                case "Jersey" || "jersey" :
                    newProduct = CreateFutShirt(price, manufacturer, reference, type);
                    break;

                case "Polo" || "polo":
                    newProduct = CreatePolo(price, manufacturer, reference, type);
                    break;

                case "Pants" || "pants":
                    newProduct = CreatePants(price, manufacturer, reference, type);
                    break;

                default:
                    newProduct = null;
                    break;
            }


            if (newProduct != null)
            {
                products.Add(newProduct);//add to the list
            }
        }

        private FutShirt CreateFutShirt(double price, string manufacturer, string reference)
        {
            string size = view.AskSizeShirt();
            string sleeve = view.AskTypeSleeve();
            string team = view.AskTeam();
            string shirtClass = view.AskShirtClass();
            int year = view.AskYear();
            string type = "Football Shirt";

            return new FutShirt(size, price, sleeve, type, manufacturer, reference, team, shirtClass, year);
        }

        private Polo CreatePolo(double price, string manufacturer, string reference)
        {
            string size = view.AskSizeShirt();
            string sleeve = view.AskTypeSleeve();
            string color = view.AskColorPolo();
            string button = view.AskButton();
            string type = "Polo";

            return new Polo(size, price, sleeve, type, manufacturer, reference, color, button);
        }

        private Pants CreatePants(double price, string manufacturer, string reference)
        {
            int size = view.AskSizePants();
            string model = view.AskModel();
            string color = view.AskColorPants();

            return new Pants(size, model, price, manufacturer, reference, color);
        }
    }
}