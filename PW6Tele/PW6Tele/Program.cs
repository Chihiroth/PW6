Phone myHomePhone = new Phone("Nokia 3110", "88001234567");
myHomePhone.Call("85672537414");

Smartphone myWorkPhone = new Smartphone("iPhone3", "8800055353", 80.5);
myWorkPhone.Call("112");
myWorkPhone.Shoot();

Console.ReadKey(true);
class Phone
{ public Phone(string model, string number) {
        Model = model;
       Number = number;
    }
    public string Model { get; set; }
    public string Number { get; set; }
    public void Call (string number)
    {
        Console.WriteLine($"Вызов по телефону {number}");
    }
    protected void WriteToLog(string text)
    {
        File.AppendAllText("log.txt", $"{Model},{DateTime.Now}:{text}\n");
    }
}
class Smartphone : Phone
{
    public Smartphone(string model, string number, double cameraResolution) : base(model, number)
    {
        CameraResolution = cameraResolution;
    }
    public double CameraResolution { get; set; }
    public void Shoot()
    {
        Console.WriteLine("Снимок сделан");
        WriteToLog($"Снимок сделан");
    }
}
