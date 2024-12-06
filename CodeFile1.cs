using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Вхідний текст
        Console.WriteLine("Введіть текст, що містить IP-адреси:");
        string input = Console.ReadLine();

        // Регулярний вираз для пошуку IP-адрес
        string pattern = @"\b(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";

        // Об'єкт класу Regex
        Regex regex = new Regex(pattern);

        // Знаходження всіх збігів
        MatchCollection matches = regex.Matches(input);

        if (matches.Count > 0)
        {
            Console.WriteLine("Знайдені IP-адреси:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("У тексті не знайдено жодної IP-адреси.");
        }
    }
}
