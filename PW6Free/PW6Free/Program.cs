Computer RET = new Computer("RET 10", "154867");
Laptop ASUS = new Laptop("ASUS 9", "456123", 97);

RET.Show("154867");
ASUS.ShowBattery();
//Smartphone myWorkPhone = new Smartphone("iPhone3", "8800055353", 80.5);
//myWorkPhone.Call("112");
//myWorkPhone.Shoot();

Console.ReadKey(true);
class Computer
{
    public Computer(string model, string number)
    {
        Model = model;
        Number = number;
    }
    public string Model { get; set; }
    public string Number { get; set; }
    public void Show(string number)
    {
        Console.WriteLine($"Это компьютер под номером {number}");
    }
    protected void WriteToLog(string text)
    {
        File.AppendAllText("log.txt", $"{Model},{DateTime.Now}:{text}\n");
    }
}
class Laptop : Computer
{
    public Laptop(string model, string number, int battery) : base(model, number)
    {
        Battery = battery;
    }
    public double Battery { get; set; }
    public void ShowBattery()
    {
        Console.WriteLine($"Текущий заряд = {Battery} %");
        WriteToLog($"Текущий заряд = {Battery} %");
    }
}
