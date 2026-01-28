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
        /// <param name="products"> List of products. </param>
        /// <param name="view"> Product View. </param>
        List<Product> products;
        IProductView view;


        /// <summary>
        /// Adding product method
        /// </summary>
        public bool AddProduct()
        {
            /// <param name="price"> Price of the product. </param>
            /// <paramn name="manufacturer"> Manufacturer of the product. </param>
            /// <param name="reference"> Reference of the product. </param>
            double price = view.AskPrice();
            string manufacturer = view.AskManufacturer();
            string reference = view.AskReference();

            ///<summary> Choosing the type of product </summary>
            Product newProduct;

            string type = "Polo";
            switch (type)
            {
                case "Jersey":
                    newProduct = CreateFutShirt(price, manufacturer, reference, type);
                    break;

                case "Polo":
                    newProduct = CreatePolo(price, manufacturer, reference, type);
                    break;

                case "Pants":
                    newProduct = CreatePants(price, manufacturer, reference, type);
                    break;

                default:
                    newProduct = null;
                    break;
            }


            if (newProduct != null)
            {
                products.Add(newProduct);//add to the list

                return true;
            }
            return false;
        }

        /// <summary>
        /// Creating footbal shirt method.
        /// </summary>
        /// <param name="size"> Size of the shirt. </param>
        /// <param name="sleeve"> Type of sleeve (long/short). </param>
        /// <param name="shirtClass"> Class of the shirt (Home/Away/Third). </param>
        /// <param name="year"> Year/Season of the shirt (08/09 ==> 2009) </param>
        FutShirt CreateFutShirt(double price, string manufacturer, string reference)
        {
            string size = view.AskSizeShirt();
            string sleeve = view.AskTypeSleeve();
            string team = view.AskTeam();
            string shirtClass = view.AskShirtClass();
            int year = view.AskYear();
            string type = "Football Shirt";

            return new FutShirt(size, price, sleeve, type, manufacturer, reference, team, shirtClass, year);
        }

        /// <summary>
        /// Creating polo method.
        /// </summary>
        /// <param name="size"> Size of the polo. </param>
        /// <param name="sleeve"> Type of sleeve (long/short). </param>
        /// <param name="color"> Color of the polo. </param>
        Polo CreatePolo(double price, string manufacturer, string reference)
        {
            string size = view.AskSizeShirt();
            string sleeve = view.AskTypeSleeve();
            string color = view.AskColorPolo();
            string button = view.AskButton();
            string type = "Polo";

            return new Polo(size, price, sleeve, type, manufacturer, reference, color, button);
        }

        /// <summary>
        /// Creating pants method.
        /// </summary>
        /// <param name="size"> Size of the pants (numeric). </param>
        /// <param name="model"> Model of the pants. </param>
        /// <param name="color"> Color of the pants. </param>
        Pants CreatePants(double price, string manufacturer, string reference)
        {
            int size = view.AskSizePants();
            string model = view.AskModel();
            string color = view.AskColorPants();

            return new Pants(size, model, price, manufacturer, reference, color);
        }


        /*public void ShowProducts()
        {
            view.ShowProducts(products);
        }*/
    }
}