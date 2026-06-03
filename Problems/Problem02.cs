using System;

namespace ProblemSolving.Problems
{
  public class Problem02
  {
    public static void Solve()
    {
      // Taking user input
      Console.Write("Enter a number: ");
      string userInput = Console.ReadLine()!;

      // Converting to integer
      int number = Convert.ToInt32(userInput);

      // Checking either positive or negative
      if (number > 0)
      {
        Console.WriteLine($"{number} is positive");
      }
      else if (number < 0)
      {
        Console.WriteLine($"{number} is negative");
      }
      else
      {
        Console.WriteLine($"{number} is zero");
      }
    }
  }
}