using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
namespace Task6;

static public class Miscellaneoues
{
  public static void SerializeBinaryFormat(List<Building> buildings, string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            formatter.Serialize(stream, buildings);
        }

        Console.WriteLine("Серіалізація у двійковий формат виконана успішно.");
    }

    public static void DeserializeBinaryFormat(string filePath)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            List<Building> buildings = (List<Building>)formatter.Deserialize(stream);
            Console.WriteLine("Десеріалізація з двійкового формату:");
            foreach (Building building in buildings)
            {
                Console.WriteLine(building);
            }
        }
    }

    public static void SerializeXmlFormat(List<Building> buildings, string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Building>));

        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            serializer.Serialize(stream, buildings);
        }

        Console.WriteLine("Серіалізація у XML-формат виконана успішно.");
    }

    public static void DeserializeXmlFormat(string filePath)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Building>));

        using (FileStream stream = new FileStream(filePath, FileMode.Open))
        {
            List<Building> buildings = (List<Building>)serializer.Deserialize(stream);
            Console.WriteLine("Десеріалізація з XML-формату:");
            foreach (Building building in buildings)
            {
                Console.WriteLine(building);
            }
        }
    }
}

