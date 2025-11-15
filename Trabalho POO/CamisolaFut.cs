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
    public class CamisolaFut : Camisola // Herança da classe Camisola
    {
        // Criação das variáveis vazias
        #region Attributes

        string team, typeShirt;
        int year;

        #endregion


        #region Methods

        #region Constructors

        public CamisolaFut()
        {
            team = "";
            typeShirt = "";
            year = 0;
        }

        public CamisolaFut(
            string size, double price, string typeSleeve, string manufacturer, string reference,
            string t, string tS, int y)
        :    base(size, price, typeSleeve, manufacturer, reference) // Indica quais é que são da classe pai
        {
            team = t;
            typeShirt = tS;
            year = y;
        }

        #endregion


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

        // Para já não manter o método de mostrar dados

        //public override string GetData()
        //{
        //    var gbd = base.GetData(); // variavel que vai buscar o GetData da classe Camisola
        //    return $"{gbd}\nTeam: {team}\nType Shirt: {typeShirt}\nYear: {year}\n";
        //}

        #endregion


        #region OtherMethods
        #endregion


        #region Destructor
        #endregion

        #endregion


    }
}