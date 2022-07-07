using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueandRef
{
    class Program
    {
        public void Show(int x)
        {
            //x= 2;
            x = x*x;
            Console.WriteLine("Call by Value: " + x);
        }
        public void Show1(ref int y)
        {
            //y = 2;
            y = y * y;
            Console.WriteLine("Call by Reference: " + y);
        }
        static void Main(string[] args)
        {
            int x = 10;
            Program p = new Program();
            Console.WriteLine("Before Calling the Value: "+ x);
            p.Show(5);
            Console.WriteLine("After Calling the Value: " + x);


            Console.WriteLine("------Call by Reference------");

            int y = 20;
            Console.WriteLine("Before Calling the Value: " + y);
            p.Show1(ref y);
            Console.WriteLine("After Calling the Value: " + y);
            Console.ReadLine();
        }
    }
}
