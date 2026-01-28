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

    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 17/01/2026 21:32:51
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>

    public class CustomerController
    {
        /// <param name="customers"> List of customers. </param>
        /// <param name="view"> Customer View. </param>
        List<Customer> customers;
        ICustomerView view;

        /// <summary>
        /// Adding new customer method
        /// </summary>
        /// <param name="view.AskName()"> Asking customer name method. </param>
        /// <param birth="view.AskBirthDate()"> Asking customer birth date method. </param>
        /// <param nif="view.AskNIF()"> Asking customer NIF method. </param>
        /// <param phone="view.AskPhone()"> Aking customer phone method. </param>
        public bool AddCustomer()
        {
            string name = view.AskName();
            var birth = view.AskBirthDate();
            int nif = view.AskNIF();
            int phone = view.AskPhone();
        
            customers.Add(new Customer(name, birth, nif, phone));

            return true;
        }

        /*public void ShowAllCustomers()
        {
            view.ShowCustomers(customers);
        }*/
    }
}