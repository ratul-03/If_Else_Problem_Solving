namespace ProblemSolving.Problems
{
  public class Problem01
  {
    public static void Solve()
    {
      // Taking input from user
      Console.Write("Enter number 01: ");
      string userInputNumber01 = Console.ReadLine()!;

      Console.Write("Enter number 02: ");
      string userInputNumber02 = Console.ReadLine()!;

      // Converting to integer
      int number01 = Convert.ToInt32(userInputNumber01);
      int number02 = Convert.ToInt32(userInputNumber02);

      // Checking they are equal or not
      if (number01 == number02)
      {
        Console.WriteLine($"{number01} and {number02} are equal");
      }
      else
      {
        Console.WriteLine($"{number01} and {number02} are not equal");
      }
    }
  }
}