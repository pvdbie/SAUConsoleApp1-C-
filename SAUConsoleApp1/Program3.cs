using System;
using System.Diagnostics.Contracts;

namespace SAUConsoleApp1
{
    internal class Program3
    {
        static void Main3(string[] args)
        {
            //Data Type + Variable
            //เลขจำนวนเต็ม byte เลขไม่เกิน 100,shortไม่เกิน1000,intไม่เกินพันล้าน,long
            int data1 = 200;
            short yearBorn = 2026;
            byte score = 25;
            long money = 1531513135135135l;//ใส่ L ต่อท้าย
            //เลขทศนิยม Float แสดงไม่เกิน6ต่ำแหน่งทศนิยม,double,decimal
            float number = 7.34254f; //6ต่ำแหน่ง ใส่ F ต่อท้าย
            double number1 = 9.83425521561554;//15-16ต่ำแหน่ง
            decimal number3 = 17.1564153138541835438543854163843848343m;//ใส่ m ต่อท้าย
            //ตรรกะ
            bool isStatus = false;
            char grade = 'A'; //Character ตัวเดียว ซิงเกิ้ลโคด
            string fullname = "\"SomJai Jaidee\"\'A\'";//แสดง "",'' ในข้อความต้องมี \นำหน้า "",''
            string myDirectory2 = @"C:\MyFolder\MyFile"; //แสดง \ ใช้ @ นำหน้า
            Console.WriteLine(myDirectory2);
        }
    }
}
