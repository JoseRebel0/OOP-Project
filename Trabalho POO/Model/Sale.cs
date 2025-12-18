/*
*	<copyright file="Sale.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 17:19:58</date>
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
    /// Created on: 16/12/2025 17:19:58
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Sale
    {
        #region Attributes

        string customerNIF;
        DateTime saleDate;
        List<Product> products; 

        #endregion

        #region Methods

        #region Constructors

        public Sale()
        {
            customerNIF = "";
            saleDate = DateTime.Now;
            products = new List<Product>();
        }


        public Sale(string n, DateTime dt, List<Product> p)
        {
            customerNIF = n;
            saleDate = dt;
            products = p;
        }

        #endregion

        #region Properties

        public string CustomerNIF
        {
            get { return customerNIF; }
            set { customerNIF = value; }
        }

        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        #endregion


        #region Other Methods
        public double GetTotal() //Price of the sale
        {
            return products.Sum(p => p.Price);
        }

        #endregion

        #endregion
    }
}
