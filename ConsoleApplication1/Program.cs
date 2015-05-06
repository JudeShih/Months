using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入月份");
            int month = int.Parse(Console.ReadLine());
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("冬天");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("春天");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("夏天");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("秋天");
                    break;
                default:
                    Console.WriteLine("不是月份");
                    break;
            }
        }
    }
}
