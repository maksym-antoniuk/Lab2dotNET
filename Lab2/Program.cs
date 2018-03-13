using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("~~~~~Task - 1~~~~~");

            int positive = 0, negative = 0;
            Console.WriteLine("Введите 3 целых числа: ");
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    if (int.Parse(Console.ReadLine()) < 0) negative++; else positive++;
                }
                Console.WriteLine("Кол-во положительних чисел: " + positive + '\n' + "Кол-во отрицательных чисел: " + negative);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 2~~~~~");

            double A, B, C;
            Console.WriteLine("Введите 3 действительных числа: ");
            try
            {
                A = double.Parse(Console.ReadLine());
                B = double.Parse(Console.ReadLine());
                C = double.Parse(Console.ReadLine());
                if ((A > B && B > C) || (A < B && B < C))
                {
                    A *= 2;
                    B *= 2;
                    C *= 2;
                }
                else
                {
                    A *= -1;
                    B *= -1;
                    C *= -1;
                }
                Console.WriteLine("Новые значения переменных: " + A + ";" + B + ";" + C);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 3~~~~~");

            Console.WriteLine("Введите длину массива: ");
            try
            {
                int[] array3 = new int[int.Parse(Console.ReadLine())];
                Console.WriteLine("Готовый массив : ");
                int temp3 = 1;
                for (int i = 0; i < array3.Length; i++)
                {
                    array3[i] = temp3;
                    temp3 += 2;
                    Console.WriteLine(array3[i] + " ");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 4~~~~~");

            int[,] array4 = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array4[i, j] = random.Next(0, 100);
                    Console.Write(array4[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Нечётные столбцы массива: " + '\n');
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if(i % 2 == 0)
                    {
                        Console.Write(array4[j, i] + " ");
                    }
                }
                Console.Write('\n');
            }

            Console.WriteLine("~~~~~Task - 5~~~~~");

            Console.WriteLine("Введите 2 целых числа А и В, таких что А < B");
            try
            {
                int A5 = int.Parse(Console.ReadLine());
                int B5 = int.Parse(Console.ReadLine());
                if (A5 < B5)
                {
                    int sum5 = 0;
                    for (int i = A5; i <= B5; i++)
                    {
                        sum5 += i * i;
                    }
                    Console.WriteLine("Сумма квадратов: " + sum5);
                }
                else
                {
                    Console.WriteLine("A5 больше чем B5");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 6~~~~~");

            Console.WriteLine("Введите 2 целых положительных числа А и В, таких что А < B");
            try
            {
                int A6 = int.Parse(Console.ReadLine());
                int B6 = int.Parse(Console.ReadLine());
                if (A6 < B6 && A6 > 0 && B6 > 0)
                {
                    Console.WriteLine("Полученный результат :");
                    for (int i = A6; i <= B6; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write(i + " ");
                        }
                        Console.Write('\n');
                    }
                }
                else
                {
                    Console.WriteLine("A5 больше чем B5 или одно из чисел отрицательное");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 7~~~~~");

            Console.WriteLine("Введите целое неотрицательное число");
            try
            {
                int N = int.Parse(Console.ReadLine());
                Console.WriteLine((Math.Truncate(Math.Log(N, 3)) == (Math.Log(N, 3))) ? "TRUE" : "FALSE");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибкаю Неверный формат!");
            }

            Console.WriteLine("~~~~~Task - 8~~~~~");

            Console.WriteLine("Введите процент 0...50");
            try
            {
                int P = int.Parse(Console.ReadLine());
                if (P > 0 || P < 50)
                {
                    int k = 0;
                    double p = P / 100.0;
                    double km = 10.0, sum = 10.0;
                    while (sum < 200)
                    {
                        k++;
                        km += km * p;
                        sum += km;
                    }
                    Console.WriteLine("Количество дней : " + k + ", Суммарный пробег : " + sum);
                }
                else
                {
                    Console.WriteLine("Неверно введен процент");
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
            }

            Console.WriteLine("~~~~~Task - 9~~~~~");

            try
            {
                double res = sum();
                Console.WriteLine("Сумма чисел : " + res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("~~~~~Task - 10~~~~~");

            Console.Write("Введите целое положительное число: ");
            try
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Число отрицательное!");
                }
                else
                {
                    Console.WriteLine("Инверсированное число" + InvertDigits(x));
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }

            Console.WriteLine("~~~~~Task - 11~~~~~");

            Console.Write("Введите сторону треугольника: ");
            try
            {
                double x = double.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Число отрицательное!");
                }
                else
                {
                    double p = 0, s = 0;
                    TrianglePS(x, out p, out s);
                    Console.WriteLine("Периметр : " + p + " Площадь : " + s);
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }

            Console.WriteLine("~~~~~Task - 12~~~~~");

            int x12 = random.Next(0, 100);
            int y12 = random.Next(0, 100);
            Console.WriteLine("X=" + x12 + " Y=" + y12);
            MinMax(ref x12, ref y12);
            Console.WriteLine("X=" + x12 + " Y=" + y12);

            Console.WriteLine("~~~~~Task - 13~~~~~");

            Console.WriteLine("Сумма чисел" + sum(1, 3, 4, 5, 67, 8, 6, 4, 65));

            Console.WriteLine("~~~~~Task - 14~~~~~");

            Console.Write("Введите целое положительное число: ");
            try
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("Число отрицательное!");
                }
                else
                {
                    Console.WriteLine("Сумма цифр: " + DigitSum(x));
                }
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат ввода!");
            }

            Console.WriteLine("~~~~~Task - 15~~~~~");

            double rezult = enumOperation(10, 5, operations.div);
            Console.WriteLine("Операция с enum. Результат 10 div 5 = " + rezult + '\n');

            Console.WriteLine("~~~~~Task - 16~~~~~");

            Class1.structureTask();

            Console.ReadKey();
        }
        ///////////////////////////////////////////////////
        static double sum()
        {
            Console.WriteLine("Введите 2 числа:");
            try
            {
                return double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Ошибка. Неверный формат!!!");
                throw new Exception();
            }
        }

        ///////////////////////////////////////////////

        static int InvertDigits(int k)
        {
            char[] charArray = k.ToString().ToCharArray();
            Array.Reverse(charArray);
            return int.Parse(new string(charArray));
        }

        /////////////////////////////////////////////

        static void TrianglePS(double a, out double p, out double s)
        {
            p = 3 * a;
            s = (a * a * Math.Sqrt(3)) / 4;
        }

        ////////////////////////////////////////////

        static void MinMax(ref int x, ref int y)
        {
            if (x > y)
            {
                int temp = x;
                x = y;
                y = temp;
            }
        }

        ////////////////////////////////////////////

        static int sum(params int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            return sum;
        }

        //////////////////////////////////////////

        static int DigitSum(int k)
        {
            int sum = k % 10;
            if (k != 0)
            {
                sum += DigitSum(k / 10);
            }
            return sum;
        }

        ///////////////////////////////////////////

        public enum operations { add, sub, mul, div };

        static double enumOperation(double a, double b, operations op)
        {
            double rezult = 0;
            switch ((int)op)
            {
                case 0:
                    rezult = a + b;
                    break;
                case 1:
                    rezult = a - b;
                    break;
                case 2:
                    rezult = a * b;
                    break;
                case 3:
                    rezult = a / b;
                    break;
            }
            return rezult;
        }
    }
}
