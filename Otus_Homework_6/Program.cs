namespace Otus_Homework_6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Quadcopter");
        var robot1 = new Quadcopter();
        
        Console.WriteLine("Charging:");
        robot1.Charge();
        
        Console.WriteLine("Components:");
        foreach (var component in robot1.GetComponents())
        {
            Console.WriteLine(component);
        }

        Console.WriteLine();
        
        
        Console.WriteLine("IRobot");
        IRobot robot2 = new Quadcopter();
        
        Console.WriteLine("Robot type:");
        Console.WriteLine(robot2.GetRobotType());
        
        Console.WriteLine("Info:");
        Console.WriteLine(robot2.GetInfo());
        
        Console.WriteLine("Components:");
        foreach (var component in robot2.GetComponents())
        {
            Console.WriteLine(component);
        }

        Console.WriteLine();


        Console.WriteLine("IChargeable robot");
        IChargeable robot3 = new Quadcopter();

        Console.WriteLine("Info:");
        Console.WriteLine(robot3.GetInfo());
        
        Console.WriteLine("Charging:");
        robot3.Charge();
    }
}