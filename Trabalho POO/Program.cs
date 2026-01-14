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

            string fileName = @"data.bin";

            Data data = new Data();


            Data loadedData = Data.Load(fileName);
            if (loadedData != null)
                data = loadedData;

            List<Customer> customers = new List<Customer>();
            List<Product> products = new List<Product>();
            List<Sale> sales = new List<Sale>();

            ICustomerView customerView = new CustomerView();
            IProductView productView = new ProductView();
            ISaleView saleView = new SaleView();

            CustomerController customerController = new CustomerController(data.Customers, customerView);
            ProductController productController = new ProductController(data.Products, productView);
            SaleController saleController = new SaleController(data.Sales, data.Customers, data.Products, saleView);

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

            data.Save(fileName);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}