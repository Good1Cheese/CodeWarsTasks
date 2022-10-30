namespace CodeWarsTask.Basic_Mathematical_Operations;

public static class Kata
{
    public static double basicOp(char operation, double v1, double v2)
    {
        return operation switch
        {
            '+' => v1 + v2,
            '-' => v1 - v2,
            '*' => v1 * v2,
            '/' => v1 / v2,
            _ => 0
        };
    }
}