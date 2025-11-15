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
    public class Cliente 
    {
        /// <summary>
        /// Creating empty attributes
        /// </summary>
        #region Attributes

        string name;
        DateTime bornDate;
        int nif;
        int phone;
        double totalSpent;

        #endregion


        #region Methods

        #region Constructors

        /// <summary>
        /// Default constructor. Empty values.
        /// </summary>
        public Cliente()
        {
            name = "";
            bornDate = DateTime.MinValue; //smallest datetime value possible
            nif = 0;
            phone = 0;
            totalSpent = 0;
        }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="nm">Name of the client.</param>
        /// <param name="bD">Birth date of the client.</param>
        /// <param name="n">Tax identification number (NIF) of the client.</param>
        /// <param name="p">Phone number of the client.</param>
        /// <param name="tot">The total amount spent by the client.</param>
        public Cliente(string nm, DateTime bD, int n, int p, double tot)
        {
                name = nm;
                bornDate = bD;
                nif = n;
                phone = p;
                totalSpent = tot;
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

            public double TotalSpent
            {
                get { return totalSpent; }
                set { totalSpent = value; }
            }

        #endregion


        #region Overrides
        #endregion


        #region OtherMethods

        // Para já não manter o método de mostrar dados

        // Método de mostrar a criação do cliente (só teste)
        //public virtual string GetData() //Com virtual a classe filho pode alterar e assim acrescentar mais coisas
        //{
        //    return $"Nome: {name} \n Data de Nascimento: {bornDate:d} \n NIF: {nif} \n Contacto: {phone}\n";
        //}


        // : d mostra a data só com dia, mês e ano
        #endregion


        #region Destructor
        #endregion


        #endregion



    }
}