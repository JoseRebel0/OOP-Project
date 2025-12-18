/*
*	<copyright file="Polo.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>15/12/2025 23:39:07</date>
*	<description></description>
**/
using System;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 15/12/2025 23:39:07
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable] bacv
    public class Polo : Shirt
    {
        #region Attributes

        string color, button;

        #endregion

        #region Methods

        #region Constructors

        public Polo()
        {
            color = "";
            button = "";
        }
        //Remember to keep the order of parameters as they are in Shirt class (otherwise will be error)
        public Polo(string c, string b, double price, string manufacturer, string reference, int stock, string typeSleeve, string size)
            : base(size, price, manufacturer, reference, typeSleeve, stock)
        {
            color = c;
            button = b;
        }

        #endregion

        #region Properties

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Button
        {
            get { return button; }
            set { button = value; }
        }

        #endregion

        #endregion
    }
}
