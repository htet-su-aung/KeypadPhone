
using System.Text.RegularExpressions;

namespace KeypadPhone
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter input:");
                string? input = Console.ReadLine()?.Trim();

                string output = oldPhoneKeypad(input);
                Console.WriteLine("Output is: " + output);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static readonly Dictionary<string, char> keypadData = new()
        {
            { "1", '&' },
            { "11", '\'' },
            { "111", '(' },
            { "2", 'A' },
            { "22", 'B' },
            { "222", 'C' },
            { "3", 'D' },
            { "33", 'E' },
            { "333", 'F' },
            { "4", 'G' },
            { "44", 'H' },
            { "444", 'I' },
            { "5", 'J' },
            { "55", 'K' },
            { "555", 'L' },
            { "6", 'M' },
            { "66", 'N' },
            { "666", 'O' },
            { "7", 'P' },
            { "77", 'Q' },
            { "777", 'R' },
            { "7777", 'S' },
            { "8", 'T' },
            { "88", 'U' },
            { "888", 'V' },
            { "9", 'W' },
            { "99", 'X' },
            { "999", 'Y' },
            { "9999", 'Z' },
            { "0", ' ' }
        };

        static char del = '*';
        static char hold = ' ';
        static char send = '#';

        static string oldPhoneKeypad(string? input)
        {
            string pattern = @"^[0-9* #]+$";

            if (string.IsNullOrEmpty(input) || !Regex.IsMatch(input, pattern))
            {
                throw new Exception("please enter valid input!");
            }
            else if(input[input.Length - 1] != send)
            {
                throw new Exception("# keyword missing!");
            }

            var chrList = findChars(input);

            var outputStr = string.Empty;

            foreach (var c in chrList)
            {
                keypadData.TryGetValue(c, out char plainChr);
                outputStr += plainChr;
            }
            return outputStr;

        }

        static List<string> findChars(string input)
        {
            var resultList = new List<string>();
            string currentChar = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == del && resultList.Count > 0)
                {
                    resultList.RemoveAt(resultList.Count - 1);
                }
                else if (input[i] != hold && input[i] != send)
                {
                    currentChar += input[i];
                    if (input[i + 1] != input[i])
                    {
                        resultList.Add(currentChar);
                        currentChar = string.Empty;
                    }
                }
                
            }
            return resultList;
        }

    }
}