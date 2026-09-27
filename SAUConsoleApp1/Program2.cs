using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUConsoleApp1
{
    internal class Program2
    {
        static void Main2(string[] args)

        {
            //จัดระเบียบโค้ด Cart+K+D
            Console.WriteLine("Test Ha Ha");
            Console.WriteLine("ABCDE");//string
            Console.WriteLine('S');//Character
            Console.WriteLine("0123");//Number(byte,short,int,long)
            Console.WriteLine("123.2034");//Number ทศนิยม(Float,double,decimal)
            Console.WriteLine(true); //Boolean
            Console.WriteLine(10 + 20 * 5); //Expression นิพจน์
            Console.Write("+++++++++++++++\n");
            int number = 20;
            int num = 10;
            Console.WriteLine(number+num);
            Console.WriteLine("Number is {0} {1}",number,10*20);
            Console.WriteLine("Number is "+ number + "" + (10*20));
            Console.WriteLine($"Number is {number} {10 * 20}");


        }
    }
}
