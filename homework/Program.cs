using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание1.1");
            double chiclo = Convert.ToDouble(Console.ReadLine());
            if (chiclo < 0)
            { Console.WriteLine(-(chiclo)); }
            else
            { Console.WriteLine(chiclo); }

            Console.WriteLine("Задание1.2");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            if (Math.Abs(a)>Math.Abs(b))
            { Console.WriteLine(a / 2); }
            else { Console.WriteLine("cry,baby"); }

            Console.WriteLine("Задание1.3");
            string zhivotnoe = Console.ReadLine();
            if (zhivotnoe=="alligator")
            { Console.WriteLine("mouthSize = small"); }
            else { Console.WriteLine("wide"); }

            Console.WriteLine("Задание1.4");
            string stroka=Console.ReadLine();
            switch (stroka.ToUpper())
            {
                case "JABRONI":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "SCHOOL COUNSELOR":
                    Console.WriteLine("Anything with Alcohol");
                    break;
                case "PROGRAMMER":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "BIKE GANG MEMBER":
                    Console.WriteLine("Moonshine");
                    break;
                case "POLITICIAN":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "RAPPER":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
            Console.WriteLine("Задание1.5");
            string podstrok = Console.ReadLine();
            bool strokwithEnglish = podstrok.ToLower().Contains("english");
            Console.WriteLine(strokwithEnglish);

            Console.WriteLine("Задание2.1");
            int summa = 0, pr=1;
            for (int i = 0; i <= 8; i++)
            {
                pr *= 3;
                summa += 1 / pr;
            }
            Console.WriteLine(summa);

            Console.WriteLine("Задание2.2");
            double distance = 0;
            double rast = 0;
            int temp = 1;
            double way = 1;
            bool forward = true;
            for (int i = 0; i < 100; i++)
            {
                if (forward)
                {
                    rast += way;
                    distance += way;
                    temp++;
                    way = (double)1 / temp;
                    forward = false;
                }
                else
                {
                    rast += way;
                    distance -= way;
                    temp++;
                    way = (double)1 / temp;
                    forward = true;
                }

            }
            Console.WriteLine("Муж от дома прошел : " + distance + " А общий путь составил : " + rast);

            Console.WriteLine("Задание2.3");
            int[] tempJanuary = new int[31];
            int[] tempMarch = new int[30];
            Random r = new Random();
            int summ = 0;
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                tempJanuary[i] = r.Next(-35, -5);
            }
            for (int i = 0; i < tempJanuary.Length; i++)
            {
                summ += tempJanuary[i];
            }
            Console.WriteLine("Средняя температура в Январе = " + summ / (tempJanuary.Length));
            summ = 0;
            for (int i = 0; i < tempMarch.Length; i++)
            {
                tempMarch[i] = r.Next(-5, 10);
            }
            for (int i = 0; i < tempMarch.Length; i++)
            {
                summ += tempMarch[i];
            }
            Console.WriteLine("Средняя температура в Марте = " + summ / (tempMarch.Length));

            Console.WriteLine("Задание3.1");
            int chisl1 = 1, chisl2 = 2, znam1 = 1, znam2 = 1, chisl3 = 0, znam3 = 0;
            while (Math.Abs(((double)chisl1 / znam1) - ((double)chisl2 / znam2))>0.001)
            {
                chisl3 = chisl1 + chisl2;
                znam3 = znam2 + znam1;
                znam1 = znam2;
                chisl1 = chisl2;
                chisl2 = chisl3;
                znam2 = znam3;
            }
            Console.WriteLine($"{chisl1}/{znam1}");

            Console.WriteLine("Задание3.2");
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                if (i * i > num)
                {
                    Console.WriteLine("Первый квадрат который превосходит введенное число = " + i * i);
                    break;
                }
            }

            Console.WriteLine("Задание3.3");
            int h = 100;
            while (h>=80)
            {
                Console.WriteLine(h);
                h--;
            }
            h = 100;
            do
            {
                Console.WriteLine(h);
            }
            while (h >= 80);

            Console.WriteLine("Задание3.4");
            for (int i = 5000; i > 0;i--)
            {
                if (i%39==0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("Задание3.5a");
            Console.WriteLine();
            temp = 1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < temp; j++)
                {
                    Console.Write("5 ");

                }
                temp++;
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Задание3.5b");
            Console.WriteLine();
            temp = 5;
            for (int i = 0; i < 5; i++)
            {
                for (int j = temp; j > 0; j--)
                {
                    Console.Write("1 ");
                }
                Console.WriteLine();
                temp--;
            }
            Console.WriteLine();

            Console.WriteLine("Задание доп");
            Console.WriteLine("a");
            Console.WriteLine("Введите номер вертикали где сейчас находится ладья?");
            byte x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите номер горизонтали где сейчас находится ладья?");
            byte y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите вертикаль куда она переместится?");
            byte dx = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Введите горизонталь куда она переместится?");
            byte dy = Convert.ToByte(Console.ReadLine());
            if (dx == x || dy == y)
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("b");
            Console.WriteLine("На какой вертикали слон?");
            x = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("На какой горизонтали слон?");
            y = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("На какой вертикали он будет?");
            dx = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("На какой горизонтали он будет?");
            dy = Convert.ToByte(Console.ReadLine());
            if (Math.Abs(dx - x) == Math.Abs(dy - y))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("в");
            Console.WriteLine("На какой вертикали король?");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали король?");
            y = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой вертикали он будет?");
            dx = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали он будет?");
            dy = byte.Parse(Console.ReadLine());
            if (Math.Abs(dx - x) <= 1 && Math.Abs(dy - y) <= 1)
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("г");
            Console.WriteLine("На какой вертикали ферзь?");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали ферзь?");
            y = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой вертикали он будет?");
            dx = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали он будет?");
            dy = byte.Parse(Console.ReadLine());
            if ((dx == x || dy == y) || (Math.Abs(dx - x) == Math.Abs(dy - y)))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("д");
            Console.WriteLine("На какой вертикали белая пешка?");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали белая пешка?");
            y = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой вертикали она будет?");
            dx = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали она будет?");
            dy = byte.Parse(Console.ReadLine());
            Console.WriteLine("Находится ли фигура на той клетке куда идет пешка?true/false");
            bool isEmpty = bool.Parse(Console.ReadLine());
            if ((dy - y == 1 && dx - x == 0) || (isEmpty && dx - x == 1 && dy - y == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("е");
            Console.WriteLine("На какой вертикали черная пешка?");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали черная пешка?");
            y = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой вертикали она будет?");
            dx = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали она будет?");
            dy = byte.Parse(Console.ReadLine());
            Console.WriteLine("Находится ли фигура на той клетке куда идет пешка?true/false");
            isEmpty = bool.Parse(Console.ReadLine());
            if ((y - dy == 1 && x - dx == 0) || (isEmpty && x - dx == 1 && y - dy == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.WriteLine("ж");
            Console.WriteLine("На какой вертикали конь?");
            x = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали конь?");
            y = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой вертикали он будет?");
            dx = byte.Parse(Console.ReadLine());
            Console.WriteLine("На какой горизонтали он будет?");
            dy = byte.Parse(Console.ReadLine());
            if ((Math.Abs(dx - x) == 2 && Math.Abs(dy - y) == 1) || (Math.Abs(dy - y) == 2 && Math.Abs(dx - y) == 1))
            {
                Console.WriteLine("Такой ход возможен!");
            }
            else
            {
                Console.WriteLine("Невозможный ход!");
            }

            Console.ReadKey();
        }
    }
}
