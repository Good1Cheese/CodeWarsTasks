namespace CodeWarsTask.Grasshopper___Personalized_Message;

public class Kata
{
    private const string BOSS_GREETING = "Hello boss";
    private const string GUEST_GREETING = "Hello guest";

    public static string Greet(string name, string owner)
    {
        return name == owner ? BOSS_GREETING : GUEST_GREETING;
    }
}