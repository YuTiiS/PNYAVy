using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;


namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {

            MyString p = new MyString();
            MyString Stroka1 = new MyString();
            MyString Stroka2 = new MyString("абвд");
            MyString Stroka3 = new MyString("абвu");
            MyString Stroka4 = new MyString();
            MyString Stroka5 = new MyString();
            MyString Stroka6 = new MyString();
            Stroka4 = Stroka2 + Stroka3;
            char Simvol = 'ы';
            string test;
            int lenght;
            int numOfSpaces;
            int numOfDigits;
            Console.WriteLine("Тест");
            test = Console.ReadLine();
            int i = 5;
            Stroka5 = i;
            i = Stroka5.ToInt(Stroka5);
            Stroka6 = i;
            lenght = p.Lenght(test);
            numOfSpaces = p.NumberOfSpaces(test);
            numOfDigits = p.NumberOfDigits(test);
            Console.WriteLine("Длина строки: \"{0}\" составляет: {1} символов\nКол-во пробелов в строке:{2}, цифр: {3}", test, lenght, numOfSpaces, numOfDigits);

            Stroka1 = "абвгдежзиклм"; // Преобразование типов "string" -> "MyString".
            string str;
            str = Stroka1; // Преобразование типов "MyString" -> "string".

            Console.WriteLine(Stroka2);
            Console.WriteLine(Stroka3);
            if(Stroka2 < Stroka3)
            {
                Console.WriteLine("строка2 < строка3");
            }
            if(Stroka2 > Stroka3)
            {
                Console.WriteLine("строка2 > строка3");
            }
            if (Stroka2==Stroka3)
            {
                Console.WriteLine("строка2 == строка3");
            }
            if (Stroka2!=Stroka3)
            {
                Console.WriteLine("строка2 != строка3");
            }/*
            if (Stroka2 <= Stroka3)
            {
                Console.WriteLine("строка2 <= строка3");
            }
            if (Stroka2 >= Stroka3)
            {
                Console.WriteLine("строка2 >= строка3");
            }*/
            Console.WriteLine(Stroka4);
            Console.WriteLine(Stroka5);
            Console.WriteLine(Stroka6);
            Console.Write("Искомый символ на позиции: ");
            Console.WriteLine(Stroka2.FindSymbol(Simvol));
            Console.WriteLine(p.Replace(Stroka2, 'ф', 'Я'));
            Console.WriteLine("ПЕРЕГРУЗКИ");
            Console.WriteLine(Stroka1);
            Console.WriteLine(p.Substring(Stroka1, 3));
            Console.WriteLine(p.Substring(Stroka1, 3, 6));
            Console.ReadLine();
        }
    }
}
