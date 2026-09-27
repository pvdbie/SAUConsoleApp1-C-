using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAUConsoleApp1
{
    internal class Program4
    {
        //Snppet svm สำหรับ Main(), cwสำหรับ Console.WriteLine
        static void Main4(string[] args)
        {
            //Array ใช้กับตัวแปร 1 ตัว เก็บได้มากกว่า 1 ข้อมูล แต่ทุกข้อมูลต้องเป็นชนิดเดียว และ แต่ละข้อมูลมี index กำกับ
            //ขนาดของ Array เพิ่มลดไม่ได้
            string[] sport = { "football", "run", "volleybal", "tennis", "softball" };
            Console.WriteLine(sport[3]);//tennis
            sport[4] = "footsal";
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            foreach (var item in sport) //foreach เข้าไปแสดงข้อมูลของ Array ทุกตัวแล้วแสดงผลออกมา
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            int[] score = new int[5];
            for (int i = 0; i<score.Length;i++)
            {
                score[i] = (i+1) * 100;
            }
            foreach (var item in score) //foreach เข้าไปแสดงข้อมูลของ Array ทุกตัวแล้วแสดงผลออกมา
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            //ต้องการให้แสดงข้อมูลทุกข้อมูลใน score โดยใช้ for ธรรมดา
            for (int i = 0; i < score.Length; i++)
            {
                //score[i] = (i + 1) * 100;
                Console.WriteLine(score[i]);
            }

        }
    }
}
