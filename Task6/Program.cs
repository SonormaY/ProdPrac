namespace Task6;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        try
        {
            List<Building> buildings = ReadBudynkyFromFile("budynky.txt");
            buildings.Sort((a, b) => a.Stories.CompareTo(b.Stories));

            Miscellaneoues.SerializeBinaryFormat(buildings, "budynky.bin");
            Miscellaneoues.DeserializeBinaryFormat("budynky.bin");

            Miscellaneoues.SerializeXmlFormat(buildings, "budynky.xml");
            Miscellaneoues.DeserializeXmlFormat("budynky.xml");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Виникла помилка: {ex.Message}");
        }
    }

    static List<Building> ReadBudynkyFromFile(string filePath)
    {
        List<Building> buildings = new List<Building>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string type = parts[0];
                string adresa = parts[1];
                int poverkhy = int.Parse(parts[2]);

                Building budynok;

                if (type == "Administratyvnyi")
                {
                    string organizatsia = parts[3];
                    budynok = new Administrative (adresa, poverkhy, organizatsia);
                }
                else if (type == "Zhytlovyi")
                {
                    int kilkistKvartyr = int.Parse(parts[3]);
                    budynok = new Residental (adresa, poverkhy, kilkistKvartyr);
                }
                else
                {
                    throw new Exception("Невідомий тип будинку");
                }

                buildings.Add(budynok);
            }
        }
        else
        {
            throw new FileNotFoundException("Файл не знайдено");
        }

        return buildings;
    }

    
}
