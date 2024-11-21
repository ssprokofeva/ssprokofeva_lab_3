using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ssprokofeva_lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1.Дана последовательность из 10 чисел. Определить, является ли эта последовательность упорядоченной по возрастанию.В случае отрицательного ответа определить
            //порядковый номер первого числа, которое нарушает данную последовательность.
            //Использовать break.
            // Ввод последовательности (можно заменить на чтение из файла или другого источника)
            Console.WriteLine("задание 1.");
            int[] numbers = new int[10];
            Console.WriteLine("Введите 10 чисел:");
            for (int i = 0; i < 10; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
                }
            }


            bool isOrdered = true;
            int violationIndex = -1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    isOrdered = false;
                    violationIndex = i;
                    break;
                }
            }

            if (isOrdered)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию.");
            }
            else
            {
                Console.WriteLine($"Последовательность НЕ упорядочена по возрастанию. Нарушение на позиции: {violationIndex + 1}");
            }
            // задание 2. Игральным картам условно присвоены следующие порядковые номера в зависимости их достоинства: «валету» — 11, «даме» — 12, «королю» — 13, «тузу» — 14.
            //Порядковые номера остальных карт соответствуют их названиям(«шестерка» «девятка» и т.п.).По заданному номеру карты k(6 <= k <= 14) определить достоинство
            //соответствующей карты. Использовать try-catch-finally.
            Console.WriteLine("задание 2.");
            Console.Write("Введите номер карты (6-14): ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int k))
            {
                Console.WriteLine("Ошибка: Введите целое число.");
                return;
            }

            try
            {
                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть в диапазоне от 6 до 14.");
                }

                string cardValue;
                switch (k)
                {
                    case 11: cardValue = "Валет"; break;
                    case 12: cardValue = "Дама"; break;
                    case 13: cardValue = "Король"; break;
                    case 14: cardValue = "Туз"; break;
                    default: cardValue = k.ToString(); break;
                }

                Console.WriteLine($"Достоинство карты: {cardValue}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message} Допустимый диапазон: 6-14.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла непредвиденная ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершена.");
                // задание 3. Напишите программу, которая принимает на входе строку и производит выходные данные в соответствии со следующей таблицей:
                Console.WriteLine("задание 3.");
                Console.WriteLine("Ведите имя");
                string input = Console.ReadLine();
                switch(input.ToLower())
                {
                    case " jabroni":
                        Console.WriteLine("Patron Tequila");
                        break;
                    case "school counselor":
                        Console.WriteLine("Anything with alcohol");
                        break;
                    case "programmer":
                        Console.WriteLine("Hipster craft beer");
                        break;
                    case "bike gang member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "politican":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;

                }

            }
        }
         
        // задание 4.Составить программу, которая в зависимости от порядкового номера дня недели (1, 2,...,7) выводит на экран его название(понедельник, вторник, ..., воскресенье).
        //Использовать enum.
        public enum DaysOfWeek
        {
            Понедельник = 1,
            Вторник,
            Среда,
            Четверг,
            Пятница,
            Суббота,
            Воскресенье
        }
        public static void Main(string[] args)
        {
            Console.Write("Введите порядковый номер дня недели (1-7): ");
            if (int.TryParse(Console.ReadLine(), out int dayNumber))
            {
                if (Enum.IsDefined(typeof(DaysOfWeek), dayNumber))
                {
                    DaysOfWeek day = (DaysOfWeek)dayNumber;
                    Console.WriteLine($"Название дня недели: {day}");
                }
                else
                {
                    Console.WriteLine("Некорректный номер дня недели.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Введите целое число.");
            }
            // задание 5.Создать массив строк. При помощи foreach обойти весь массив. При встрече элемент "Hello Kitty" или "Barbie doll" необходимо положить их в “сумку”, т.е.прибавить к
            // результату.Вывести на экран сколько кукол в “сумке”.
            Console.WriteLine("задание 5.");
        }
            public static void Main(string[] args)
        {
            string[] toys = { "Hello Kitty", "Teddy Bear", "Barbie doll", "Car", "Hello Kitty", "Lego", "Barbie doll" };
            List<string> dolls = new List<string>();
            foreach (string toy in toys)
            {
                if (toy == "Hello Kitty" || toy == "Barbie doll")
                {
                    dolls.Add(toy);
                }
            }
            Console.WriteLine($"Количество кукол в сумке: {dolls.Count}");
              }
    }
            
} 
        
         
    

    

