using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Упражнение 4.1 Написать программу, которая читает с экрана число от 1 до 365 (номер дня в году), переводит этот число в месяц и день месяца.Например, число 40 соответствует 9
            //февраля(високосный год не учитывать).
            Console.WriteLine("упражнение 4.1");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня в году (1-365):");
            int dayNumber = int.Parse(Console.ReadLine());

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "", "январь", "февраль", "март", "апрель", "май", "июнь", "июль", "август", "сентябрь", "октябрь", "ноябрь", "декабрь" }; //массив названий месяцев

            int month = 0;
            int day = 0;
            int daysSoFar = 0;

            for (int i = 1; i <= 12; i++)  //перебираем все месяцы
            {
                if (dayNumber > daysSoFar + daysInMonth[i])
                {
                    daysSoFar += daysInMonth[i];
                }
                else
                {
                    month = i;
                    day = dayNumber - daysSoFar;
                    break;
                }


                Console.WriteLine($"Это {day} {monthNames[month]}");
            }
            //Упражнение 4.2 Добавить к задаче из предыдущего упражнения проверку числа введенного
            //пользователем.Если число меньше 1 или больше 365, программа должна вырабатывать
            //исключение, и выдавать на экран сообщение.
            Console.WriteLine("упражнение 4.2");
            Console.WriteLine("Введите номер дня в году (1-365):");
            try
            {
                int dayNumber = int.Parse(Console.ReadLine());

                if (dayNumber < 1 || dayNumber > 365)
                {
                    throw new ArgumentOutOfRangeException("Номер дня должен быть от 1 до 365!");
                }


                int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                string[] monthNames = { "", "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };

                int month = 0;
                int day = 0;
                int daysSoFar = 0;

                for (int i = 1; i <= 12; i++)
                {
                    if (dayNumber > daysSoFar + daysInMonth[i])
                    {
                        daysSoFar += daysInMonth[i];
                    }
                    else
                    {
                        month = i;
                        day = dayNumber - daysSoFar;
                        break;
                    }
                }

                Console.WriteLine($"Это {day} {monthNames[month]}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка! {ex.Message}");
            }
            //Домашнее задание 4.1 Изменить программу из упражнений 4.1 и 4.2 так, чтобы она учитывала год(високосный или нет). Год вводится с экрана. (Год високосный, если он
            //делится на четыре без остатка, но если он делится на 100 без остатка, это не високосный год.Однако, если он делится без остатка на 400, это високосный год.)    
            Console.WriteLine("домашнее задание 4.1");
            Console.WriteLine("Введите год:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите день (1-366):");
            int dayOfYear = int.Parse(Console.ReadLine());

            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "", "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0) // проверка на високосный год 
            {
                daysInMonth[2] = 29;
            }

            int month = 0;
            int day = 0;
            int daysSoFar = 0;

            for (int i = 1; i <= 12; i++)
            {
                if (dayOfYear > daysSoFar + daysInMonth[i])
                {
                    daysSoFar += daysInMonth[i];
                }
                else
                {
                    month = i;
                    day = dayOfYear - daysSoFar;
                    break;
                }
            }

            Console.WriteLine($"Это {day} {monthNames[month]} {year} года");
        }
    }
}
