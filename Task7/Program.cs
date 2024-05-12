//Використовуючи запити LINQ, для кожного клієнта обчислити сумарну тривалість занять за всі роки і вивести у вигляді списку по спаданню сумарної тривалості, а при однаковій тривалості впорядковувати за зростанням коду клієнта.
using SuperDuperMenuLib;

namespace Task7;

public class Program
{
  static public void Main(string[] args)
  {
    var clients = ReadFromFile("clients.txt");
    var menu = new SuperDuperMenu();
    var dict = new Dictionary<string, Action>{
      {"Show clients", () => clients.ForEach(Console.WriteLine)},
      {"Show clients sorted", () => clients.OrderBy(x => x.Id).ThenBy(x => x.Year).ThenBy(x => x.Month).ThenBy(x => x.Duration).ToList().ForEach(Console.WriteLine)},
      {"Show clients sorted by total duration", () => clients.GroupBy(x => x.Id).Select(x => new { Id = x.Key, TotalDuration = x.Sum(y => y.Duration) }).OrderByDescending(x => x.TotalDuration).ThenBy(x => x.Id).ToList().ForEach(Console.WriteLine)}
    };
    menu.LoadEntries(dict);
    menu.Run();
  }


  static public List<Client> ReadFromFile(string path)
  {
    var clients = new List<Client>();
    using (var reader = new StreamReader(path))
    {
      while (!reader.EndOfStream)
      {
        var line = reader.ReadLine();
        var values = line.Split(',');
        clients.Add(new Client(int.Parse(values[0]), int.Parse(values[1]), int.Parse(values[2]), int.Parse(values[3])));
      }
    }
    return clients;
  }
}
