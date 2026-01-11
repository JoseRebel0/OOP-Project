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

            Console.WriteLine("Create and list customers");
            customerController.AddCustomer();  
            customerController.ShowAllCustomers();

            Console.WriteLine("\nCreate products");
            productController.AddProduct();  
            productController.AddProduct();   

            Console.WriteLine("\nRegister a sale");
            saleController.RegisterSale(); 

            Console.WriteLine("\nList all sales");
            saleController.ListSales();

            Console.WriteLine("\nTotal spent by customer");
            if (customers.Count > 0 && sales.Count > 0)
            {
                Expence expence = new Expence(customers[0]);
                foreach (var sale in sales)
                {
                    if (sale.CustomerNIF == customers[0].Nif.ToString())
                        expence.Sales.Add(sale);
                }

                ExpenceController expenceController = new ExpenceController(expence, customerView);
                expenceController.ShowTotalSpent();
            }
            else
            {
                Console.WriteLine("No customers or sales.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}