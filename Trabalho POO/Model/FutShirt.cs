/*
*	<copyright file="FutShirt.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>30/10/2025 21:14:05</date>
*	<description></description>
**/
using System;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 30/10/2025 21:14:05
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class FutShirt : Shirt //Heritance from Shirt Class
    {

        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes

        string team, shirtClass;
        int year;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public FutShirt()
        {
            team = "";
            shirtClass = "";
            year = 0;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="size">Shirt size. (S/M/L/XL/XXL)</param>
        /// <param name="price">Shirt price. (€)</param>
        /// <param name="typeSleeve">Type of sleeve. (Long/Short)</param>
        /// <param name="manufacturer">Shirt manufacturer.</param>
        /// <param name="reference">Shirt reference.</param>
        /// <param name="t">The team of the shirt.</param>
        /// <param name="c">Class of the shirt. (Home/Away/Third)</param>
        /// <param name="y">Year/Season</param>
        public FutShirt(string size, double price, string typeSleeve, string type, string manufacturer,
            string reference,string t, string c, int y)
            : base(size, price, typeSleeve, manufacturer, reference, type) // Indicates who came from base
        {
            team = t;
            shirtClass = c;
            year = y;
        }

        #endregion

        /// <summary>
        /// Gets or sets the properties of the class.
        /// </summary>
        #region Properties

        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        public string ShirtClass
        {
            get { return shirtClass; }
            set { shirtClass = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        #endregion

        #endregion


    }
}