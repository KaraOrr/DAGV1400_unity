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
      //I started off with getting the name and birth
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
      //here ive included a little welcome with there name, which changes depending on the time of day.
      Console.WriteLine("Now that we are ready to begin, please input your favorite live-action Spider-man!");
      Console.WriteLine("you may either enter, Tobey_Maguire, Andrew_Garfield or Tom_Holland");
      int spider = Convert.ToInt32(Console.ReadLine()); //int is very important here
      if (spider = Tobey_Maguire)
      {
      Console.WriteLine("Tobey is an awesome choice! Thank you for completing the Survey!");
      } 
      else if (spider = Andrew_Garfield)
      {
      Console.WriteLine("Andrew is an awesome choice! Thank you for completing the Survey!");
      }
      else if (spider = Tom_Holland)
      {
      Console.WriteLine("Tom is an awesome choice! Thank you for completing the Survey!");
      }
      else 
      {
      Console.WriteLine("Please re-input your response by copy and pasting one of the three actors names above.");  
      }
      //lastly, i took the input of there favorite spiderman and gave them responses depending on the answer. 
      //if one of the responses doesn't work, i ask them to resubmit by copy and paste.
    }
  }
}