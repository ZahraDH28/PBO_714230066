using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230066
{
    public class Book_714230066 : Product_714230066
    {
        protected string pageCount;

        public Book_714230066(String type, string title, string pageCount) : base(type, title)
        {
            this.pageCount = pageCount;
        }
        public string PageCount
        {
           get { return pageCount; }
           set { pageCount = value; }
        }
        //implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
