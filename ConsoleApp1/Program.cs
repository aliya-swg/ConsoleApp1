using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {// Лабораторная 1.
         // Упражнение 2.1. Написать программу, которая спрашивает имя пользователя, и затем приветствует пользователя по имени.
            Console.WriteLine("лабораторная 1");
         // Запрашиваем имя 
            Console.Write("Введите ваше имя:");
            string имя = Console.ReadLine();

         // Выводим приветствие
            Console.WriteLine($"Привет, {имя}");
         // Упражнение 2.2. Написать программу, которой на вход подается два целых числа, на выходе – результат деления одного числа на другое. Предусмотреть обработку исключительной ситуации, возникающей при делении числа на ноль
         // Ввод чисел
            Console.WriteLine("Введите первое число:");
            int первоеЧисло = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int второеЧисло = int.Parse(Console.ReadLine());

            try
            {
                // Деление чисел
                int результат = первоеЧисло / второеЧисло;

                // Вывод результата
                Console.WriteLine($"Результат деления: {результат}");
            }
            catch (DivideByZeroException)
            {
                // Обработка исключения деления на ноль
                Console.WriteLine("Ошибка");
            }
            // Домашнее задание 2.1. Прочитать букву с экрана и вывести на печать следующую за ней букву в алфавитном порядке.
               //  Вводим букву
               Console.Write("Введите букву: ");
               char input = Console.ReadKey().KeyChar;
               char буква = (char)(input + 1);
               Console.WriteLine($"\nСледующая буква: {буква}");
            // Домашнее задание 2.2.Написать программу,которая решает квадратное равнение.Входные данные – коэффициенты уравнения, выходныенйденные корни.
            // Ввод коэффициентов
            Console.WriteLine("Введите коэффициент a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите коэффициент c:");
            double c = double.Parse(Console.ReadLine());

            // Решение квадратного уравнения
            SolveQuadraticEquation(a, b, c);
        }

        // Метод для решения квадратного уравнения
        static void SolveQuadraticEquation(double a, double b, double c)
        {
            // Проверка на случай, когда a = 0
            if (a == 0)
            {
                Console.WriteLine("Это не квадратное уравнение.");
                return;
            }

            // Вычисление дискриминанта
            double discriminant = b * b - 4 * a * c;

            // Решение уравнения
            if (discriminant >= 0)
            {
                // Два действительных корня
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine($"Корни уравнения: x1 = {x1}, x2 = {x2}");
            }
            else
            {
                // Два комплексных корня
                double realPart = -b / (2 * a);
                double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);

                Console.WriteLine($"Корни уравнения: x1 = {realPart} + {imaginaryPart}i, x2 = {realPart} - {imaginaryPart}i");
            }

        }
    }
}
