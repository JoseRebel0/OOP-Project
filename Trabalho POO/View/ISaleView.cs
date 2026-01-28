/*
*	<copyright file="ISaleView.cs" company="IPCA">
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
    public interface ISaleView
    {
        bool ShowSales(List<Sale> sales);
        bool ShowSaleDetails(Sale sale, List<Customer> customers, List<Product> products);

        int AskNIFCustomer();
        string AskProductRef(List<Product> products);
        bool AskMoreProducts();
    }
}
