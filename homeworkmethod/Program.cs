using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkmethod
{
    class Program
    {
        enum Months
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December,
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите день года");
            int dayOfYear = Convert.ToInt32(Console.ReadLine());
            if (dayOfYear > 0 && dayOfYear < 366 && year > 0)
            {
                DateTime dateTime = new DateTime(year, 1, 1);
                dateTime = dateTime.AddDays(dayOfYear - 1);
                Console.WriteLine($"Этот день соотвествует - {dateTime.Day} {(Months)dateTime.Month} {year}");
            }
            else
            {
                Console.WriteLine("Неккоректный ввод!");
            }
            Console.ReadKey();
        }
    }
}
