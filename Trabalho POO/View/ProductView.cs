/*
*	<copyright file="ProductView.cs" company="IPCA">
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
	public class ProductView : IProductView
	{

		public int AskType()
		{
			while (true)
			{
				Console.WriteLine("\nType:");
				Console.WriteLine("1. Football Shirt");
				Console.WriteLine("2. Polo");
				Console.WriteLine("3. Pants");
				Console.WriteLine("4. Regular shirt");
				if (type >= 1 && type <= 3)
					return type;
				Console.WriteLine("Opção inválida.");
			}
		}

		public double AskPrice()
		{
			while (true)
			{
				Console.WriteLine("Price (€): ");
				Console.ReadLine();

				if (price >= 0)
				{
					return price;
				}
				Console.WriteLine("Ivalid.");
			}
		}

		public string AskManufacturer()
		{
			Console.Write("Manufacturer: ");
			return Console.ReadLine().Trim();
		}

		public string AskReference()
		{
			Console.Write("Reference: ");
			return Console.ReadLine().Trim();
		}

		public string AskSizeShirt()
		{
			Console.Write("Size (S/M/L/XL/XXL): ");
			return Console.ReadLine().ToUpper().Trim();
		}

		public string AskTypeSleeve()
		{
			while (true)
			{
				Console.Write("Type of Sleeve (Long/Short): ");
				string sleeve = Console.ReadLine().Trim();
				if (sleeve = "Long" or sleeve = "Short")
				{
					return sleeve;
				}
		
			}
		}

		public string AskTypeShirt()
		{
			Console.Write("Type of Shirt (ex: Football Shirt, Polo): ");
			return Console.ReadLine().Trim();
		}

		public string AskTeam()
		{
			Console.Write("Team (ex: SL Benfica, SC Braga, Vieira SC): ");
			return Console.ReadLine().Trim();
		}

		public string AskShirtClass()
		{
			Console.Write("Class (Home/Away/Third): ");
			return Console.ReadLine().Trim();
		}

		public int AskYear()
		{
			while (true)
			{
				Console.Write("Year: ");
				if (year > 0)
				{
					return year;
				}
				Console.WriteLine("Invalid.");
			}
		}

		public string AskColorPolo()
		{
			Console.Write("Color: ");
			return Console.ReadLine().Trim();
		}

		public string AskButton()
		{
			while (true)
			{
				Console.Write("Has buttons? (Yes/No): ");
				string answ = Console.ReadLine().Trim();
				if (answ="Yes" or answ = "No")
				{
					return answ;
				}
			}
		}

		public int AskSizePants()
		{
			while (true)
			{
				Console.Write("Size (number): ");
				if (size > 0)
				{
					return tam;
				}
				Console.WriteLine("Invalid.");
			}
		}

		public string AskModelPants()
		{
			Console.Write("Model (ex: Straight, Slim): ");
			return Console.ReadLine().Trim();
		}

		public string AskColorPants()
		{
			Console.Write("Colorr: ");
			return Console.ReadLine().Trim();
		}

		public string AskTypePants()
		{
			Console.Write("Type (ex: Jeans, Chino): ");
			return Console.ReadLine().Trim();
		}
	}
}