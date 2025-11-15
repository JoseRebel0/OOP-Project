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
    public class Vestuario
    {
        #region Attributes

        double price;
        string manufacturer, reference;

        #endregion

        #region Methods

        #region Constructors

        public Vestuario()
        {  
            manufacturer = "";
            reference = "";
            price = 0.0f;
        }

        public Vestuario(double p, string r, string m)
        {
            price = p;
            reference = r;
            manufacturer = m;
        }

        #endregion

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

        #endregion

        #region Overrides



        #endregion

        #region OtherMethods



        #endregion

        #region Destructor



        #endregion

        #endregion
    }
}
