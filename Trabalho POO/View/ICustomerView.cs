/*
*	<copyright file="ICostumerView.cs" company="IPCA">
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
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 16/12/2025 16:50:34
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public interface ICustomerView
    {

        void ShowCustomers(List<Customer> customers);

        string AskName();
        DateTime AskBirthDate();
        int AskNIF();
        int AskPhone();
        void HowManySpent(double total);



    }
}
