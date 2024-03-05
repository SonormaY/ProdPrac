using System.IO.Enumeration;

namespace Task2
{
    sealed class Misc
    {
        public static void ReadFromFile(string fileName, List<House> houses)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) is not null)
                {
                    string[] data = line.Split(' ');
                    if (data.Length == 9)
                    {
                        object temp = new Residental(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]), bool.Parse(data[7]), bool.Parse(data[8]));
                        houses.Add(temp as House);
                    }
                    else if (data.Length == 8)
                    {
                        object temp = new Administrative(data[0], int.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), bool.Parse(data[6]), bool.Parse(data[7]));
                        houses.Add(temp as House);
                    }
                }
            }
        }
    }
}