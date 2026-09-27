using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUConsoleApp1
{
    internal class Program5
    {
        //enum กำหนดค่าขึ้นมาเอง
        enum Color
        {
            //ทุกข้อมูลจะมีค่าเป็นตัวเลขกำกับโดยเริ่มที่0
            Red , Green , Blue ,Yellow ,Black,Gray
        }
        enum Month
        {
            Jenuary,February,May
        }
        static void Main5(string[] args)
        {
            Color data1;
            data1 = Color.Yellow;
            Console.WriteLine(data1);
            Console.WriteLine((int)data1);
            Month data2 = Month.May;
            Console.WriteLine(data2);
            
        }
    }
}
