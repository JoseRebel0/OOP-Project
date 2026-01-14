/*
*	<copyright file="CustomerController.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 23:21:54</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO.Controller
{
    public class CustomerController
    {
         List<Customer> customers;
         ICustomerView view;

        public CustomerController(List<Customer> customerList, ICustomerView customerView)
        {
            customers = customerList;
            view = customerView;
        }

        //Add new customer
        public void AddCustomer()
        {
            string name = view.AskName();
            DateTime birthDate = view.AskBirthDate();
            int nif = view.AskNIF();
            int phone = view.AskPhone();

            Customer newCustomer = new Customer(name, birthDate, nif, phone);
            customers.Add(newCustomer); //add to the list

            Console.WriteLine("Customer added.");
        }

        // Show every customer
        public void ShowAllCustomers()
        {
            view.ShowCustomers(customers);
        }
    }
}