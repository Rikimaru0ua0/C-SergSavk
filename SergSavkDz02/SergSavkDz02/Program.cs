using System;

namespace SergSavkDz02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01
            // Первое задание ( минимум из 3 чисел )
            MinOfThree();
            Console.ReadKey();
            // Выполнено первое занание        
            Console.Clear();
            #endregion



            #region 02+03
            //Задание 2 (общий подсчет количества введенных чисел)
            //Задание 3 (отдельный подсчет суммы всех нечетных положительных чисел
            // Условием выхода будет введенный 0
            Console.WriteLine("Добро пожаловать в программу подсчета чисел и \n" +
                    "Подсчета суммы нечетных положительных чисел\n" +
                    "вводите числа, после введения 0 начнетьтся просчет ");
            int num = Convert.ToInt32(Console.ReadLine());

            int numSum = 0;
            int sumOddAndPositive = 0;
            while (num != 0)
            {
                if (num % 2 != 0 && num > 0)
                {
                    sumOddAndPositive += num;
                }
                numSum++;
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Общее количество введеных чисел {0} \n" +
                "А сумма всех положительных нечетных чисел равно {1}", numSum, sumOddAndPositive);
            Console.ReadKey();
            //Конец 2 и 3 задания
            Console.Clear();
            #endregion

            #region 04
            //Задание 4 Проверка логина и пароля
            string login = "root";
            string password = "GeekBrains";
            int attempt = 3;

            do
            {
                Console.WriteLine("Авторизуйтесь, введите логин: ");
                string login_tmp = Console.ReadLine();
                Console.WriteLine("Авторизуйтесь, введите пароль: ");
                string password_tmp = Console.ReadLine();
                if (login_tmp == login && password == password_tmp)
                {
                    Console.WriteLine("Добро пожаловать Админ");
                    break;
                }
                else
                {
                    Console.WriteLine("Веден неверный логин или пароль");
                    attempt--;
                    if (attempt > 0)
                        Console.WriteLine("Количество попыток " + attempt);
                    else
                        Console.WriteLine("Вы изчерпали лимит попыток ");
                }
            } while (attempt > 0);
            Console.ReadKey();
            // Задание 4 сделано
            Console.Clear();
            #endregion

            #region 05
            //Задание 5 Индекс массы и нормализация веса
            double n1, n2;
            Console.WriteLine("Программа позволит узнать ваш индекс массы и даст подсказку ");
            while (true)
            {
                Console.WriteLine("Введите ваш вес в килограммах, одной сплошной цифрой");
                bool tryN1 = double.TryParse(Console.ReadLine(), out n1);
                if (tryN1 == true)
                {
                    Console.WriteLine("Ваш вес состовляет " + n1 + " кг");
                    break;
                }
                else
                    Console.WriteLine("Неправильный формат ввода, повтор");
            }

            while (true)
            {
                Console.WriteLine("Введите ваш рост в свнтиметрах, одной сплошной цифрой");
                bool tryN2 = double.TryParse(Console.ReadLine(), out n2);
                if (tryN2 == true)
                {
                    Console.WriteLine("Ваш рост состовляет " + n2 + " см");
                    break;
                }
                else
                    Console.WriteLine("Неправильный формат ввода, повтор");
            }
            Console.WriteLine("Вычисляем ваш индекс массы");
            double resultMass = n1 / Math.Pow(n2 / 100, 2);
            Console.WriteLine(Math.Round(resultMass, 2));
            double needMass = Math.Abs(Math.Round(21 * Math.Pow(n2 / 100, 2) - resultMass * Math.Pow(n2 / 100, 2), 2));


            if (resultMass >= 18.5 && resultMass <= 25)
                Console.WriteLine("Все отлично, ты секси, ты просто персик ");
            else if (resultMass < 18.5)
                Console.WriteLine("Задохлик, тебе нужно больше кушать и набрать " + needMass + " кг");
            else if (resultMass > 25)
                Console.WriteLine("Кто то жирный как поезд пассажирный, нужно скинуть " + needMass + " кг");

            Console.ReadKey();
            // Конец задания 5 Индекс массы и нормализация веса
            Console.Clear();
            #endregion

            #region 06
            // Задача номер 6 Кол-во хороших чисел 
            DateTime start = DateTime.Now;
            for (int i = 1; i <= 1_000_000; i++)
            {
                int n = i;
                int numSumSecond = 0;
                while (n != 0)
                {
                    numSumSecond = numSumSecond + n % 10;
                    n = n / 10;
                }
                if (i % numSumSecond == 0)
                {
                    Console.WriteLine(i + " хорошее число");
                }
            }
            DateTime finish = DateTime.Now;
            Console.WriteLine("Время просчета " + (finish - start));
            Console.ReadKey();
            // Конец задачи номер 6 
            #endregion

            #region 07
            // Начало 7 задачи
            Console.WriteLine("Выводим с помощью рекурсии числа от а до б");
            Console.WriteLine("Введите а ");
            int aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите б ");
            int bb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(PrintNumber(aa, bb));

            Console.ReadKey();
            // наверное конец 7 задачи
            #endregion

            #region 07a
            //Начало 7 а задачи(тяжко мне даеться рекурсия) суммирование идет от a до б(б не входит в диапазон сумирования)
            Console.WriteLine("Выводим с помощью рекурсии сумму чисел от а до б (б невходит в сумму)");
            Console.WriteLine("Введите а ");
            int aaa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите б ");
            int bbb = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("сумма чисел " + PrintNumberSum(aaa, bbb)); // сумма чисел он 1 до 5
            Console.ReadKey();
            Console.Clear();
            // Конец 7 а задачи
            #endregion

            Console.WriteLine("Конец домашки, рекурсия это сложно!!! ");
            Console.ReadKey();

        }

        static int PrintNumber(int a, int b)
        {
            if (a == b)
            {
                return b;
            }
            else
            {
                Console.WriteLine(a);
                return PrintNumber(a + 1, b);
            }
        }
        static int PrintNumberSum(int a, int b)
        {
            if (a == b)
                return 0;
            else
            {
                int aPlus1 = a + 1;
                return PrintNumberSum(aPlus1, b) + a;
            }
        }
        static int MinOfThree()
        {
            for (int i = 0, minNumber = 0, number; i < 3; i++)
            {

                if (i == 0)
                {
                    Console.WriteLine("Введите три числа, программа найдет наименьшее из трех");
                    Console.WriteLine("Введите  " + (i + 1) + " ое " + "число");
                    number = Convert.ToInt32(Console.ReadLine());
                    minNumber = number;

                }
                else if (i > 0)
                {
                    Console.WriteLine("Введите  " + (i + 1) + " ое " + "число");
                    number = Convert.ToInt32(Console.ReadLine());
                    minNumber = Math.Min(minNumber, number);
                    if (i == 2)
                    {
                        Console.WriteLine(" Минимальное число из трех " + minNumber);
                        return minNumber;
                    }
                }
            }
            return 0;
        }
    }
}