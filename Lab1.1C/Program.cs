using System;

namespace Lab1Sh
{
    class Program
    {


        static void Main(string[] args)
        {
            int a, b;                                                       //объявление переменных 
            Console.WriteLine("Lab1.Task1");                                //ввывод текста 
            Console.WriteLine("a+b=c");
            Console.WriteLine("Введите целое число a");
            while (!int.TryParse(Console.ReadLine(), out a))                //проверка на ввод переменных
            {
                Console.WriteLine("Ошибка ввода! Введите целое число a");
            }
            Console.WriteLine("Введите целое число b");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число b");   //проверка на ввод переменных
            }
                Console.WriteLine("Ответ:");
                Console.WriteLine(a + b);                                   //вывод ответа 

            
        }
    }
}
