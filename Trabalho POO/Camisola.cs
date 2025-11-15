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

        // Criação das variáveis vazias
        #region Attributes 

        string size, typeSleeve;

        #endregion


        #region Methods

        #region Constructors

        // Criação das variáveis por defeito (vazias)
        public Camisola() 
        {
            size = "";
            typeSleeve = "";

        }

        // Recebe os valores atribuidos no main
        public Camisola(string s, double price, string manufacturer, string reference, string tS)
        :base(price, reference, manufacturer) 
        {
            
            size = s;
            typeSleeve = tS;

        }

        #endregion


        #region Properties

        // A maneira como devem ser mostradas
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

        // Para já não manter o método de mostrar dados

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