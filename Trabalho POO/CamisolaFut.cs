/*
*	<copyright file="CamisolaFut.cs" company="IPCA">
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
    public class CamisolaFut : Camisola //Heritance from Camisola
    {

        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes

        string team, typeShirt;
        int year;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public CamisolaFut()
        {
            team = "";
            typeShirt = "";
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
        /// <param name="tS">Type of the shirt. (Home/Away/Third)</param>
        /// <param name="y">Year/Season</param>
        public CamisolaFut(
            string size, double price, string typeSleeve, string manufacturer, string reference,
            string t, string tS, int y)
        :    base(size, price, typeSleeve, manufacturer, reference) // Indicates who came from base
        {
            team = t;
            typeShirt = tS;
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

        public string TypeShirt
        {
            get { return typeShirt; }
            set { typeShirt = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        #endregion


        #region Overrides



        #endregion


        #region OtherMethods

        //public override string GetData()
        //{
        //    var gbd = base.GetData(); // variavel que vai buscar o GetData da classe Camisola
        //    return $"{gbd}\nTeam: {team}\nType Shirt: {typeShirt}\nYear: {year}\n";
        //}

        #endregion


        #region Destructor
        #endregion

        #endregion


    }
}