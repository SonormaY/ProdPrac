using System.Collections;

namespace Task2
{
    public class Collection : IEnumerable
    {
        // створити клас колекцію з об'єктів базового класу на базв Array, передбачити метод запису у файл, зчитування з файлу, сортування за різними критеріями, пошуку за певним критерієм
        // реалізувати інтерфейси IEnumerable
        private List<House> houses = new List<House>();
        public void ReadFromFile(string fileName)
        {
            Misc.ReadFromFile(fileName, houses);
        }
        public void WriteToFile(string fileName)
        {
            Misc.WriteToFile(fileName, houses);
        }
        public void Print()
        {
            foreach (House house in houses)
            {
                house.Print();
            }
        }
        public void Sort()
        {
            houses.Sort((x, y) => x.Address.CompareTo(y.Address));
        }
        public void SortResidental()
        {
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
        }
        public void SortAdministrative(SortBy field)
        {
            Administrative.compareField = field;
            houses.Sort((x, y) => (x as Administrative).Compare(x as Administrative, y as Administrative));
        }
        public void Search(string criteria)
        {
            foreach (House house in houses)
            {
                if (house.ToString().Contains(criteria))
                {
                    house.Print();
                }
            }
        }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}