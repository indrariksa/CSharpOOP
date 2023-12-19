using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    internal class ProductTest_123456789
    {
        static void Main(string[] args)
        {
            //Product_123456789 myProduct = new Product_123456789();

            //myProduct.MyType = "DVD";

            //Console.WriteLine(myProduct.MyType);

            //Book_123456789 myBook = new Book_123456789("Book", "C# Programming", "100");

            //Console.WriteLine("\"The book {0} has {1} pages\"", myBook.MyTitle, myBook.PageCount);


            Book_123456789 product1 = new Book_123456789("Book", "C# Object Oriented Solution", "300");
            DVD_123456789 product2 = new DVD_123456789("Bagaimana Menjadi Kaya Dalam Semalam", "144");

            Console.WriteLine("Product 1 is a {0} called \"{1}\" and has {2} pages", product1.MyType, product1.MyTitle, product1.PageCount);
            Console.WriteLine("Product 2 is a {0} called \"{1}\" and has {2} minutes duration", product2.MyType, product2.MyTitle, product2.Duration);
        }
    }
}
