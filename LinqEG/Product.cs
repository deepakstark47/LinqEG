using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqEG
{
    internal class Product
    {
        int Pid;
        string Pname;
        decimal Pprice;
        public static List<Product> lisP=new List<Product>();
        public Product()
        {

        }
        public Product(int pid, string pname, decimal pprice)
        {
            Pid = pid;
            Pname = pname;
            Pprice = pprice;
        }

        public static List<Product> addProducts()
        {
            lisP.Add(new Product(1, "Pen", 10));
            lisP.Add(new Product(2, "Pencil", 4));
            lisP.Add(new Product(3, "Eraser", 5));
            return lisP;
        }

        public static  Product getproductbyId(int id)
        {
            Product p = (from i in lisP where i.Pid == id select i).SingleOrDefault();
            return p;
        }

        public override string ToString()
        {
            return String.Format("pid:"+Pid+" pname:"+Pname+" pprice:"+Pprice);
        }




    }
}
