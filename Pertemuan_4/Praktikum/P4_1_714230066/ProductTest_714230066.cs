using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230066
{
    internal class ProductTest_714230066
    {
        public static object Product2 { get; private set; }

        static void Main(string[] args)
        {
            Product_714230066 Product1 = new Book_714230066("Book", "C# object oriented Solution", "300");
            DVD_714230066 Product2 = new DVD_714230066("Ethernal Sunshine of the Spotless Mid", "142");

            Product1.DisplayInfo();
            Product2.DisplayInfo();
        }
    }
}
