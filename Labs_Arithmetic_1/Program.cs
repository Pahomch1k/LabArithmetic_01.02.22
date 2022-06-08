using System;

namespace Labs_Arithmetic_1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Ex 1
            //int a, b, x = 0, y = 0; 
            //Console.WriteLine("Введите 2 3ех знач числа ");
            //a = Convert.ToInt32(Console.ReadLine());
            //b = Convert.ToInt32(Console.ReadLine()); 
            //x = (a / 10) - (a / 100 * 10); 
            //y = (b / 10) - (b / 100 * 10); 
            //a = (a / 100 * 100) + (y * 10) + (a - (a / 100 * 100 + x * 10)); 
            //b = (b / 100 * 100) + (x * 10) + (b - b / 100 * 100 - y * 10);
            //Console.WriteLine($"1 - {a}, 2 - {b}");
            #endregion

            #region Ex 2
            //int a, x, y;
            //Console.WriteLine("Введите 4ех знач число ");
            //a = Convert.ToInt32(Console.ReadLine()); 
            //x = a / 1000 + (a / 100 - a / 1000 * 10);
            //y = a - (a / 1000 * 1000 + (a / 100 - a / 1000 * 10) * 100);
            //y = (y / 10) - (y - y / 10 * 10); 
            //Console.WriteLine($"сумма 4 и 3 - {x}, разница 1 и 2 - {y}");
            #endregion

            #region Ex 3
            //int a, x, y;
            //Console.WriteLine("Введите 3ех знач число ");
            //a = Convert.ToInt32(Console.ReadLine()); 
            //x = a / 100 * 10;
            //y = a - ((a / 100 * 100) + (a / 10 - a / 100 * 10) * 10); 
            //Console.WriteLine($"{x + y}");
            #endregion

            #region Ex 4
            //double sum, proc, revenue; 
            //Console.WriteLine("Введите сумму вклада и % годовых");
            //sum = Convert.ToDouble(Console.ReadLine());
            //proc = Convert.ToDouble(Console.ReadLine()); 

            //for (int i = 1; i < 13; i++)
            //{
            //    revenue = (proc / 1000) * sum;
            //    Console.WriteLine($"месяц {i} доход - {revenue}");
            //    sum += revenue;
            //}
            #endregion

            #region Ex 5
            //int sum, value, sdacha, sht;
            //Console.WriteLine("Введите Сколько у васденег и сколько стоит 1ед товара ");
            //sum = Convert.ToInt32(Console.ReadLine());
            //value = Convert.ToInt32(Console.ReadLine());
            //sht = sum / value;
            //sdacha = sum - sht * value;
            //Console.WriteLine($"Купить можно - {sht} шт, сдача - {sdacha}");
            #endregion

            #region Ex 6
            //double kg, f;
            //const double fynt = 405.9;
            //Console.WriteLine("Введите Сколько фунтов");
            //f = Convert.ToDouble(Console.ReadLine());
            //kg = f * fynt;
            //Console.WriteLine($"Kg - {kg}");
            #endregion

            #region Ex 7
            //double dlina, shirina, visota, kraska = 0.5;
            //int ProcOkna = 20;
            //Console.WriteLine("Введите длину ");
            //dlina = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите ширину ");
            //shirina = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Введите высоту ");
            //visota = Convert.ToDouble(Console.ReadLine());
            //double P, S, Sfinal;
            //P = (dlina + shirina) * 2;
            //S = P * visota;
            //Sfinal = S - (S * (ProcOkna / 100));
            //Console.WriteLine($"Площадь комнаты - {Sfinal}, Красик уйдет - {Sfinal * kraska} л");
            #endregion

            #region Ex 8
            //int a, x, y;
            //Console.WriteLine("Введите 3ех знач число ");
            //a = Convert.ToInt32(Console.ReadLine());
            //x = a / 100;
            //y = (a - x * 100) / 10;
            //a = (a - (x * 100 + y * 10)) * 100 + y * 10 + x;
            //Console.WriteLine($"{a}");
            #endregion

            #region Ex 9
            //int a;
            //Console.WriteLine("Введите 5и знач число ");
            //a = Convert.ToInt32(Console.ReadLine()); 
            //Console.WriteLine($"{a / 100 + (a % 100) * 1000}");
            #endregion

            #region Ex 10
            int a;
            Console.WriteLine("Введите 5и знач число ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a / 1000 + (a % 1000) * 100}");
            #endregion
        }
    }
}
