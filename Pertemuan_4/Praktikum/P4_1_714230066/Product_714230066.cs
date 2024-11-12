using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714230066
{
    public abstract class Product_714230066
    {
        private string myType;
        private string myTitle;
        public Product_714230066()
        {

        }
        //constructor
        public Product_714230066(string type, string title)
        {
            myType = type;
            myTitle = title;
        }

        //properti untuk mytype
        public string MyType
        {
            get { return myType; }

            set { myType = value; }
        }

        //prop untuk mytitle
        public string MyTitle
        {
            get { return myTitle; }

            set { myTitle = value; }
        }

        //method untuk menampilkan info product
        public abstract void DisplayInfo();
    }
}

