using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    sealed class Administrative : House
    {
        public int Offices { get; set; }
        public bool Parking { get; set; }
        public bool Security { get; set; }

        public Administrative(string address = "null", int floors = 0, int area = 0, int year = 0, int price = 0, int offices = 0, bool parking = false, bool security = false) : base(address, floors, area, year, price)
        {
            Offices = offices;
            Parking = parking;
            Security = security;
        }
        public override void Print()
        {
            Console.WriteLine($"Address: {Address}, Floors: {Floors}, Area: {Area}, Year: {Year}, Price: {Price}, Offices: {Offices}, Parking: {Parking}, Security: {Security}");
        }
        public override string ToString()
        {
            return base.ToString() + $", Offices: {Offices}, Parking: {Parking}, Security: {Security}";
        }
    }
}