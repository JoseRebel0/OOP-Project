/*
*	<copyright file="ExpenceController.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 23:21:54</date>
*	<description></description>
**/
using System;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO.Controller
{
    /// <summary>
    /// Purpose:
    /// Created by: joser
    /// Created on: 16/12/2025 23:21:54
    /// </summary>
    /// <remarks></remarks>
    /// <example></example>
    public class ExpenceController
    {

        private Expence expence;
        private ICustomerView customerView;

        public ExpenceController(Expence e, ICustomerView cv)
        {
            expence = e;
            customerView = cv;
        }

        public void ShowTotalSpent()
        {
            customerView.HowManySpent(expence.GetTotalSpent());
        }


    }
}
