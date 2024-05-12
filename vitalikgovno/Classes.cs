using System;
using System.Xml.Serialization;

namespace prakt4_2024
{

    /*    На основі базового класу ОСВІТНІЙ ЗАКЛАД створити підкласи ШКОЛА і УНІВЕРСИТЕТ.
    */
    [Serializable]
    [XmlInclude(typeof(School)), XmlInclude(typeof(University))]
    public class Zaklad
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Zaklad() { }

        public Zaklad(string name, string address, string phone)
        {
            Name = name;
            Address = address;
            Phone = phone;
        }

        public virtual string GetInfo()
        {
            return $"Name: {Name}\nAddress: {Address}\nPhone: {Phone}";
        }
    }

    [Serializable]
    public class School : Zaklad
    {
        public int Pupils { get; set; }
        public int Teachers { get; set; }

        public School() { }

        public School(string name, string address, string phone, int pupils, int teachers) : base(name, address, phone)
        {
            Pupils = pupils;
            Teachers = teachers;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nPupils: {Pupils}\nTeachers: {Teachers}";
        }
    }

    [Serializable]
    public class University : Zaklad
    {
        public int Students { get; set; }
        public int Professors { get; set; }
        public int Faculties { get; set; }

        public University() { }

        public University(string name, string address, string phone, int students, int professors, int faculties) : base(name, address, phone)
        {
            Students = students;
            Professors = professors;
            Faculties = faculties;
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $"\nStudents: {Students}\nProfessors: {Professors} \nNum of Faculties: {Faculties}";
        }
    }
}
