namespace Otus_Homework_6;

public class Quadcopter : IFlyingRobot, IChargeable
{
    private List<string> _components = new() { "rotor1", "rotor2", "rotor3", "rotor4" };
    
    public void Charge()
    {
        Console.WriteLine("Charging...");
        Thread.Sleep(3000);
        Console.WriteLine("Charged!");
    }

    string IChargeable.GetInfo()
    {
        return "This type of robots can charge.";
    }

    string IRobot.GetInfo()
    {
        return "This type of robots has components.";
    }

    public List<string> GetComponents()
    {
        return _components;
    }
}