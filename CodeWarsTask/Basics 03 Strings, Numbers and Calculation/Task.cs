using System.Data;

namespace CodeWarsTask.Dubstep
{
    public class Task
    {
        private const string OPERATIONS = "+-*/";

        public string calculateString(string calcIt)
        {
            string expression = string.Empty;
            bool isNumberOneOfNumbersFractional = false;

            for (int i = 0; i < calcIt.Length; i++)
            {
                char c = calcIt[i];

                bool hasNumberDot = c == '.';
                if (char.IsNumber(c) || hasNumberDot || OPERATIONS.Contains(c))
                {
                    expression += c;
                    if (!isNumberOneOfNumbersFractional && hasNumberDot) { isNumberOneOfNumbersFractional = hasNumberDot; }
                }
            }

            object result;
            if (isNumberOneOfNumbersFractional)
            {
                result = (decimal)new DataTable().Compute(expression, null);
                return System.Math.Round((decimal)result).ToString();
            }
            result = (int)new DataTable().Compute(expression, null);
            return result.ToString();
        }
    }
}