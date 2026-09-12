using System;
using System.Text.RegularExpressions;

class Program
{
    static string FilterText(string text)
    {
        string pattern = @"\b(кіт|кота|коту|котом|коти|котів|котами|котам|котах)\b";

        return Regex.Replace(text, pattern, "тварина",
            RegexOptions.IgnoreCase);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть текст: ");
        string text = Console.ReadLine() ?? "";

        string result = FilterText(text);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }
}