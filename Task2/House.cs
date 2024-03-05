using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2{
    abstract class House
    {
        public string Address { get; set; }
        public int Floors { get; set; }
        public int Area { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        protected House(string address = "null", int floors = 0, int area = 0, int year = 0, int price = 0)
        {
            Address = address;
            Floors = floors;
            Area = area;
            Year = year;
            Price = price;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Address: {Address}, Floors: {Floors}, Area: {Area}, Year: {Year}, Price: {Price}");
        }
        public override string ToString()
        {
            return $"Address: {Address}, Floors: {Floors}, Area: {Area}, Year: {Year}, Price: {Price}";
        }
    }
}