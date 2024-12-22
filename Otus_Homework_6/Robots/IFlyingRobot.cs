namespace Otus_Homework_6;

public interface IFlyingRobot : IRobot
{
    new string GetRobotType()
    {
        return "I am a flying robot.";
    }
}