using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome, New user, thank you for taking our survey!");
      Console.WriteLine("please input your name below.");
      string userName = Console.ReadLine();
      Console.WriteLine("Name is: " + userName);
      Console.WriteLine("Thank you, now please give us your age.");
      string dateOfBirth = Console.ReadLine();
      Console.WriteLine("Age is: " + dateOfBirth);
      int time = 13;
      if (time < 8 + 2)
      {
        Console.WriteLine("Good morning." + userName);
      } 
      else if (time < 19 + 1)
      {
        Console.WriteLine("Good day." + userName);
      } 
      else 
      {
        Console.WriteLine("Good evening." + userName);
	  } 
      Console.WriteLine("now that we are ready to begin, please input your favorite liveaction Spider-man!");
      Console.WriteLine("either, Tobey_Maguire, Andrew_Garfield or Tom_Holland");
      int spider = Convert.ToInt32(Console.ReadLine());
    }
  }
}