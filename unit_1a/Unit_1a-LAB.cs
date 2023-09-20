using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string atext = "hello class" + "here are everyones final scores";
      console.WriteLine(atext); //here i included all of the names and there scores.
      int david = 100 - 5;
      int jerry = 100 - 25;
      int leon = 100 - 10;
      string studenta = "david";
      string studentb = "jerry";
      string studentc = "leon";
      Console.WriteLine(studenta); //now im writing down all of the scores
      Console.WriteLine(david);
      Console.WriteLine(studentb);
      Console.WriteLine(jerry);
      Console.WriteLine(studentc);
      Console.WriteLine(leon);
      string ctext = "and the student with the highest score is!...";
      Console.WriteLine(ctext);
      string dtext = "David! with:";
      Console.WriteLine(dtext) //here ive written down that david is the winner and repeated what his final score is.
      Console.WriteLine(Math.Max(david, jerry));
      string etext = :"congrats everyone!";
      Console.WriteLine(etext);  
     }
  }
}