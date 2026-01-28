/*
*	<copyright file="ProductView.cs" company="IPCA">
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
    public class ProductView : IProductView
    {
        private double price;
        private string manufacturer;
        private string reference;

        // Football Shirt
        private string size;
        private string sleeve;
        private string team;
        private string shirtClass;
        private int year;

        // Polo
        private string color;
        private string hasButtons;

        // Pants
        private int sizep;
        private string model;
        private string colorp;

        public ProductView()
        {
            price = 17.0;
            manufacturer = "Nike";
            reference = "aybd76";

            size = "S";
            sleeve = "Long";
            team = "Salgueiros";
            shirtClass = "Home";
            year = 2005;

            color = "Red";
            hasButtons = "Yes";

            sizep = 36;
            model = "Straight";
            colorp = "Black";
        }



        public double AskPrice()
        {
            while (true)
            { 
                try
                {

                    if (price >= 0)
                    {

                        return price;

                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public string AskManufacturer()
        {
            return manufacturer;
        }

        public string AskReference()
        {
            return reference;
        }

        public string AskSizeShirt()
        {
            try
            {

                if (size != "S" && size != "M" && size != "L" && size != "XL" && size != "XXL")
                {
                    Console.WriteLine("Invalid.");
                }

                return size;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public string AskTypeSleeve()
        {
            while (true)
            {
                if(sleeve == "Long" || sleeve == "Short")

                {
                    return sleeve;
                }

                Console.WriteLine("Invalid.");
            }
        }

        //Football Shirt

        public string AskTeam()
        {
            return team;
        }

        public string AskShirtClass()
        {
            if (shirtClass != "Home" && shirtClass != "Away" && shirtClass != "Third")
            {
                Console.WriteLine("Invalid.");
            }

            return shirtClass;
        }

        public int AskYear()
        {
            while (true)
            {
                try
                {

                    if (year >= 1900)
                        return year;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //Polo

        public string AskColorPolo()
        {
            return color;
        }

        public string AskButton()
        {
            while (true)
            {

                if (hasButtons == "Yes" || hasButtons == "No" || hasButtons == "yes" || hasButtons == "no")
                {
                    return hasButtons;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        //Pants

        public int AskSizePants()
        {
            while (true)
            {
                try
                {
                    if (sizep > 31)
                    {
                        return sizep;
                    }
                        
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public string AskModelPants()
        {
            return model;
        }

        public string AskColorPants()
        {
            return colorp;
        }


        public void ShowProducts(List<Product> products)
        {
            if (products.Count == 0)
            {
                Console.WriteLine("No Products.");
                return;
            }

            Console.WriteLine("\n Products List");
            foreach (Product p in products)
            {
                Console.WriteLine($"Reference: {p.Reference} \n Price: {p.Price} \n Manufacturer: {p.Manufacturer}");
              
            }
        }

    }
}