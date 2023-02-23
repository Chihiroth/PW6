PolitechCar WheelOfFortune = new PolitechCar("Wheel of fortune", "90 km/h", 80);
WheelOfFortune.LoudMusic();

Airplane Boingo = new Airplane("Boingo", "80 km/h", 100);
Boingo.SprayField();

ConcreteMixer Diamond = new ConcreteMixer("Diamond", "40 km/h", 50);
Diamond.MixConcrete();

Console.ReadKey(true);
class Transport
{
    public Transport(string title, string maxspeed)
    {
        Title = title;
        MaxSpeed = maxspeed;
    }
    public string Title { get; set; }
    public string MaxSpeed { get; set; }
    protected void WriteToLog(string text)
   {
        File.AppendAllText("log.txt", $"{Title},{DateTime.Now}:{text}\n");
    }
}
class PolitechCar: Transport
{
    public PolitechCar(string title, string maxspeed, double volume) : base(title, maxspeed)
    {
      Volume = volume;
   }
    public double Volume{ get; set; }
    public void LoudMusic()
    {
        Console.WriteLine("Школьный рэп включен");
        WriteToLog($"Школьный рэп включен");
    }
}
class Airplane: Transport
{
    public Airplane(string title, string maxspeed, double height):base(title, maxspeed)
    {
        Height = height;
    }
    public double Height { get; set; }
    public void SprayField()
    {
        Console.WriteLine("Поле покрыто слизью");
        WriteToLog($"Поле покрыто слизью");
    }
}
class ConcreteMixer : Transport {
    public ConcreteMixer(string title, string maxspeed, double volume) : base(title, maxspeed)
    {
        Volume = volume;
    }
    public double Volume { get; set; }
    public void MixConcrete()
    {
        Console.WriteLine("Бетон мешается");
        WriteToLog($"Бетон мешается");
    }
}
