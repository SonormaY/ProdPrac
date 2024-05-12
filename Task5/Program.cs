using SuperDuperMenuLib;

namespace Task5;
class Subscription
{
    public string Title { get; set; }
    public string Publisher { get; set; }
    public int SubscriptionIndex { get; set; }
    public decimal Cost { get; set; }
}

static class Program
{
    private static SortedDictionary<int, Subscription> subscriptions = new SortedDictionary<int, Subscription>();

    static void Main(string[] args)
    {
        LoadFromFile("subscriptions.txt");

        var menu = new SuperDuperMenu();
        
        menu.AddEntry("Print all subscriptions", PrintAllSubscriptions);
        menu.AddEntry("Search by title", () =>
        {
            Console.Write("Enter title: ");
            SearchByTitle(Console.ReadLine());
        });
        menu.AddEntry("Search by publisher", () =>
        {
            Console.Write("Enter publisher: ");
            SearchByPublisher(Console.ReadLine());
        });
        menu.AddEntry("Search by subscription index", () =>
        {
            Console.Write("Enter subscription index: ");
            SearchByIndex(int.Parse(Console.ReadLine()));
        });
        menu.AddEntry("Insert new subscription", InsertSubscription);
        menu.AddEntry("Delete subscription by index", () =>
        {
            Console.Write("Enter index to delete: ");
            DeleteSubscription(int.Parse(Console.ReadLine()));
        });
        menu.Run();
    }
    static void LoadFromFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                int index = int.Parse(parts[2]);
                subscriptions[index] = new Subscription
                {
                    Title = parts[0],
                    Publisher = parts[1],
                    SubscriptionIndex = index,
                    Cost = decimal.Parse(parts[3])
                };
            }
        }
    }
    static void PrintAllSubscriptions()
    {
        Console.WriteLine("All subscriptions:");
        foreach (var subscription in subscriptions.Values)
        {
            Console.WriteLine($"{subscription.Title}, {subscription.Publisher}, {subscription.SubscriptionIndex}, {subscription.Cost}");
        }
    }
    static void SearchByTitle(string title)
    {
        Console.WriteLine($"Subscriptions with title '{title}':");
        foreach (var subscription in subscriptions.Values)
        {
            if (subscription.Title.ToLower().Contains(title.ToLower()))
            {
                Console.WriteLine($"{subscription.Title}, {subscription.Publisher}, {subscription.SubscriptionIndex}, {subscription.Cost}");
            }
        }
    }
    static void SearchByPublisher(string publisher)
    {
        Console.WriteLine($"Subscriptions by publisher '{publisher}':");
        foreach (var subscription in subscriptions.Values)
        {
            if (subscription.Publisher.ToLower().Contains(publisher.ToLower()))
            {
                Console.WriteLine($"{subscription.Title}, {subscription.Publisher}, {subscription.SubscriptionIndex}, {subscription.Cost}");
            }
        }
    }
    static void SearchByIndex(int index)
    {
        if (subscriptions.ContainsKey(index))
        {
            var subscription = subscriptions[index];
            Console.WriteLine($"Subscription with index {index}: {subscription.Title}, {subscription.Publisher}, {subscription.SubscriptionIndex}, {subscription.Cost}");
        }
        else
        {
            Console.WriteLine($"No subscription with index {index}");
        }
    }
    static void InsertSubscription()
    {
        Console.Write("Enter title: ");
        string title = Console.ReadLine();
        Console.Write("Enter publisher: ");
        string publisher = Console.ReadLine();
        Console.Write("Enter subscription index: ");
        int index = int.Parse(Console.ReadLine());
        Console.Write("Enter cost: ");
        decimal cost = decimal.Parse(Console.ReadLine());

        subscriptions[index] = new Subscription
        {
            Title = title,
            Publisher = publisher,
            SubscriptionIndex = index,
            Cost = cost
        };
    }
    static void DeleteSubscription(int index)
    {
        if (subscriptions.ContainsKey(index))
        {
            subscriptions.Remove(index);
            Console.WriteLine($"Subscription with index {index} deleted");
        }
        else
        {
            Console.WriteLine($"No subscription with index {index}");
        }
    }
}
