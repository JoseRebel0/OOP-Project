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
    [Serializable]
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
        public Polo(string size, double price, string typeSleeve, string type, string manufacturer,
            string reference, string c, string b)
            : base(size, price, typeSleeve, manufacturer, reference, type)
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
