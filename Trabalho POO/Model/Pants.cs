/*
*	<copyright file="Pants.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>15/12/2025 23:27:41</date>
*	<description></description>
**/
using System;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 15/12/2025 23:27:41
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Pants : Product
    {
        #region Attributes

        string model, color, type;
        int size;

        #endregion

        #region Methods

        #region Constructors

        public Pants()
        {
            size = 0;
            model = "";
            color = "";
            type = "";
        }

        public Pants(int s, string m, string t, double price, string manufacturer, string reference, string c)
           : base(price, manufacturer, reference)
        {
            size = s;
            model = m;
            color = c;
            type = t;
        }

        #endregion

        #region Properties

        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        #endregion

        #endregion
    }
}
