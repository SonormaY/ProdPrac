/*Завдання №4. Розробити програму для роботи з вказаними класами. Для кожного
з класів визначити поля, властивості, декілька конструкторів, всі необхідні
методи. Зчитати з файлу дані в один масив, впорядкувати за одним з полів
базового класу. Використати virtual, override, is, as, new, sealed, abstract.*/

//7. На основі базового класу БУДИНОК створити підкласи АДМІНІСТРАТИВНИЙ і ЖИТЛОВИЙ.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<House> houses = new List<House>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Read from file");
                Console.WriteLine("2. Print");
                Console.WriteLine("3. Sort");
                Console.WriteLine("4. Exit");
                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Enter file name:");
                        var fileName = Console.ReadLine();
                        Misc.ReadFromFile(fileName, houses);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        foreach (House house in houses)
                        {
                            house.Print();
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Sorting...");
                        houses.Sort((x, y) => x.Address.CompareTo(y.Address));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        return;
                }
            }
        }
    }
}
