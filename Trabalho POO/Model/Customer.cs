/*
*	<copyright file="Cliente.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>03/11/2025 21:32:51</date>
*	<description></description>
**/
using System;
using System.Diagnostics;

namespace Trabalho_POO
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 03/11/2025 21:32:51
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    [Serializable]
    public class Customer 
    {
        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes

        string name;
        DateTime bornDate;
        int nif;
        int phone;


        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public Customer()
        {
            name = "";
            bornDate = DateTime.MinValue; //smallest datetime value possible
            nif = 0;
            phone = 0;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="nm">Name of the client.</param>
        /// <param name="bD">Birth date of the client.</param>
        /// <param name="n">Tax identification number (NIF) of the client.</param>
        /// <param name="p">Phone number of the client.</param>
        public Customer(string nm, DateTime bD, int n, int p)
        {
                name = nm;
                bornDate = bD;
                nif = n;
                phone = p;
        }

        #endregion

        /// <summary>
        /// Gets or sets the properties of the class.
        /// </summary>
        #region Properties

        public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public DateTime BornDate
            {
                get { return bornDate; }
                set { bornDate = value; }
            }

            public int Nif
            {
                get { return nif; }
                set { nif = value; }
            }

            public int Phone
            {
                get { return phone; }
                set { phone = value; }
            }

        #endregion

        #endregion



    }
}