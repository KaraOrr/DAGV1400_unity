using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      string atext = "hello class" + "here are everyones final scores";
      console.WriteLine(atext);
      int david = 100 - 5;
      int jerry = 100 - 25;
      int leon = 100 - 10;
      string studenta = "david";
      string studentb = "jerry";
      string studentc = "leon";
      Console.WriteLine(studenta);
      Console.WriteLine(david);
      Console.WriteLine(studentb);
      Console.WriteLine(jerry);
      Console.WriteLine(studentc);
      Console.WriteLine(leon);
      string ctext = "and the student with the highest score is!...";
      Console.WriteLine(ctext);
      string dtext = "David! with:";
      Console.WriteLine(dtext)
      Console.WriteLine(Math.Max(david, jerry));
      string etext = :"congrats everyone!";
      Console.WriteLine(etext);  
     }
  }
}