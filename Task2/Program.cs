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
            Collection collection = new Collection();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Read from file");
                Console.WriteLine("2. Print");
                Console.WriteLine("3. Sort");
                Console.WriteLine("4. Sort Residental");
                Console.WriteLine("5. Sort Administrative by field");
                Console.WriteLine("6. Part 2");
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
                        Console.Clear();
                        List<Residental> residentals = new List<Residental>();
                        foreach (House house in houses)
                        {
                            if (house is Residental)
                            {
                                residentals.Add(house as Residental);
                            }
                        }
                        residentals.Sort();
                        foreach (Residental residental in residentals)
                        {
                            residental.Print();
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        List<Administrative> administratives = new List<Administrative>();
                        foreach (House house in houses)
                        {
                            if (house is Administrative)
                            {
                                administratives.Add(house as Administrative);
                            }
                        }
                        Console.WriteLine("Sort by:");
                        Console.WriteLine("1. Name");
                        Console.WriteLine("2. Floors");
                        Console.WriteLine("3. Area");
                        Console.WriteLine("4. Year");
                        Console.WriteLine("5. Price");
                        Console.WriteLine("6. Offices");
                        Console.WriteLine("7. Parking");
                        Console.WriteLine("8. Security");
                        Console.Write("Choose: ");
                        int sortBy = int.Parse(Console.ReadLine());
                        switch (sortBy)
                        {
                            case 1:
                                administratives.Sort((x, y) => x.Address.CompareTo(y.Address));
                                break;
                            case 2:
                                administratives.Sort((x, y) => x.Floors.CompareTo(y.Floors));
                                break;
                            case 3:
                                administratives.Sort((x, y) => x.Area.CompareTo(y.Area));
                                break;
                            case 4:
                                administratives.Sort((x, y) => x.Year.CompareTo(y.Year));
                                break;
                            case 5:
                                administratives.Sort((x, y) => x.Price.CompareTo(y.Price));
                                break;
                            case 6:
                                administratives.Sort((x, y) => x.Offices.CompareTo(y.Offices));
                                break;
                            case 7:
                                administratives.Sort((x, y) => x.Parking.CompareTo(y.Parking));
                                break;
                            case 8:
                                administratives.Sort((x, y) => x.Security.CompareTo(y.Security));
                                break;
                        }
                        foreach (Administrative administrative in administratives)
                        {
                            administrative.Print();
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("1. Read from file");
                        Console.WriteLine("2. Write to file");
                        Console.WriteLine("3. Print");
                        Console.WriteLine("4. Sort");
                        Console.WriteLine("5. Search");
                        Console.Write("Choose: ");
                        int choice2 = int.Parse(Console.ReadLine());
                        switch (choice2)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Enter file name:");
                                var file = Console.ReadLine();
                                collection.ReadFromFile(file);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case 2:
                                Console.Clear();
                                Console.WriteLine("Enter file name:");
                                var fileName2 = Console.ReadLine();
                                collection.WriteToFile(fileName2);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case 3:
                                Console.Clear();
                                collection.Print();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case 4:
                                Console.Clear();
                                collection.Sort();
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                break;
                            case 5:
                                Console.Clear();
                                Console.WriteLine("Enter search criteria:");
                                var criteria = Console.ReadLine();
                                collection.Search(criteria);
                                Console.WriteLine("Press any key to continue...");
                                Console.ReadKey();
                                break;
                        }
                        break;
                }
            }
        }
    }
}
