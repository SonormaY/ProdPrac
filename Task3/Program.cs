//Вхідні дані зчитувати з текстового файлу.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipCollection ships = new ShipCollection();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Add ship");
                Console.WriteLine("2. Remove ship");
                Console.WriteLine("3. Sort by name");
                Console.WriteLine("4. Sort by port");
                Console.WriteLine("5. Sort by tonnage");
                Console.WriteLine("6. Find by name");
                Console.WriteLine("7. Find by port");
                Console.WriteLine("8. Find by tonnage");
                Console.WriteLine("9. Show all ships");
                Console.WriteLine("10. Read from file");
                Console.WriteLine("11. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine() ?? "0");
                switch (choice)
                {
                    case 1:
                    Console.Clear();
                        Console.WriteLine("Enter name: ");
                        string name = Console.ReadLine() ?? "";
                        Console.WriteLine("Enter port: ");
                        string port = Console.ReadLine() ?? "";
                        Console.WriteLine("Enter tonnage: ");
                        int tonnage = int.Parse(Console.ReadLine()  ?? "0");
                        ships.Add(new Ship(name, port, tonnage));
                        Console.WriteLine("Ship added");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine() ?? "";
                        Ship toRemove = ships.FindByName(name);
                        if (toRemove.Name == "Not found")
                        {
                            Console.WriteLine("Ship not found");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        ships.Remove(toRemove);
                        Console.WriteLine("Ship removed");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        ships.SortByName();
                        Console.WriteLine("Sorted by name");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        ships.SortByPort();
                        Console.WriteLine("Sorted by port");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();
                        ships.SortByTonnage();
                        Console.WriteLine("Sorted by tonnage");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.Clear();
                        Console.WriteLine("Enter name: ");
                        name = Console.ReadLine() ?? "";
                        Console.WriteLine(ships.FindByName(name));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.Clear();
                        Console.WriteLine("Enter port: ");
                        port = Console.ReadLine() ?? "";
                        Console.WriteLine(ships.FindByPort(port));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Enter tonnage: ");
                        tonnage = int.Parse(Console.ReadLine() ?? "0");
                        Console.WriteLine(ships.FindByTonnage(tonnage));
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        foreach (var ship in ships)
                        {
                            Console.WriteLine(ship);
                        }
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Enter file name:");
                        string fileName = Console.ReadLine() ?? "";
                        if (!File.Exists(fileName))
                        {
                            Console.WriteLine("File not found");
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        using (StreamReader sr = new StreamReader(fileName))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                string[] data = line.Split(' ');
                                ships.Add(new Ship(data[0], data[1], int.Parse(data[2])));
                            }
                        }
                        break;
                    case 11:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}