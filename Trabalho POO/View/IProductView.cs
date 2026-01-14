/*
*	<copyright file="IProductView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:34</date>
*	<description></description>
**/
using System;
using Trabalho_POO.Model;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Trabalho_POO.View
{
    public interface IProductView
    {

        double AskPrice();
        string AskManufacturer();
        string AskReference();


        string AskSizeShirt();
        string AskTypeSleeve();
        


        string AskTeam();
        string AskShirtClass(); // Home/Away/Third
        int AskYear();


        string AskColorPolo();
        string AskButton(); // Yes/No


        int AskSizePants();
        string AskModelPants();
        string AskColorPants();
        void ShowProducts(List<Product> products);

    }
}