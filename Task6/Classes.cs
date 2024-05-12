using System.Xml.Serialization;

namespace Task6;

[Serializable]
[XmlInclude(typeof(Administrative))]
[XmlInclude(typeof(Residental))]

public abstract class Building
{
    public string Address { get; set; }
    public int Stories { get; set; }

    public override string ToString()
    {
        return $"Адреса: {Address}, Поверхів: {Stories}";
    }

    public Building()
    {
    }

    public Building(string address, int stories)
    {
        Address = address;
        Stories = stories;
    }
}

[Serializable]
public class Administrative : Building
{
    public string Organization { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Організація: {Organization}";
    }

    public Administrative()
    {
    }

    public Administrative(string address, int stories, string organization) : base(address, stories)
    {
        Organization = organization;
    }
}

[Serializable]
public class Residental : Building
{
    public int NumOfApartments { get; set; }

    public override string ToString()
    {
        return base.ToString() + $", Кількість квартир: {NumOfApartments}";
    }

    public Residental()
    {
    }

    public Residental(string address, int stories, int numOfApartments) : base(address, stories)
    {
        NumOfApartments = numOfApartments;
    }
}
