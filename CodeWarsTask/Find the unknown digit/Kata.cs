using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsTask.Find_the_unknown_digit;

public class Kata
{
    //private static void Main()
    //{
    //    //Console.WriteLine(Runes.solveExpression("1+1=?"));
    //    //Console.WriteLine(Runes.solveExpression("123*45?=5?088"));
    //    //Console.WriteLine(Runes.solveExpression("-5?*-1=5?"));
    //    //Console.WriteLine(Runes.solveExpression("??*??=302?"));

    //    Console.WriteLine(Runes.solveExpression("19--45=5?"));
    //    //Console.WriteLine(Runes.solveExpression("??+??=??"));
    //    //Console.WriteLine(Runes.solveExpression("??*1=??"));
    //    //Console.WriteLine(Runes.solveExpression("?*11=??"));
    //}
}

public class Runes
{
    private const char _unknownSymbol = '?';
    private static readonly char[] _operations = new char[] { '+', '-', '*' };

    private static readonly char _equalsSymbol = '=';

    public static int solveExpression(string expression)
    {
        int operationIndex = GetOperationIndex(expression);
        int equalsSymbolIndex = expression.IndexOf(_equalsSymbol);

        char operation = expression[operationIndex];
        string firstNumber = expression[..operationIndex];
        string secondNumber = expression[++operationIndex..equalsSymbolIndex];
        string result = expression[++equalsSymbolIndex..];

        for (int i = 0; i < 10; i++)
        {
            char c = char.Parse(i.ToString());

            int fn = GetRunesNumber(firstNumber, c);
            int sn = GetRunesNumber(secondNumber, c);
            int res = GetRunesNumber(result, c);

            int expressionResult = 0;

            switch (operation)
            {
                case '+':
                    expressionResult = fn + sn;
                    break;
                case '-':
                    expressionResult = fn - sn;
                    break;
                case '*':
                    expressionResult = fn * sn;
                    break;
            }

            if (expressionResult == res) { return i; }
        }

        return -1;
    }

    private static int GetOperationIndex(string expression)
    {
        List<int> operations = new();

        for (int i = 0; i < expression.Length; i++)
        {
            if (_operations.Contains(expression[i]))
            {
                operations.Add(i);
            }
        }

        if (operations.Count == 1)
        {
            return operations[0];
        }

        return operations[1];
    }

    private static int GetRunesNumber(string str, char number)
    {
        return int.Parse(str.Replace(_unknownSymbol, number));
    }
}