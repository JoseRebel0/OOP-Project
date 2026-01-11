/*
- <copyright file="ProductController.cs" company="IPCA">
- Copyright (c) 2025 All Rights Reserved
- </copyright>
- <author>joser</author>
- <date>16/12/2025 23:21:54</date>
- <description></description>
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
            produtos = productsList;
            view = productView;
        }

        public void AddProduct()
        {
            double price = view.AskPrice();
            string manufacturer = view.AskManufacturer();
            string reference = view.AskReference();

            int type = view.AskType();
            Product newProduct;

            switch (type)
            {
                case 1:
                    newProduct = CreateFutShirt(preco, fabricante, referencia);
                    break;

                case 2:
                    newProduct = CreatePolo(preco, fabricante, referencia);
                    break;

                case 3:
                    newProduct = CreatePants(preco, fabricante, referencia);
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
            string type = view.AskTypeShirt();
            string team = view.AskTeam();
            string shirtClass = view.AskShirtClass();
            int year = view.AskYear();

            return new FutShirt(size, price, sleeve, type, manufacturer, reference, team, shirtClass, year);
        }

        private Polo CreatePolo(double price, string manufacturer, string reference)
        {
            string size = view.AskSizeShirt();
            string sleeve = view.AskTypeSleeve();
            string type = view.AskTypeShirt();
            string color = view.AskColorPolo();
            string button = view.AskButton();

            return new Polo(size, price, sleeve, type, manufacturer, reference, color, button);
        }

        private Pants CreatePants(double price, string manufacturer, string reference)
        {
            int size = view.AskSizePants();
            string model = view.AskModel();
            string type = view.AskTypePants();
            string color = view.AskColorPants();

            return new Pants(size, model, type, price, manufacturer, reference, color);
        }
    }
}