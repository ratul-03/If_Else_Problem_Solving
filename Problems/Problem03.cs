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

        if (units > 100 && units <= 300)
        {
          electricityBill = units * 8;

          if (userAge > 60)
          {
            specialDiscount = electricityBill * (5m / 100);
            Console.WriteLine($"Your special discount is {specialDiscount} tk");
          }
        }

        if (units > 300 && units <= 600)
        {
          electricityBill = units * 10;

          if (userAge > 60)
          {
            specialDiscount = electricityBill * (5m / 100);
            Console.WriteLine($"Your special discount is {specialDiscount} tk");
          }

          if (electricityBill > 5000)
          {
            subCharge = electricityBill * (10m / 100);
            Console.WriteLine($"Your subcharge is {subCharge} tk");
          }
        }

        if (units > 600)
        {
          electricityBill = units * 12;

          if (userAge > 60)
          {
            specialDiscount = electricityBill * (5m / 100);
            Console.WriteLine($"Your special discount is {specialDiscount} tk");
          }

          if (electricityBill > 5000)
          {
            subCharge = electricityBill * (15m / 100);
            // Console.WriteLine($"Your subcharge is {subCharge} tk");
          }
        }

        totalBill = electricityBill+ subCharge - specialDiscount;
        Console.WriteLine($"Your name is {userName}");
        Console.WriteLine($"Your age is {userAge}");
        Console.WriteLine($"You have consumed {units} units");
        Console.WriteLine($"Your original bill is {electricityBill} tk");
        Console.WriteLine($"Your subcharge is {subCharge} tk");
        Console.WriteLine($"Senior Citizen Discount {specialDiscount} tk");
        Console.WriteLine($"Your total bill is {totalBill}");
      }
    }
  }
}