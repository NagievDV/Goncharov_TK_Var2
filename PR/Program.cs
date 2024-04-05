using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR
{
   public  class Program
    {
        static public bool GetMark(string p1, string p2, string p3)
        {
            List<int> points = new List<int>();
            while (true)
            {
                Console.Write("Баллов в модуле (1) «Разработка, администрирование и защита баз данных» : ");
                bool flag1 = int.TryParse(p1, out int c);
                if ((flag1) && (c <= 22))
                {
                    points.Add(c);
                    break;
                }
                else
                {
                    return false;
                    //Console.WriteLine("Введены некорректные данные!");
                }
            }
            while (true)
            {
                Console.Write("Баллов в модуле (2) «Разработка модулей программного обеспечения для компьютерных систем» : ");
                bool flag2 = int.TryParse(p2, out int d);
                if ((flag2) && (d <= 38))
                {
                    points.Add(d);
                    break;
                }
                else
                {
                    return false;
                    //Console.WriteLine("Введены некорректные данные!");
                }
            }
            while (true)
            {
                Console.Write("Баллов в модуле (3) «Сопровождение и обслуживание программного обеспечения компьютерных систем» : ");
                bool flag3 = int.TryParse(p3, out int e);
                if ((flag3) && (e <= 20))
                {
                    points.Add(e);
                    break;
                }
                else
                {
                    return false;
                    //Console.WriteLine("Введены некорректные данные!");
                }
            }
            int sum = points.Sum();
            int mark = 0;
            if ((sum >=0) && (sum <= 15))
            {
                mark = 2;
            }
            else if ((sum > 15) && (sum <= 31))
            {
                mark = 3;
            }
            else if ((sum > 31) && (sum <= 55))
            {
                mark = 4;
            }
            else
            {
                mark = 5;
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"Вы набрали {sum} баллов! Ваша оценка: {mark}");
            return true;

        }
        static void Main(string[] args)
        {

            
        }
    }
}
