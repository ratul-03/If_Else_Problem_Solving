namespace ProblemSolving.Problems
{
  public class Problem03
  {
    public static void Solve()
    {
      // Taking inputs from user
      Console.Write("Enter you name: ");
      string userName = Console.ReadLine()!;

      Console.WriteLine();

      Console.Write("Enter your age: ");
      int userAge = Convert.ToInt32(Console.ReadLine()!);

      Console.WriteLine();

      Console.Write("How much units you have consumed: ");
      decimal units = Convert.ToDecimal(Console.ReadLine()!);

      if (userAge <= 0 || units <= 0)
      {
        Console.WriteLine("Invalid Age or Units");
      }
      else if (userAge > 0 && units > 0)
      {
        decimal electricityBill = 0;
        decimal subCharge = 0;
        decimal specialDiscount = 0;
        decimal totalBill = 0;

        // Calculating electricity bill
        if (units > 0 && units <= 100)
        {
          electricityBill = units * 5;
          
          if (userAge > 60)
          {
            specialDiscount = electricityBill * (5m / 100);
            Console.WriteLine($"Your special discount is {specialDiscount} tk");
          }
        }
        totalBill = electricityBill - specialDiscount;
        Console.WriteLine($"Your name is ${userName}");
        Console.WriteLine($"Your age is {userAge}");
        Console.WriteLine($"You have consumed {units} units");
        Console.WriteLine($"Your original bill is {electricityBill} tk");
        Console.WriteLine($"Senior Citizen Discount {specialDiscount} tk");
        Console.WriteLine($"Your total bill is {totalBill}");
      }
    }
  }
}