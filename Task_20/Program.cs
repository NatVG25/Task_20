using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20
{
    class Program
    {
        delegate double MyDelegate(double radius); //создаем делегат
        static void Main(string[] args)
        {
            MyDelegate myDelegate1 = Length; //создаем переменную делегата с ссылкой на метод вычисления длины окружности
            if (myDelegate1 != null)
            {
                double d = myDelegate1(10.23); //через делегат вызовем метод на который он ссылается, при вызове указываем аргументы
                Console.WriteLine(d);      //результат присвоим в переменную d
            }

            MyDelegate myDelegate2 = Square; //создаем переменную делегата с ссылкой на метод вычисления площади круга
            if (myDelegate2 != null)
            {
                double s = myDelegate2(10.23); //через делегат вызовем метод , при вызове указываем аргументы
                Console.WriteLine(s);      //результат присвоим в переменную s
            }
            MyDelegate myDelegate3 = Volume; //создаем переменную делегата с ссылкой на метод вычисления объема шара
            if (myDelegate3 != null)
            {
                double v = myDelegate3(10.23); //через делегат вызовем метод на который он ссылается, при вызове указываем аргументы
                Console.WriteLine(v);      //результат присвоим в переменную v
            }

            Console.ReadKey();
        }
        static double Length(double r)
        {
            Console.WriteLine("Length");
            return 2 * Math.PI * r;
        }
        static double Square(double r)
        {
            Console.WriteLine("Square");
            return Math.PI * Math.Pow(r, 2);
        }
        static double Volume (double r)
        {
            Console.WriteLine("Volume");
            return 4 * (Math.PI * Math.Pow(r, 3))/3;
        }
             
    }
           
}

