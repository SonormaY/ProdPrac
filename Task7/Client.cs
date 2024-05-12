namespace Task7;
//Кожний запис містить код клієнта, рік, місяць, тривалість занять.
public class Client
{
  public int Id { get; set; }
  public int Year { get; set; }
  public int Month { get; set; }
  public int Duration { get; set; }

  public Client(int id, int year, int month, int duration)
  {
    Id = id;
    Year = year;
    Month = month;
    Duration = duration;
  }
  public override string ToString()
  {
    return $"{Id} {Year} {Month} {Duration}";
  }
}
