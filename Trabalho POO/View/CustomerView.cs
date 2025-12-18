/*
*	<copyright file="CustomerView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:59</date>
*	<description></description>
**/
using System;

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

        public void HowManySpent(double total)
        {
            Console.WriteLine($"Total gasto pelo cliente: {total}€");
        }

    }
}
