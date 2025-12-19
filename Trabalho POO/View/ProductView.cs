using System;

/// <summary>
/// Summary description for Class1
/// </summary>
public class ProductView : IProductView
{
	public ProductView()
	{
        void HowManyProducts(int total)
        {
             Console.WriteLine($"Existem {total} produtos em stock.");

        }
    }
}
