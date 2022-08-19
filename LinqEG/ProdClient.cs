using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEG
{
    internal class ProdClient
    {
        static List<Product> li = Product.addProducts();
        public static void displayAllProducts()
        {
           foreach(Product p in li)
            {
                Console.WriteLine(p);
            }
        }
        public static void displayProductById()
        {
            Console.WriteLine("Enter the id");
            int id= Convert.ToInt32(Console.ReadLine());
            Product p = Product.getproductbyId(id);
            Console.WriteLine(p);

        }
        public static void main(string[] args)
        {
            displayAllProducts();
            displayProductById();

        }
    }
}
