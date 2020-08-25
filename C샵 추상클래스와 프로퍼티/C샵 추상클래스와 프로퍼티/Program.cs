using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C샵_추상클래스와_프로퍼티
{
    abstract class Product
    {
        private static int serial = 0;
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }
        abstract public DateTime ProductDate
        {
            get; set;
        }
    }

    class MyProduct : Product
    {
        public override DateTime ProductDate
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new MyProduct() {ProductDate = new DateTime(2002, 12, 30) };
            Console.WriteLine($"Product : {product.SerialID} Product Date : {product.ProductDate}"); 
        }
    }
}
