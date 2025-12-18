/*
*	<copyright file="Expence.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 22:25:53</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;

namespace Trabalho_POO.Model
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 16/12/2025 22:25:53
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Expence
    {
        private Customer customer;
        private List<Sale> sales; //Sales list


        public Expence(Customer c) //Indicates that c is a Customer
        {
            customer = c;
            sales = new List<Sale>();
        }

        public List<Sale> Sales
        {
            get { return sales; }
            set { sales = value; }
        }

        #region Other Methods
        public double GetTotalSpent() //Total spent by the customer
        {
            return sales.Sum(s => s.GetTotal());
        }

        #endregion
    }
}
