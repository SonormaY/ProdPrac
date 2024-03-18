/*- Створити клас, включити в нього необхідні конструктори, властивості та методи, реалізувати узагальнений інтерфейс IComparable а також методи ToString, Equals, GetHashCode. */
//7.	Клас КОРАБЕЛЬ з наступними полями: назва, порт приписки, тонажність. 
namespace Task3
{
    class Ship : IComparable<Ship>
    {
        public string Name { get; set; }
        public string Port { get; set; }
        public int Tonnage { get; set; }

        public Ship(string name, string port, int tonnage)
        {
            Name = name;
            Port = port;
            Tonnage = tonnage;
        }
        public int CompareTo(Ship? other)
        {
            if (other == null)
                return 1;
            return this.Tonnage.CompareTo(other.Tonnage);
        }
        public override string ToString()
        {
            return $"Name: {Name}, Port: {Port}, Tonnage: {Tonnage}";
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            Ship ship = (Ship)obj;
            return this.Name == ship.Name && this.Port == ship.Port && this.Tonnage == ship.Tonnage;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode() + Port.GetHashCode() + Tonnage.GetHashCode();
        }
    }
}