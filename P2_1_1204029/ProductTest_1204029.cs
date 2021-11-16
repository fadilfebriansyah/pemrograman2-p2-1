using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204029
{
    class ProductTest_1204029
    {
        static void Main(string[] args)
        {
            Book_1204029 product1 = new Book_1204029("Book", "C# Object Oriented Solution", "300");
            DVD_1204029 product2 = new DVD_1204029("Eternal Sunshine of The Spotless Mind", "145");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType , product1.MyTitle , product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType,product2.MyTitle, product2.Duration);
        }
    }
}
