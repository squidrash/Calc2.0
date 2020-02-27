using System;

namespace _2._0_Калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double x, y, n;
                int op;
                //комментарий

                try
                {
                    Console.WriteLine("Введите число: ");
                    x = double.Parse(Console.ReadLine());

                    try
                    {
                        Console.WriteLine("Введите номер операции");
                        Console.WriteLine("1. +\t2. -\t3. *\t4. /\n" +
                            "5. sin\t6. cos\t7. tg\t8. arctg\n" +
                            "9. Ln\t10. Log10\t11. Exp\t12. !\n" +
                            "13. 1/x\t14. x^y");
                        op = int.Parse(Console.ReadLine());
                        if (op == 5 || op == 6 || op == 7 || op == 8
                            || op == 9 || op == 10 || op == 11 || op == 12 || op == 13)
                        {
                            switch (op)
                            {
                                case 5:
                                    n = Sin(x);
                                    Console.WriteLine(n);
                                    break;
                                case 6:
                                    n = Cos(x);
                                    Console.WriteLine(n);
                                    break;
                                case 7:
                                    n = Tan(x);
                                    Console.WriteLine(n);
                                    break;
                                case 8:
                                    n = ATan(x);
                                    Console.WriteLine(n);
                                    break;
                                case 9:
                                    n = Ln(x);
                                    Console.WriteLine(n);
                                    //Console.WriteLine($"Натуральный логорифм числа{x} = {Math.Log(x)}");
                                    break;
                                case 10:
                                    n = Log10(x);
                                    Console.WriteLine(n);
                                    //Console.WriteLine($"Десятичный логорифм от {x} = {Math.Log10(x)}");
                                    break;
                                case 11:
                                    n = Exp(x);
                                    Console.WriteLine(n);
                                    //Console.WriteLine(Math.Exp(x));s
                                    break;
                                case 12:
                                    try
                                    {
                                        if (x % 1 == 0 && x >= 0)
                                        {
                                            int i = (int)x;
                                            n = Factorial(i);
                                            Console.WriteLine(n);
                                        }
                                        else
                                            throw new Exception("Число должно быть целое и больше 0");
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                                    break;
                                case 13:
                                    n = OneX(x);
                                    Console.WriteLine(n);
                                    break;

                            }
                        }


                        else if (op == 1 || op == 2 || op == 3 || op == 4 || op == 14)
                        {
                            try
                            {
                                Console.WriteLine("Введите второе число");
                                y = double.Parse(Console.ReadLine());
                                switch (op)
                                {
                                    case 1:
                                        n = Sum(x, y);
                                        Console.WriteLine(n);
                                        break;
                                    case 2:
                                        n = Subtract(x, y);
                                        Console.WriteLine(n);
                                        break;
                                    case 3:
                                        n = Multiply(x, y);
                                        Console.WriteLine(n);
                                        break;
                                    case 4:
                                        if (y == 0)
                                            throw new Exception("Деление на 0");
                                        else
                                        {
                                            n = Divide(x, y);
                                            Console.WriteLine(n);
                                        }
                                        break;
                                    case 14:
                                        n = Pow(x, y);
                                        Console.WriteLine(n);
                                        break;
                                    default:
                                        break;

                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Неверный формат. Введите второе число ");
                            }
                        }
                        //else
                        //{
                        //    throw new Exception("Неверная команда");
                        //}
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неизвестная команда");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат. Введите первое число");
                    Console.ReadLine();
                    continue;
                }


                Console.ReadLine();

                static double Sin(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double sinAngle = Math.Sin(angle);
                    return sinAngle;
                    //Console.WriteLine($"Синус угла {degrees} = {sinAngle}");
                }
                static double Cos(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double cosAngle = Math.Cos(angle);
                    return cosAngle;
                    //Console.WriteLine($"Косинус угла {degrees} = {cosAngle}");
                }
                static double Tan(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double tanAngle = Math.Tan(angle);
                    return tanAngle;
                    //Console.WriteLine($"Тангенс угла {degrees} = {tanAngle}");

                }
                static double ATan(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double atanAngle = Math.Atan(angle);
                    return atanAngle;
                    //Console.WriteLine($"Арктангенс угла {degrees} = {atanAngle} ");
                }
                static int Factorial(int x)
                {
                    if (x == 0)
                        return 1;
                    //Console.WriteLine("1s");
                    else
                    {
                        int result = 1;
                        for (int i = 1; i <= x; i++)
                        {
                            result *= i;
                        }
                        return result;
                        //Console.WriteLine($"Факториал числа {x} = {result}");
                    }
                }

                static double Ln(double x)
                {
                    double n = Math.Log(x);
                    return n;
                }
                static double Log10(double x)
                {
                    double n = Math.Log10(x);
                    return n;
                }
                static double Exp(double x)
                {
                    double n = Math.Exp(x);
                    return n;
                }
                static double OneX(double x)
                {
                    double n = 1 / x;
                    return n;
                }
                static double Sum(double x, double y)
                {
                    double n = x + y;
                    return n;
                }
                static double Subtract(double x, double y)
                {
                    double n = x - y;
                    return n;
                }
                static double Multiply(double x, double y)
                {
                    double n = x * y;
                    return n;
                }
                static double Divide(double x, double y)
                {
                    double n = x / y;
                    return n;
                }

                static double Pow(double x, double y)
                {
                    double n = Math.Pow(x, y);
                    return n;
                }
            }
        }
    }
}
