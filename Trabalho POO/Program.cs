using System;
using System.Collections.Generic;
using Trabalho_POO.Controller;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<Sale> sales = new List<Sale>();

            
            ICustomerView customerView = new CustomerView();
            IProductView productView = new ProductView();
            ISaleView saleView = new SaleView();

            CustomerController customerController = new CustomerController(customers, customerView);
            ProductController productController = new ProductController(products, productView);
            SaleController saleController = new SaleController(sales, customers, products, saleView);

            customers.Add(new Customer("José Rebelo", new DateTime(2005, 3, 24), 123456789, 924041637));

            FutShirt fs = new FutShirt("S", 120.00, "Long", "Football Shirt", "Nike", "A3hF1l", "Portugal", "Home", 2004);
            products.Add(fs);

            Polo polo = new Polo("L", 12.00, "Short", "Polo", "Lacoste", "sagydg82", "Red", "Yes");
            products.Add(polo);

            Pants pants = new Pants(38, "Straight", "Jeans", 29.95, "Echo", "AjuFh21", "Black");
            products.Add(pants);


            customerController.ShowAllCustomers();

            Console.WriteLine("\nPress Any key to leave...");
            Console.ReadKey();

        }
    }
}