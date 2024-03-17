using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Реалізувати інтенрфейс IComparable<Residental> для класу Residental. Порівнювати об'єкти за ціною.

namespace Task2
{
    sealed class Residental : House, IComparable<Residental>
    {
        public int Rooms { get; set; }
        public int Residents { get; set; }
        public bool Balcony { get; set; }
        public bool Elevator { get; set; }

        public Residental(string address = "null", int floors = 0, int area = 0, int year = 0, int price = 0, int rooms = 0, int residents = 0, bool balcony = false, bool elevator = false) : base(address, floors, area, year, price)
        {
            Rooms = rooms;
            Residents = residents;
            Balcony = balcony;
            Elevator = elevator;
        }
        public override void Print()
        {
            Console.WriteLine($"Address: {Address}, Floors: {Floors}, Area: {Area}, Year: {Year}, Price: {Price}, Rooms: {Rooms}, Residents: {Residents}, Balcony: {Balcony}, Elevator: {Elevator}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Rooms: {Rooms}, Residents: {Residents}, Balcony: {Balcony}, Elevator: {Elevator}";
        }
        public int CompareTo(Residental other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}