namespace prakt4_2024
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Zaklads.txt";
            Collection collection = new Collection();
            collection.ReadFromTxt(filePath);
            collection.Print();
            Console.ReadKey();

            Console.Clear();
            collection.SortByName();
            collection.Print();
            Console.ReadKey();

            Console.Clear();
            collection.SortByAddress();
            collection.Print();
            Console.ReadKey();

            Console.Clear();
            collection.SortByPhone();
            collection.Print();
            Console.ReadKey();

            Console.Clear();
            collection.SerializeXml("data.xml");
            Console.WriteLine("Serialized to XML");
            Console.ReadKey();

            Console.Clear();
            collection.SerializeBinary("data.bin");
            Console.WriteLine("Serialized to Binary");
            Console.ReadKey();

            Console.Clear();
            collection.DeserializeXml("data.xml");
            collection.Print();
            Console.ReadKey();

            Console.Clear();
            collection.DeserializeBinary("data.bin");
            collection.Print();
            Console.ReadKey();

        }
    }
}