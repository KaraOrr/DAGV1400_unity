using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello user, please enter the percentage of correct answers you got on your exam, ex. 90 , 40 , 55 ect.");
      int TS = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("The score you entered is " + TS);
      if (TS > 100)
      {
      Console.WriteLine("Amazing! you scored an A+.");
      } 
      else if (TS > 89)
      {
      Console.WriteLine("Great job! you scored an A.");
      }
      else if (TS > 79)
      {
      Console.WriteLine("Good effort! you scored an B.");
      }
      else if (TS > 69)
      {
      Console.WriteLine("Keep trying! you scored an C.");  
      }
      else if (TS > 59)
      {
      Console.WriteLine("Maybe next time! you scored an D.");  
      }
      else if (TS < 60)
      {
      Console.WriteLine("Maybe next time! you scored an F.");  
      }
      else
      {
      Console.WriteLine("Sorry, please enter in your score again!");  
      }
    }
  }
}