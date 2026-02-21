using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
                   Логические операторы
                   
                   
                   &&      Сокращенное И
                   ||      Сокращенное ИЛИ
                   &       И
                   ||      ИЛИ
                   !       НЕ (унарный)
 */                  

namespace lesson14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            bool ishaghtemperature = false;

            bool hasnocooling = true;

            if (ishaghtemperature | hasnocooling)
            {
                Console.WriteLine("угроза повреждения процессора!!!");
            }
        }
    }
}
