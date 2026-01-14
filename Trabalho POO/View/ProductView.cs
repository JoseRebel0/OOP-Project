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
        public double AskPrice()
        {
            while (true)
            {
                Console.Write("Price (€): ");
                string input = Console.ReadLine().Trim();

                try
                {
                    double price = double.Parse(input);

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
            Console.WriteLine("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            return manufacturer;
        }

        public string AskReference()
        {
            Console.WriteLine("Reference: ");
            string reference = Console.ReadLine().Trim();
            return reference;


        }

        public string AskSizeShirt()
        {
            Console.WriteLine("Size (S/M/L/XL/XXL): ");
            string size = Console.ReadLine().Trim();

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
                Console.Write("Type of Sleeve (Long/Short): ");
                string sleeve = Console.ReadLine().Trim();
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
            Console.WriteLine("Team (ex: SL Benfica, SC Braga, Vieira SC): ");
            string team = Console.ReadLine().Trim();
            return team;
        }

        public string AskShirtClass()
        {
            Console.Write("Class (Home/Away/Third): ");
            string shirtClass = Console.ReadLine().Trim();

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
                Console.WriteLine("Year: ");
                string input = Console.ReadLine();

                try
                {
                    int year = int.Parse(input);

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
            Console.WriteLine("Color: ");
            string color = Console.ReadLine().Trim();
            return color;
        }

        public string AskButton()
        {
            while (true)
            {
                Console.WriteLine("Has buttons? (Yes/No): ");
                string answer = Console.ReadLine().Trim();

                if (answer == "Yes" || answer == "No" || answer == "yes" || answer == "no")
                {
                    return answer;
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
                Console.Write("Pants size (number): ");
                string input = Console.ReadLine();

                try
                {
                    int sizep = int.Parse(input);

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
            Console.Write("Model (ex: Straight, Slim): ");
            string model = Console.ReadLine().Trim();
            return model;
        }

        public string AskColorPants()
        {
            Console.Write("Color: ");
            string color = Console.Readline().Trim();
            return color;
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