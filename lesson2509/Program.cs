using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson2509
{
    class Program
    {
        enum Cards
        {
            Six = 6,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
            Ace
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание1");
            int chislo = Convert.ToInt32(Console.ReadLine());
            int a, b, c;
            a = chislo / 100;
            b = chislo / 10 % 10;
            c = chislo % 10;
            if (chislo==a+b*10+c*100)
            {
                Console.WriteLine("Palindrom:{0}",chislo);
            }
            else
            {
                Console.WriteLine("Not cool");
            }

            Console.WriteLine("Задание2");
            double stor1,stor2,diametr,prohod;
            stor1 = Convert.ToDouble(Console.ReadLine());
            stor2 = Convert.ToDouble(Console.ReadLine());
            diametr = Convert.ToDouble(Console.ReadLine());
            if (stor1 < stor2)
                prohod = stor1 + 2;
            else
            {
                prohod = stor2 + 2;
                if (diametr <= prohod)
                { Console.WriteLine("Голова проходит"); }
                else
                { Console.WriteLine("go cry"); }

                Console.WriteLine("Задание3");
                int dninedeli = Convert.ToInt32(Console.ReadLine());
                switch (dninedeli)
                {
                    case 1:
                        Console.WriteLine("понедельник");
                        break;
                    case 2:
                        Console.WriteLine("вторник");
                        break;
                    case 3:
                        Console.WriteLine("среда");
                        break;
                    case 4:
                        Console.WriteLine("четверг");
                        break;
                    case 5:
                        Console.WriteLine("пятница");
                        break;
                    case 6:
                        Console.WriteLine("суббота");
                        break;
                    case 7:
                        Console.WriteLine("воскресенье");
                        break;
                    default:
                        Console.WriteLine("некрутонеклассноплакаем");
                        break;
                }

                Console.WriteLine("Задание4");
                int number = Convert.ToInt32(Console.ReadLine());
                try
                {
                    number =Convert.ToInt32(Console.ReadLine()) ;
                }
                catch (Exception)
                {
                    Console.WriteLine("исключение");
                }
                finally
                {
                    if (number > 5 && number < 15)
                    {
                        Console.WriteLine((Cards)number);
                    }
                    else
                    {
                        Console.WriteLine("Карта под таким номером не определена!");
                    }
                }

                Console.WriteLine("Задание5");
                int r = 6370;
                double h;
                for (double d = 1; d < 10; d++)
                {
                    h = Math.Sqrt((r + d) * (r + d) - r * r);
                    Console.WriteLine(h);
                }

                Console.WriteLine("Задание6");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < 10; i++)
                {
                    Console.WriteLine(n + "*" + i + "=" + Convert.ToInt32(n * i));
                }

                Console.WriteLine("Задание7");
                double answer=0;
                int count = 0, sum = 0;
                bool flag = true;
                try
                {
                    int temp;
                    while (flag)
                    {

                        temp = Convert.ToInt32(Console.ReadLine());
                        if (temp >= 0)
                        {
                            sum += temp;
                            count++;
                        }
                        else
                        {
                            flag = false;
                        }

                    }
                    answer = (double)sum / count;
                }
                catch (Exception)
                {

                    Console.WriteLine("Ошибка!");
                }
                finally
                {
                    if (count != 0)
                    {
                        Console.WriteLine(answer);
                    }
                    else
                    {
                        Console.WriteLine(0);
                    }
                }


                Console.WriteLine("Задание8");
                int[] array = new int[10];
                Console.WriteLine("Введите последовательно 10 чисел");
                for (int i = 0; i < 10; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < array.Length; i++)
                {
                    if (i > 0 && array[i] < array[i - 1])
                    {
                        Console.WriteLine((i) + " индекс нарушает возрастание последовательности!");
                        break;
                    }
                    if (i == array.Length - 1)
                    {
                        Console.WriteLine("Возрастающая последовательность!");
                    }
                }

                Console.WriteLine("Задание9");
                int summ = 0;
                count = 1;
                Console.WriteLine("Введите числа");
                flag = true;
                while (flag)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        flag = false;
                        continue;
                    }
                    if (count % 3 == 0)
                    {
                        summ += number;
                    }
                    count++;
                }
                Console.WriteLine(summ);

                Console.WriteLine("Задание10");
                summ = 0;
                count = 1;
                flag = true;
                while (flag)
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number == 0)
                    {
                        goto prikolnenko;
                    }
                    if (count % 3 == 0)
                    {
                        summ += number;
                    }
                    count++;
                }
            prikolnenko:
                {
                    Console.WriteLine(summ);
                }
            }
        }
    }
}
