using System;
using Trabalho_POO.Controller;
using Trabalho_POO.Model;
using Trabalho_POO.View;

namespace Trabalho_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "data.bin";

            Data data = Data.Load(fileName);
            if (data == null)
            {
                data = new Data();
            }

            new CustomerController();
            new ProductController();
            new SaleController();

            data.Save(fileName);
        }
    }
}
