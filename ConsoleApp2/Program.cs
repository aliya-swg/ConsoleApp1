using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {// Задания из файла
       
            Console.WriteLine($"Число e с точностью до десятых: {Math.Round(Math.E, 1)}");
         //Вывести числа 50 и 10 одно под другим
            Console.WriteLine(50);
            Console.WriteLine(10);
          // Вывод чисел столбиком
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
         // Найти периметр квадрата
          // Ввод числа 
            Console.WriteLine("Введите число:");
            int число = int.Parse(Console.ReadLine());

            // Вывод числа, большего на 10
            Console.WriteLine($"Число, большее на 10: {число + 10}");
            // Ввод стороны квадрата
            Console.WriteLine("Введите сторону квадрата:");
            double сторона = double.Parse(Console.ReadLine());

            // Вычисление периметра
            double периметр = 4 * сторона;

            // Вывод периметра
            Console.WriteLine($"Периметр квадрата: {периметр}");
          // Найдите длину окружности и площадь круга
            // Ввод радиуса окружности
            Console.WriteLine("Введите радиус окружности:");
            double радиус = double.Parse(Console.ReadLine());

            // Вычисление длины окружности
            double длинаОкружности = 2 * Math.PI * радиус;

            // Вычисление площади круга
            double площадьКруга = Math.PI * радиус * радиус;

            // Вывод результатов
            Console.WriteLine($"Длина окружности: {длинаОкружности}");
            Console.WriteLine($"Площадь круга: {площадьКруга}");
          // Найти значение y = cos(x)
            // Ввод значения x
            Console.WriteLine("Введите значение x (в радианах):");
            double x = double.Parse(Console.ReadLine());

            // Вычисление значения y = cos(x)
            double y = Math.Cos(x);

            // Вывод результата
            Console.WriteLine($"y = cos(x) = {y}");
            // Найти периметр трапеции
            // Ввод оснований и высоты
            Console.WriteLine("Введите основание a:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите основание b:");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите высоту h:");
            double h = double.Parse(Console.ReadLine());

            // Вычисление боковой стороны
            double боковаяСторона = Math.Sqrt(h * h + ((a - b) / 2) * ((a - b) / 2));

            // Вычисление периметра
            double периметр1= a + b + 2 * боковаяСторона;

            // Вывод периметра
            Console.WriteLine($"Периметр равнобедренной трапеции: {периметр}");
         // Найти стоимость покупки
            // Ввод стоимости 1 кг каждого продукта
            Console.WriteLine("Введите стоимость 1 кг конфет:");
            double ценаКонфет = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг печенья:");
            double ценаПеченья = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость 1 кг яблок:");
            double ценаЯблок = double.Parse(Console.ReadLine());

            // Ввод количества каждого продукта
            Console.WriteLine("Введите количество конфет (кг):");
            double количествоКонфет = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество печенья (кг):");
            double количествоПеченья = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество яблок (кг):");
            double количествоЯблок = double.Parse(Console.ReadLine());

            // Вычисление стоимости покупки
            double стоимостьКонфет = ценаКонфет * количествоКонфет;
            double стоимостьПеченья = ценаПеченья * количествоПеченья;
            double стоимостьЯблок = ценаЯблок * количествоЯблок;
            double общаяСтоимость = стоимостьКонфет + стоимостьПеченья + стоимостьЯблок;

            // Вывод общей стоимости покупки
            Console.WriteLine($"Общая стоимость покупки: {общаяСтоимость}");
         // Вывод строк в одной строке
            Console.WriteLine("Мир Труд Май");

         // Вывод строк в отдельных строках
            Console.WriteLine("Мир");
            Console.WriteLine("Труд");
            Console.WriteLine("Май");
         // Программа меняет местами
            // Ввод чисел
            Console.WriteLine("Введите первое число:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string input2 = Console.ReadLine();

            // Преобразование введенных строк в числа с плавающей точкой 
            // с учетом разных разделителей десятичных дробей
            double num1 = double.Parse(input1.Replace(',', '.'));
            double num2 = double.Parse(input2.Replace(',', '.'));

            // Обмен значениями
            double temp = num1;
            num1 = num2;
            num2 = temp;

            // Вывод результата
            Console.WriteLine($"Первое число: {num1}");
            Console.WriteLine($"Второе число: {num2}");
          // Ввод числа
            Console.WriteLine("Введите число:");
            int число1= int.Parse(Console.ReadLine());

            // Вывод числа с сообщением
            Console.WriteLine($"Вы ввели число: {число}");
          // Вывод информации
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");
          // Генерация и вывод четырех случайных чисел
            Random random = new Random();
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());
            Console.WriteLine(random.Next());
         // Программа для вычисления среднего арифметического и геометрического
            // Ввод чисел
            Console.WriteLine("Введите первое число:");
            int чис1= int.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int чис = int.Parse(Console.ReadLine());

            // Вычисление среднего арифметического
            double среднееАрифметическое = (чис1+ чис)/ 2.0;

            // Вычисление среднего геометрического
            double среднееГеометрическое = Math.Sqrt(чис1* чис);

            // Вывод результатов
            Console.WriteLine($"Среднее арифметическое: {среднееАрифметическое}");
            Console.WriteLine($"Среднее геометрическое: {среднееГеометрическое}");
          // Расстояние  между двумя точками
            // Ввод координат первой точки
            Console.WriteLine("Введите координату x первой точки:");
            double x1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y первой точки:");
            double y1 = double.Parse(Console.ReadLine());

            // Ввод координат второй точки
            Console.WriteLine("Введите координату x второй точки:");
            double x2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите координату y второй точки:");
            double y2 = double.Parse(Console.ReadLine());

            // Вычисление расстояния
            double расстояние = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            // Вывод расстояния
            Console.WriteLine($"Расстояние между точками: {расстояние}");
          // определение времени
            // Ввод количества секунд
            Console.WriteLine("Введите количество секунд:");
            int seconds = int.Parse(Console.ReadLine());

            // Вычисление времени
            int hours = seconds / 3600;
            int minutes = (seconds % 3600) / 60;
            int remainingSeconds = seconds % 60;

            // Вывод результата
            Console.WriteLine($"Прошло полных часов: {hours}");
            Console.WriteLine($"Прошло полных минут с начала часа: {minutes}");
            Console.WriteLine($"Прошло полных секунд с начала минуты: {remainingSeconds}");
            // Определение числа сотен и тысяч
            // Ввод натурального числа
            Console.WriteLine("Введите натуральное число (n > 999):");
            int number = int.Parse(Console.ReadLine());

            // Определение числа сотен и тысяч
            int hundreds = (number / 100) % 10;
            int thousands = number / 1000;

            // Вывод результата
            Console.WriteLine($"Число сотен: {hundreds}");
            Console.WriteLine($"Число тысяч: {thousands}");
         // Востановление числа
           // Ввод числа n
    Console.WriteLine("Введите число n (100 ≤ n ≤ 999, число десятков не равно нулю):");
            int n = int.Parse(Console.ReadLine());

            // Извлечение цифр
            int lastDigit = n % 10;
            int tensDigit = (n / 10) % 10;
            int hundredsDigit = n / 100;

            // Восстановление числа x
            int o= hundredsDigit * 100 + tensDigit * 10 + lastDigit;

            // Вывод результата
            Console.WriteLine($"Исходное число: {o}");
          //пределение угла часовой стрелки
            // Ввод угла часовой стрелки
            Console.WriteLine("Введите угол часовой стрелки (0-360):");
            double hourAngle = double.Parse(Console.ReadLine());

            // Вычисление угла минутной стрелки
            double minuteAngle = hourAngle * 60;

            // Вычисление количества полных часов и минут
            int ho= (int)hourAngle / 360;
            int m = (int)((hourAngle % 360) / 6);

            // Вывод результата
            Console.WriteLine($"Угол минутной стрелки: {minuteAngle} градусов");
            Console.WriteLine($"Прошло полных часов: {ho}");
            Console.WriteLine($"Прошло полных минут: {m}");
         // Минимальное по модулю число
            // Ввод трех чисел
            Console.WriteLine("Введите первое число:");
            double n1= double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double n2= double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double n3 = double.Parse(Console.ReadLine());

            // Нахождение минимального по модулю числа
            double minMagnitude = Math.Min(Math.Abs(n1), Math.Min(Math.Abs(n2), Math.Abs(n3)));

            // Вывод результата
            Console.WriteLine($"Минимальное по модулю число: {minMagnitude}");
         // Нахождение суммы большего и меньшего чисел
            // Ввод трех чисел
            Console.WriteLine("Введите первое число:");
            double numer1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double numer2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double numer3 = double.Parse(Console.ReadLine());

            // Нахождение максимального и минимального чисел
            double max = Math.Max(Math.Max(numer1, numer2), numer3);
            double min = Math.Min(Math.Min(numer1, numer2), numer3);

            // Вычисление суммы
            double sum = max + min;

            // Вывод результата
            Console.WriteLine($"Сумма большего и меньшего чисел: {sum}");
         // Подсчет делителей натурального числа 
            // Ввод натурального числа
            Console.WriteLine("Введите натуральное число:");
            int numb = int.Parse(Console.ReadLine());

            // Подсчет делителей
            int count = 0;
            for (int i = 1; i <= numb; i++)
            {
                if (numb % i == 0)
                {
                    count++;
                }
            }

            // Вывод результата
            Console.WriteLine($"Количество делителей: {count}");
            // Решение кубических уравнений
            // Ввод коэффициентов уравнения
            Console.WriteLine("Введите коэффициент A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент B:");
            int B = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент C:");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент D:");
            int D = int.Parse(Console.ReadLine());

            // Поиск корней методом перебора
            for (int p = -100; x <= 100; x++)
            {
                if (A * p * p * p + B * p * p + C * p + D == 0)
                {
                    Console.WriteLine($"Корень уравнения: {x}");
                }
            }
          // Вычисление элемента геометрической прогрессии
            // Ввод первого и второго элементов
            Console.WriteLine("Введите первый элемент прогрессии:");
            int firstElement = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент прогрессии:");
            int secondElement = int.Parse(Console.ReadLine());

            // Ввод номера элемента
            Console.WriteLine("Введите номер элемента:");
            int elementNumber = int.Parse(Console.ReadLine());

            // Вычисление шага
            int step = secondElement - firstElement;

            // Вычисление элемента прогрессии
            int elementValue = firstElement + (elementNumber - 1) * step;

            // Вывод результата
            Console.WriteLine($"Элемент прогрессии с номером {elementNumber}: {elementValue}");
            // Диалог
            // Здороваемся
            Console.WriteLine("Привет!");

            // Спрашиваем имя
            Console.WriteLine("Как тебя зовут?");
            string userName = Console.ReadLine();

            // Приветствуем
            Console.WriteLine($"Привет, {userName}!");

            // Задаем вопрос
            Console.WriteLine("Знаешь ли ты что-нибудь о тайной комнате?");
            Console.ReadLine();

            // Ответ
            Console.WriteLine("Да.");

            // Задаем второй вопрос
            Console.WriteLine("Можешь рассказать?");
            Console.ReadLine();

            // Ответ
            Console.WriteLine("Нет.");
         
        



}
    }
}
