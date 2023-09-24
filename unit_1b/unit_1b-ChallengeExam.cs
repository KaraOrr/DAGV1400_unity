using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello user, please enter the percentage of correct answers you got on your exam, ex. 90 , 40 , 55 ect."); 
      //the percentage sign was messing up the code, so i asked for a number
      int TS = Convert.ToInt32(Console.ReadLine());  //TS = the score
      Console.WriteLine("Now, Please enter in your favorite subject in school. This could be Science, Math, Sports, Art or History");
      string Sub = Console.ReadLine();  //SUB = School subject
      Console.WriteLine("The score you entered is " + TS);  //read it back to them
      //first I give them a response based off there score
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
        Console.WriteLine("So close! you scored an F."); 
        }     
        else
        {
        Console.WriteLine("Sorry, please re-enter in your score again!");
        } 
        if (Sub == "Math") //Now im going to give a response to there favorite subject
        {
        Console.WriteLine("Math is a Fun subject! Since everything around you is mathematics, try adding, multiplying or dividing up the items around you.using math in your day to day life is a great way to learn!");
        Console.WriteLine("using math in your day to day life is a great way to learn!");
        }
        else if (Sub == "Science")
        {
        Console.WriteLine("Science is a great subject! Asking questions and testing theories is a great way to practice your science.");
        }
        else if (Sub == "Sports")
        {
        Console.WriteLine("Sports is a cool subject! Everytime you practice you get a little bit better, so always try to do your best.");
        }    
        else if (Sub == "Art")
        {
        Console.WriteLine("Art is a unique subject! Drawing with diffrent tools on diffrent surfaces is a fun way to explore. As long as you are allowed to do so, try painting and drawing on paper cups, sidewalk and anything else you can imagine!"); 
        }     
        else if (Sub == "History")
        {
        Console.WriteLine("History is a super interesting subject! keep researching and reading to learn about the worlds history."); 
        Console.WriteLine("Books are the gateway to an endless world of adventures");
        }     
        else
        {
        Console.WriteLine("Sorry, please re-enter in your favorite subject again!");
        }    
    }
  }
}