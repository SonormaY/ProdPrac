using System;
using System.Collections.Generic;

namespace prakt4_2024
{
/*    Створити колекцію об’єктів базового класу, заповнити об’єктами похідних класів, зчитаними з текстового файлу.
    Впорядкувати за одним із критеріїв. Здійснити серіалізацію та десеріалізацію колекції у двійковому та xml-форматі.Передбачити обробку виключних ситуацій*/
    internal class Collection
    {
        public List<Zaklad> zaklads = new List<Zaklad>();

        public void Add(Zaklad zaklad)
        {
            zaklads.Add(zaklad);
        }

        public void SortByName()
        {
            zaklads.Sort((a, b) => a.Name.CompareTo(b.Name));
        }

        public void SortByAddress()
        {
            zaklads.Sort((a, b) => a.Address.CompareTo(b.Address));
        }

        public void SortByPhone()
        {
            zaklads.Sort((a, b) => a.Phone.CompareTo(b.Phone));
        }

        public void ReadFromTxt(string path)
        {
            using (var stream = new System.IO.StreamReader(path))
            {
                string line;
                while ((line = stream.ReadLine()) != null)
                {
                    var parts = line.Split(' ');
                    if (parts.Length == 5)
                    {
                        Add(new School(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4])));
                    }
                    else if (parts.Length == 6)
                    {
                        Add(new University(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5])));
                    }
                }
            }
        }

        public void SerializeBinary(string path)
        {
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                formatter.Serialize(stream, zaklads);
            }
        }

        public void SerializeXml(string path)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Zaklad>));
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Create))
            {
                serializer.Serialize(stream, zaklads);
            }
        }

        public void DeserializeBinary(string path)
        {
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                var formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                zaklads = (List<Zaklad>)formatter.Deserialize(stream);
            }
        }

        public void DeserializeXml(string path)
        {
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(List<Zaklad>));
            using (var stream = new System.IO.FileStream(path, System.IO.FileMode.Open))
            {
                zaklads = (List<Zaklad>)serializer.Deserialize(stream);
            }
        }

        public void Print()
        {
            foreach (var zaklad in zaklads)
            {
                Console.WriteLine(zaklad.GetInfo());
            }
        }


    }
}
