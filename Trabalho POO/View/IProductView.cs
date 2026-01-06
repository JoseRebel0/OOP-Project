/*
*	<copyright file="IProductView.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 16:50:34</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using Trabalho_POO.Model;

namespace Trabalho_POO.View
{
    public interface IProductView
    {

        int AskType(); // 1-FutShirt, 2-Polo, 3-Pants
        double AskPrice();
        string AskManufacturer();
        string AskReference();


        string AskSizeShrit();
        string AskTypeSleeve();
        string AskTypeShirt();

        
        string AskTeam();
        string AskShirtClass(); // Home/Away/Third
        int AskYear();

      
        string AskColorPolo();
        string AskButton(); // Yes/No

   
        int AskSizePants();
        string AskModel();
        string AskColorPants();
        string AskTypePants();
    }
}