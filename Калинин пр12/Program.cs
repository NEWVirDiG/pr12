using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] namesYORIGIRLS = { "Anna", "Katya", "Elena",
            //    "Vika", "Jena" , "Jalina", "Lilya", "Oksana","Luba"};

            //string[] name1 = { "Anna",
            //    "Katya", "Elena",
            //    "Vika", "Luba" };
            //string[] name2 = { "Anna",
            //    "Katya", "Oksana" };
            //string[] name3 = { "Anna",
            //    "Katya", "Luba", "Elena",
            //    "Jena", "Vika" };
            //Console.WriteLine("Имя в каждом классе");
            //Print_mnozh(name1.Intersect(name2).Intersect(name3));
            //Console.WriteLine("Нет ни в одном классе");
            //Print_mnozh(namesYORIGIRLS.Except(name1).Except(name2).Except(name3));
            //Console.WriteLine("Есть хотя бы в одном классе");
            //Print_mnozh(name1.Union(name2).Union(name3).
            //    Except(name1.Intersect(name2).Intersect(name3)));
            //Console.ReadKey();

        //}
        //private static void Print_mnozh(IEnumerable<string> res)
        //{
        //    foreach (string s in res)
        //        Console.WriteLine(s);

            string line = Console.ReadLine();//строка с клавиатуры
            char[] chars = line.ToCharArray();//множество символов строки
            char[] glasletter = { 'a', 'e', 'u', 'i', 'o', 'y' };//множество гласных букв 
            Console.WriteLine(chars.Intersect(glasletter).Count());// кол глассных в исходной строке
            int a = chars.Intersect(glasletter).Count();
            char[] sogletter = { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', };//множество гласных букв 
            Console.WriteLine(chars.Intersect(sogletter).Count());// кол сог в исходной строке
            int b = chars.Intersect(sogletter).Count();
            if(a > b)
            {
                Console.WriteLine("Гласных больше");

            }
            else
            {
                Console.WriteLine("Согласных больше");
            }

          Console.ReadKey();
        }
    }
}
