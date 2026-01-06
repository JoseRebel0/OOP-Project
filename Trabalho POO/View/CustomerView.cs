/*
*	<copyright file="CustomerView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:59</date>
*	<description></description>
**/
using System;
using Trabalho_POO.Model;
using System.Collections.Generic;


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
            Console.WriteLine("First and Last Name: ");
            Console.ReadLine(); //first space last 
            return name;
        }

        public DateTime AskBirthDate()
        {
            DateTime birthDate;
            do
            {
                Console.Write("Birth date (dd/mm/yyyy): ");
            } while (!DateTime.TryParse(Console.ReadLine(), out birthDate));//out saves the value in birthDate

            return birthDate;

        }

        public int AskNIF()
        {
            while (true)
            {
                Console.Write("NIF (9 digits): ");
                string input = Console.ReadLine().Trim();
                if (input.ToString().Length == 9)
                {
                    return nif;
                }
                    
                Console.WriteLine("Must have 9 digits.");
            }
        }

        public int AskPhone()
        {
            while (true)
            {
                Console.Write("Phone (9 digits): ");
                string input = Console.ReadLine().Trim();
                if (input.ToString().Length == 9)
                {
                    return phone;
                }
                Console.WriteLine("Must have 9 digits.");
            }
        }

        public void HowManySpent(double total)
        {
            Console.WriteLine($"Total spent: {total}€");
        }
    }
}
