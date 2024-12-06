using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Вхідний текст
        Console.WriteLine("Введіть текст, що містить букви і цифри:");
        string input = Console.ReadLine();

        // Регулярний вираз для пошуку чисел
        string pattern = @"\d+";

        // Об'єкт класу Regex
        Regex regex = new Regex(pattern);

        // Знаходження всіх збігів
        MatchCollection matches = regex.Matches(input);

        if (matches.Count > 0)
        {
            Console.WriteLine("Знайдені числа:");
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
        else
        {
            Console.WriteLine("У тексті не знайдено жодного числа.");
        }
    }
}
