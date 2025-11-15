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
    public class Camisola: Vestuario
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
        public Camisola() 
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
        public Camisola(string s, double price, string manufacturer, string reference, string tS)
        :base(price, reference, manufacturer) 
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


        #region Overrides
        #endregion


        #region OtherMethods

        // For now just keep it like this

        // Método de mostrar a criação da camisola (só teste)
        //public virtual string GetData() // Sem outra maneira de fazer return a tudo
        //{
        //    return $"Size: {Size}\n" +
        //    $"TypeSleeve: {TypeSleeve}\n" +
        //    $"Price: {Price}\n" +
        //    $"Manufacturer: {Manufacturer}\n" +
        //    $"Reference: {Reference}";

        //}

        #endregion


        #region Destructor
        #endregion

        #endregion

    }
}