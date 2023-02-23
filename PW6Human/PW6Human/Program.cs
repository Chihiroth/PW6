Worker Oleg = new Worker("Oleg", 20, "Мужской", "Мобильныйм оператор");
Human Boris = new Human("Boris", 17, "Мужской");
Boris.Call("Oleg");
Oleg.Shoot();
Console.ReadKey(true);
class Human
{
    public Human (string name, int age, string sex)
    {
        Name = name;
        Age = age;
        Sex = sex;
    }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public void Call(string name)
    {
        Console.WriteLine($"Вызов работника {name}");
    }
    protected void WriteToLog(string text)
    {
        File.AppendAllText("log.txt", $"{Name},{DateTime.Now}:{text}\n");
    }
}
class Worker : Human
{// работник должность
    public Worker(string name, int age, string sex, string post) : base(name, age, sex)
    {
        Post=post;
    }
    public string Post { get; set; }
    public void Shoot()
    {
        Console.WriteLine("Снимок сделан");
        WriteToLog($"Снимок сделан");
    }
}
