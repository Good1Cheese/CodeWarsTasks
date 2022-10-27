using System.Linq;
using System.Text;

namespace CodeWarsKata.Alphabet_war___Wo_lo_loooooo_priests_join_the_war;

public class Kata
{
    private const string LEFT_SIDE_LETTERS = "TSBPW";
    private const string RIGHT_SIDE_LETTERS = "JZDQM";

    private static string _fight;
    private static StringBuilder _stringBuilderFigth;
    private static int _score;

    public static string AlphabetWar(string fight)
    {
        _fight = fight.ToUpper();
        _stringBuilderFigth = new(_fight);

        _fight = HandlePriestLetters('T');
        _fight = HandlePriestLetters('J');

        _score += GetSideScore(LEFT_SIDE_LETTERS);
        _score -= GetSideScore(RIGHT_SIDE_LETTERS);

        return GetWinner();
    }

    private static string HandlePriestLetters(char priest)
    {
        for (int i = 0; i < _fight.Length; i++)
        {
            char c = _fight[i];

            if (c == priest)
            {
                ReplaceAdjacent(i - 1);
                ReplaceAdjacent(i + 1);
            }
        }

        return _stringBuilderFigth.ToString();
    }

    private static void ReplaceAdjacent(int i)
    {
        if (i < 0 || i >= _fight.Length) { return; }

        string friends = LEFT_SIDE_LETTERS.Contains(_fight[i]) ? LEFT_SIDE_LETTERS : RIGHT_SIDE_LETTERS;
        string hostiles = LEFT_SIDE_LETTERS.Contains(_fight[i]) ? RIGHT_SIDE_LETTERS : LEFT_SIDE_LETTERS;

        int power = friends.IndexOf(_fight[i]);

        _stringBuilderFigth[i] = hostiles[power];
    }

    private static int GetSideScore(string side)
    {
        var score = from f in _fight
                    let i = side.IndexOf(f)
                    where i != -1
                    select i;

        return score.Sum();
    }

    private static string GetWinner()
    {
        switch (_score)
        {
            case > 0:
                return "Left side wins!";
            case < 0:
                return "Right side wins!";
            case 0:
                return "Let's fight again!";
        }
    }
}