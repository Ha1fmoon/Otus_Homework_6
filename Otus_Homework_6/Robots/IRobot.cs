namespace Otus_Homework_6;

public interface IRobot
{
    string GetInfo();

    List<string> GetComponents();

    string GetRobotType()
    {
        return "I am a simple robot.";
    }
}