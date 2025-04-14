namespace Lesson15.Models;

public abstract class Device
{
    public string Name { get; set; }

    protected string Id { get; set; }

    public abstract void Update();
}

public sealed class IPhone : Device
{
    public override void Update()
    {
        Console.WriteLine($"Update iPhone ({Name}) from iOS 18 to 19");
    }
}

public sealed class Samsung : Device
{
    public override void Update()
    {
        Console.WriteLine($"Update Samsung ({Name}) from android vanilla ice 15 to baklava 16");
    }
}
