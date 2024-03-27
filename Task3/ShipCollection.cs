//- Створити власний клас-колекцію об’єктів цього класу на базі однієї з узагальнених колекцій System.Collections.Generic, реалізувавши інтерфейс IEnumerable 
//та основні методи для роботи з цією колекцією, в тому числі методи сортування за різними критеріями та методи пошуку. 
namespace Task3
{
    class ShipCollection : IEnumerable<Ship>
    {
        private readonly List<Ship> ships = new List<Ship>();
        public void Add(Ship ship)
        {
            ships.Add(ship);
        }
        public void Remove(Ship ship)
        {
            ships.Remove(ship);
        }
        public void SortByName()
        {
            ships.Sort((a, b) => a.Name.CompareTo(b.Name));
        }
        public void SortByPort()
        {
            ships.Sort((a, b) => a.Port.CompareTo(b.Port));
        }
        public void SortByTonnage()
        {
            ships.Sort();
        }
        public Ship FindByName(string name)
        {
            return ships.Find(ship => ship.Name.ToLower().Contains(name.ToLower())) ?? new Ship("Not found", "Not found", 0);
        }
        public Ship FindByPort(string port)
        {
            return ships.Find(ship => ship.Port.ToLower().Contains(port.ToLower())) ?? new Ship("Not found", "Not found", 0);
        }
        public Ship FindByTonnage(int tonnage)
        {
            return ships.Find(ship => ship.Tonnage == tonnage) ?? new Ship("Not found", "Not found", 0);
        }
        public IEnumerator<Ship> GetEnumerator()
        {
            return ships.GetEnumerator();
        }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}