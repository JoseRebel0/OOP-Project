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
        private string name;
        private DateTime date;
        private int nif;
        private int phone;

        public CustomerView()
        {
            name = "José Rebelo";
            date = new DateTime(2026, 1, 12);
            nif = 123456789;
            phone = 987654321;
        }

        public void ShowCustomers(List<Customer> customers)
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No Customers.");
                return;
            }

            Console.WriteLine("\n Customers List");
            foreach (Customer c in customers)
            {
                Console.WriteLine($"NIF: {c.Nif} \n Name: {c.Name} \n BornDate: {c.BornDate:dd/MM/yyyy} \n Phone: {c.Phone}");
            }
        }

        public string AskName()
        {   
            return name;
        }

        public DateTime AskBirthDate()
        {
            while (true)
            {
                try
                {
                    return date;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public int AskNIF()
        {
            while (true)
            {
                try
                {
                    return nif;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        public int AskPhone()
        {
            while (true)
            {
                try
                {
                    return phone;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}