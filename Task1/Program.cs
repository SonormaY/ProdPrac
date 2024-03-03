/*Створити клас КВИТАНЦІЯ з наступними полями: назва послуги, номер квитанції, 
оплачена сума. Включити в нього необхідні конструктори, властивості та методи. 
Включити функції сортування за різними критеріями та пошуку за назвою. 
Вхідні дані зчитувати з текстового файлу. 
Програма повинна містити меню для перевірки всіх можливостей.*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Receipt
{
    public string ServiceName { get; set; }
    public int ReceiptNumber { get; set; }
    public double PaidAmount { get; set; }

    public Receipt(string serviceName, int receiptNumber, double paidAmount)
    {
        ServiceName = serviceName;
        ReceiptNumber = receiptNumber;
        PaidAmount = paidAmount;
    }

    public Receipt()
    {
    }

    public override string ToString()
    {
        return $"Service name: {ServiceName}, Receipt number: {ReceiptNumber}, Paid amount: {PaidAmount}";
    }
}

class Program
{
    static void Main(string[] args)
    {   
        List<Receipt> receipts = new List<Receipt>();
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            string path;
            Console.Write("Enter file name: ");
            path = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("File not found");
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
                continue;
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(' ');
                    receipts.Add(new Receipt(data[0], int.Parse(data[1]), double.Parse(data[2])));
                }
            }
            break;
        }

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Sort by service name");
            Console.WriteLine("2. Sort by receipt number");
            Console.WriteLine("3. Sort by paid amount");
            Console.WriteLine("4. Search by service name");
            Console.WriteLine("5. Show all receipts");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    receipts.Sort((x, y) => x.ServiceName.CompareTo(y.ServiceName));
                    foreach (var receipt in receipts)
                    {
                        Console.WriteLine(receipt);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.Clear();
                    receipts.Sort((x, y) => x.ReceiptNumber.CompareTo(y.ReceiptNumber));
                    foreach (var receipt in receipts)
                    {
                        Console.WriteLine(receipt);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    receipts.Sort((x, y) => x.PaidAmount.CompareTo(y.PaidAmount));
                    foreach (var receipt in receipts)
                    {
                        Console.WriteLine(receipt);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Enter service name: ");
                    string serviceName = Console.ReadLine();
                    var result = receipts.Where(x => x.ServiceName == serviceName);
                    if (!result.Any())
                    {
                        Console.WriteLine("No receipts found");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                    }
                    foreach (var receipt in result)
                    {
                        Console.WriteLine(receipt);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    foreach (var receipt in receipts)
                    {
                        Console.WriteLine(receipt);
                    }
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
        }
    }
}