using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalc41PLikhodeev
{
    internal class Program
    {
        static double Sum(double a, double b)
        {
            return a + a; //здесь сложение только переменные А, без В
        }
        static double Razn(double a, double b)
        {
            return a - b;
        }
        static double Chastn(double a, double b)
        {
            return a / b;
        }
        static double Proizv(double a, double b)
        {
            return a * b;
        }
        static double Step(double a, double b)
        {
            return Math.Pow(a, b);
        }
        static double Koren(double a)
        {
            return Math.Sqrt(a);
        }
        static double PrChisla(double a)
        {
            return a / 10;
        }
        static double Log(double a)
        {
            return Math.Log(a);
        }
        static double Sin(double a)
        {
            return Math.Sin(a);
        }
        static double Ctg(double a, double b) //здесь должно быть одно входное переменное, то есть без double b
        {
            return Math.Cos(a) / Math.Sin(b);// и вместо b должен а
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие, чтобы получить результат:\n1. сложение\n2. вычитание\n3. деление\n4. умножение\n5. возведение в степень\n6. извлечение корня\n7. процент от числа\n8. Log\n9. Sin\n10. Ctg");
            int fun = Convert.ToInt32(Console.ReadLine());
            switch (fun)
            {
                case 1:
                    Console.Write("Введите переменную a:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите переменную b:");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Sum(a, b));
                    break;
                case 2:
                    Console.Write("Введите переменную a:");
                    double a1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите переменную b:");
                    double b1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Razn(b1, a1)); //здесь входные данные в других местами стоят, вместо а1 b1, стоит b1 a1
                    break;
                case 3:
                    Console.Write("Введите переменную a:");
                    double a2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите переменную b:");
                    double b2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Chastn(a2, b2));
                    break;
                case 4:
                    Console.Write("Введите переменную a:");
                    double a3 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите переменную b:");
                    double b3 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Proizv(a3, b3));
                    break;
                case 5:
                    Console.Write("Введите переменную a:");
                    double a4 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите переменную b (степень):");
                    double b4 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Step(a4, b4));
                    break;
                case 6:
                    Console.Write("Введите переменную a:");
                    double a5 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Koren(a5));
                    break;
                case 7:
                    Console.Write("Введите переменную a:");
                    double a6 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + PrChisla(a6));
                    break;
                case 8:
                    Console.Write("Введите переменную a:");
                    double a7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Log(a7));
                    break;
                case 9:
                    Console.Write("Введите переменную a:");
                    double a8 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Sin(a8));
                    break;
                case 10:
                    Console.Write("Введите переменную a:");
                    double a9 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Результат:" + Ctg(a9,a9));// здесь только одна входная переменная
                    break;
            } 
            Console.ReadKey();
        }
    }
}
