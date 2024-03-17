using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Реалізувати сортування за різними критеріями використовуючи IComparer<T> для класу Administrative.
namespace Task2
{
    sealed class Administrative : House, IComparer<Administrative>
    {
        public int Offices { get; set; }
        public bool Parking { get; set; }
        public bool Security { get; set; }
        public static SortBy compareField = SortBy.Name;

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
        public int Compare(Administrative x, Administrative y)
        {
            switch (compareField)
            {
                case SortBy.Name:
                    return x.Address.CompareTo(y.Address);
                case SortBy.Floors:
                    return x.Floors.CompareTo(y.Floors);
                case SortBy.Area:
                    return x.Area.CompareTo(y.Area);
                case SortBy.Year:
                    return x.Year.CompareTo(y.Year);
                case SortBy.Price:
                    return x.Price.CompareTo(y.Price);
                case SortBy.Offices:
                    return x.Offices.CompareTo(y.Offices);
                case SortBy.Parking:
                    return x.Parking.CompareTo(y.Parking);
                case SortBy.Security:
                    return x.Security.CompareTo(y.Security);
                default:
                    return 0;
            }
        }
    }
}