using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Program
    {
        // 1. Filter odd numbers from a list of integers
        static List<int> FilterOddNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 != 0).ToList();
        }

        // 2. Find the average of a list of real values
        static double FindAverage(List<double> numbers)
        {
            return numbers.Count > 0 ? numbers.Average(n => n) : 0;
        }

        // 3. Sort a list of strings in alphabetical order
        static List<string> SortStringsAlphabetically(List<string> strings)
        {
            return strings.OrderBy(s => s).ToList();
        }

        // 4. Calculate the sum of all even numbers
        static int SumEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).Sum(n => n);
        }

        // 5. Calculate the factorial of a given number
        static long CalculateFactorial(int number)
        {
            Func<int, long> factorial = null;
            factorial = n => n <= 1 ? 1 : n * factorial(n - 1);
            return factorial(number);
        }

        // 6. Calculate the multiplication and sum of all elements in a list of integers
        static (long Multiplication, int Sum) CalculateMultiplicationAndSum(List<int> numbers)
        {
            long multiplication = numbers.Count > 0 ? numbers.Aggregate(1L, (acc, n) => acc * n) : 0;
            int sum = numbers.Sum(n => n);
            return (multiplication, sum);
        }

        // 7. Calculate the square of each number in a list of integers
        static List<int> CalculateSquares(List<int> numbers)
        {
            return numbers.Select(n => n * n).ToList();
        }

        // 8. Sort strings based on their length in ascending order
        static List<string> SortStringsByLength(List<string> strings)
        {
            return strings.OrderBy(s => s.Length).ToList();
        }

        // 9. Count the number of words in a sentence
        static int CountWords(string sentence)
        {
            return sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        // 10. Find the first non-empty string in a list of strings
        static string FindFirstNonEmptyString(List<string> strings)
        {
            return strings.FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? string.Empty;
        }

        // 11. Check if all strings in a list start with a capital letter
        static bool AllStringsStartWithCapital(List<string> strings)
        {
            return strings.All(s => !string.IsNullOrEmpty(s) && char.IsUpper(s[0]));
        }

        // 12. Find the second largest number in a list of integers
        static int FindSecondLargestNumber(List<int> numbers)
        {
            return numbers.Count > 1 ? numbers.OrderByDescending(n => n).Skip(1).First() : 0;
        }

        // 13. Find the largest even number in a list of integers
        static int FindLargestEvenNumber(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).DefaultIfEmpty(0).Max();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Lambda Expression Tasks:");
            Console.WriteLine("------------------------");

            // Test data
            List<int> intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<double> doubleList = new List<double> { 1.5, 2.5, 3.5, 4.5, 5.5 };
            List<string> stringList = new List<string> { "Apple", "banana", "Cherry", "date", "Elderberry" };
            string sentence = "This is a test sentence to count words";

            // 1. Filter odd numbers
            Console.WriteLine("\n1. Odd numbers from the list:");
            List<int> oddNumbers = FilterOddNumbers(intList);
            Console.WriteLine(string.Join(", ", oddNumbers));

            // 2. Find average
            Console.WriteLine("\n2. Average of the list:");
            double average = FindAverage(doubleList);
            Console.WriteLine(average);

            // 3. Sort strings alphabetically
            Console.WriteLine("\n3. Strings sorted alphabetically:");
            List<string> sortedStrings = SortStringsAlphabetically(stringList);
            Console.WriteLine(string.Join(", ", sortedStrings));

            // 4. Sum of even numbers
            Console.WriteLine("\n4. Sum of even numbers:");
            int evenSum = SumEvenNumbers(intList);
            Console.WriteLine(evenSum);

            // 5. Factorial
            Console.WriteLine("\n5. Factorial of 5:");
            long factorial = CalculateFactorial(5);
            Console.WriteLine(factorial);

            // 6. Multiplication and sum
            Console.WriteLine("\n6. Multiplication and sum of the list:");
            var multiplicationAndSum = CalculateMultiplicationAndSum(intList);
            Console.WriteLine($"Multiplication: {multiplicationAndSum.Multiplication}, Sum: {multiplicationAndSum.Sum}");

            // 7. Squares
            Console.WriteLine("\n7. Squares of each number:");
            List<int> squares = CalculateSquares(intList);
            Console.WriteLine(string.Join(", ", squares));

            // 8. Sort by length
            Console.WriteLine("\n8. Strings sorted by length:");
            List<string> sortedByLength = SortStringsByLength(stringList);
            Console.WriteLine(string.Join(", ", sortedByLength));

            // 9. Count words
            Console.WriteLine("\n9. Number of words in the sentence:");
            int wordCount = CountWords(sentence);
            Console.WriteLine(wordCount);

            // 10. First non-empty string
            Console.WriteLine("\n10. First non-empty string:");
            string firstNonEmpty = FindFirstNonEmptyString(new List<string> { "", null, "Hello", "World" });
            Console.WriteLine(firstNonEmpty);

            // 11. Check if all strings start with capital
            Console.WriteLine("\n11. All strings start with capital letter:");
            bool allCapital = AllStringsStartWithCapital(stringList);
            Console.WriteLine(allCapital);

            // 12. Second largest number
            Console.WriteLine("\n12. Second largest number:");
            int secondLargest = FindSecondLargestNumber(intList);
            Console.WriteLine(secondLargest);

            // 13. Largest even number
            Console.WriteLine("\n13. Largest even number:");
            int largestEven = FindLargestEvenNumber(intList);
            Console.WriteLine(largestEven);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
