
namespace CodeWarsTask.Rock_Paper_Scissors_;

public class Kata
{
    public string Rps(string p1, string p2)
    {
        if (p1 == p2) return "Draw!";

        if (p1 == "rock")
        {
            return p2 switch
            {
                "scissors" => "Player 1 won!",
                _ => "Player 2 won!"
            };
        }

        if (p1 == "scissors")
        {
            return p2 switch
            {
                "paper" => "Player 1 won!",
                _ => "Player 2 won!"
            };
        }

        if (p1 == "paper")
        {
            return p2 switch
            {
                "rock" => "Player 1 won!",
                _ => "Player 2 won!"
            };
        }

        return string.Empty;
    }
}