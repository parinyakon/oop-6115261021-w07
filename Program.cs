using System;

namespace oop_6115261021_w07
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Nitat", "Ninchawee", 20000, 10, 2, 2);
            Lecturer l1 = new Lecturer("Nitat", "Ninchawee", 20000, 10, 10, 20, 20, 20, 30);
            Staff s1 = new Staff("Nitat", "Ninchawee", 20000, 10, 10, 20, 60);
                 
            Console.WriteLine(l1.ToString());
            Console.WriteLine(s1.ToString());
        }
    }
}
