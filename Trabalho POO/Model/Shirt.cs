/*
*	<copyright file="Camisola.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>30/10/2025 20:30:41</date>
*	<description></description>
**/
using System;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 30/10/2025 20:30:41
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Shirt: Product
    {

        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes 

        string size, typeSleeve;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public Shirt() 
        {
            size = "";
            typeSleeve = "";

        }
        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="s">Shirt size. (S/M/L/XL/XXL)</param>
        /// <param name="price">Shirt price. (€)</param>
        /// <param name="manufacturer">Shirt manufacturer.</param>
        /// <param name="reference">Shirt reference.</param>
        /// <param name="tS">Type of sleeve. (Long/Short)</param>
        // Receiving parameters from the main
        public Shirt(string s, double price, string manufacturer, string reference, string tS, int stock)
        :base(price, reference, manufacturer, stock) 
        {
            
            size = s;
            typeSleeve = tS;

        }

        #endregion

        /// <summary>
        /// Gets or sets the properties of the class.
        /// </summary>
        #region Properties

        // The way they should be shown
        public string Size
        {
            get { return size.ToUpper(); }
            set { size = value; }
        }

        public string TypeSleeve
        {
            get { return typeSleeve; }
            set { typeSleeve = value; }
        }



        #endregion

        #endregion

    }
}