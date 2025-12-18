/*
*	<copyright file="Vestuario.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>15/11/2025 16:18:35</date>
*	<description></description>
**/
using System;
using System.Security.Policy;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 15/11/2025 16:18:35
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Product
    {
        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes

        double price;
        string manufacturer, reference;
        int stock;

        #endregion

        #region Methods

        #region Constructors
        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public Product()
        {  
            manufacturer = "";
            reference = "";
            price = 0.0f;
            stock = 0;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="p">Product price.</param>
        /// <param name="r">Reference of the product.</param>
        /// <param name="m">Product manufacturer.</param>
        public Product(double p, string r, string m, int s)
        {
            price = p;
            reference = r;
            manufacturer = m;
            stock = s;
        }

        #endregion


        /// <summary>
        /// Gets or sets the properties of the class.
        /// </summary>
        #region Properties

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set { manufacturer = value; }
        }

        public string Reference
        {
            get { return reference; }
            set { reference = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        #endregion

        #endregion
    }
}
