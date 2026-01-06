/*
*	<copyright file="CustomerController.cs" company="IPCA">
*		Copyright (c) 2025 All Rights Reserved
*	</copyright>
* 	<author>joser</author>
*   <date>16/12/2025 23:21:54</date>
*	<description></description>
**/
using System;
using System.Collections.Generic;
using System.Linq;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO.Controller
{
    public class CustomerController
    {
        private List<Customer> customers;
        private ICustomerView view;

        public CustomerController(List<Customer> customerList, ICustomerView customerView)
        {
            customers = customerList;
            view = customerView;
        }

        //Add new customer
        public void AddCustomer()
        {
            string name = view.AskName();
            DateTime birthDate = view.AskBirthDate();
            int nif = view.AskNIF();
            int phone = view.AskPhone();

            Customer newCustomer = new Customer(name, birthDate, nif, phone);
            clientes.Add(newCustomer); //add to the list

            Console.WriteLine("Customer added.");
        }

        // Show every customer
        public void ShowAllCustomers()
        {
            view.ShowCustomers(customers);
        }

        // Mostrar total gasto (usando o Expence)
        public void MostrarTotalGastoDeCliente(List<Sale> vendas)
        {
            view.MostrarMensagem("\nConsulta de total gasto");
            Console.Write("Insira o NIF do cliente: ");
            if (!int.TryParse(Console.ReadLine(), out int nif))
            {
                view.MostrarMensagem("NIF inválido.");
                return;
            }

            Customer cliente = clientes.FirstOrDefault(c => c.Nif == nif);
            if (cliente == null)
            {
                view.MostrarMensagem("Cliente não encontrado.");
                return;
            }

            // Calcular total das vendas desse cliente
            double total = vendas
                .Where(v => v.CustomerNIF == nif.ToString())
                .Sum(v => v.GetTotal());

            view.MostrarMensagem($"Cliente: {cliente.Name}");
            view.MostrarTotalGasto(total);
        }
    }
}