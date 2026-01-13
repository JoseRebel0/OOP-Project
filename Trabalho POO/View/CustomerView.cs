/*
*	<copyright filecust"CustomerView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:59</date>
*	<description></description>
**/
using System;
using Trabalho_POO.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_POO.View
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 16/12/2025 16:50:59
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class CustomerView : ICustomerView
    {

        public void ShowCustomers(List<Customer> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customers.");
                return;
            }

            Console.WriteLine("\n Customers List");
            foreach (var c in customers)
            {
                Console.WriteLine($"NIF: {c.Nif} \n Name: {c.Name} \n BornDate: {c.BornDate:dd/MM/yyyy} \n Phone: {c.Phone}");
            }
        }

        public string AskName()
        {
            Console.Write("First and Last Name: ");
            string name = Console.ReadLine()?.Trim() ?? "";
            return name;
        }

        public DateTime AskBirthDate()
        {
            while (true)
            {
                Console.Write("Birth date (dd/mm/yyyy): ");
                string input = Console.ReadLine();
                try
                {
                    DateTime date = DateTime.Parse(input);
                    return date;
                }
                catch
                {
                    Console.WriteLine("Invalid date. Again pls.");
                }
            }
        }


        public int AskNIF()
        {
            while (true)
            {
                Console.Write("NIF (9 digits): ");
                string input = Console.ReadLine(); //readline only reads strings

                if (input.Length != 9)
                {
                    Console.WriteLine("9 digits.");
                    continue;
                }

                try
                {
                    int nif = int.Parse(input);
                    return nif;
                }
                catch
                {
                    Console.WriteLine("only numbers.");
                }
            }
        }


        public int AskPhone()
        {
            while (true)
            {
                Console.Write("Phone number (9 digits): ");
                string input = Console.ReadLine();

                if (input.Length != 9)
                {
                    Console.WriteLine("9 digits.");
                    continue;
                }

                try
                {
                    int phone = int.Parse(input);
                    return phone;
                }
                catch
                {
                    Console.WriteLine("Only digits.");
                }
            }
        }
    }
}