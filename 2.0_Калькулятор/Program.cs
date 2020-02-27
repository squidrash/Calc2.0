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
                double x, y, z;
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
                            z = Calculate1(x, op);
                            Console.WriteLine(z);

                        }


                        else if (op == 1 || op == 2 || op == 3 || op == 4 || op == 14)
                        {
                            try
                            {
                                Console.WriteLine("Введите второе число");
                                y = double.Parse(Console.ReadLine());
                                z = Calculate2(x, y, op);
                                Console.WriteLine(z);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Неверный формат числа (2)");
                            }
                            
                        }
                        else
                        {
                            throw new Exception("Неверная команда");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Неверный формат команды");
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Неверный формат. Введите первое число");
                    Console.ReadLine();
                    continue;
                }


                Console.ReadLine();

                static double Calculate1(double x, int op)
                {
                    double n;
                    try
                    {
                        switch (op)
                        {
                            case 5:
                                n = Sin(x);
                                return n;
                            case 6:
                                n = Cos(x);
                                return n;

                            case 7:
                                n = Tan(x);
                                return n;

                            case 8:
                                n = ATan(x);
                                return n;

                            case 9:
                                n = Ln(x);
                                return n;

                            case 10:
                                n = Log10(x);
                                return n;

                            case 11:
                                n = Exp(x);
                                return n;


                            case 12:
                                try
                                {
                                    if (x % 1 == 0 && x >= 0)
                                    {
                                        int i = (int)x;
                                        n = Factorial(i);
                                        return n;
                                    }
                                    else
                                        throw new Exception("Число должно быть целое и больше 0");
                                }
                                catch (Exception)
                                {
                                    throw new Exception("ошибка в факториале");
                                }
                            case 13:
                                n = OneX(x);
                                return n;

                        }
                    }
                    catch(Exception)
                    {
                        throw new Exception("ошибка в catch calculate1");
                    }
                    return n = 123456789;
                    
                }
                static double Calculate2(double x, double y, int op)
                {
                    double n;
                    try
                    {
                        switch (op)
                        {
                            case 1:
                                n = Sum(x, y);
                                return n;
                                
                            case 2:
                                n = Subtract(x, y);
                                return n;
                            case 3:
                                n = Multiply(x, y);
                                return n;
                            case 4:
                                if (y == 0)
                                    throw new Exception("Деление на 0");
                                else
                                {
                                    n = Divide(x, y);
                                    return n;
                                }                                
                            case 14:
                                n = Pow(x, y);
                                return n;
                            default:
                                break;

                        }
                    }
                    catch (Exception)
                    {
                        throw new Exception("ошибка в catch calculate2");
                    }
                    return n= 123456789;
                }

                static double Sin(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double sinAngle = Math.Sin(angle);
                    return sinAngle;                    
                }
                static double Cos(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double cosAngle = Math.Cos(angle);
                    return cosAngle;                    
                }
                static double Tan(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double tanAngle = Math.Tan(angle);
                    return tanAngle;                    

                }
                static double ATan(double degrees)
                {
                    double angle = Math.PI * degrees / 180;
                    double atanAngle = Math.Atan(angle);
                    return atanAngle;                    
                }
                static int Factorial(int x)
                {
                    if (x == 0)
                        return 1;                    
                    else
                    {
                        int result = 1;
                        for (int i = 1; i <= x; i++)
                        {
                            result *= i;
                        }                        
                        return result;                        
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
