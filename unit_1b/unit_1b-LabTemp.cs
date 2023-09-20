using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello user, please enter the number of the current temperature (in celsius) of your nearest city");//user inputs temperature
      int temperature = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("It looks like the current temperature is " + temperature); //temperature is read back to them
      if (temperature > 30)
      {
      Console.WriteLine("WOW! that's hot! Be sure to stay hydrated and avoid staying in the sun for too long.");
      } 
      else 
      {
      Console.WriteLine("looks like its gonna be a nice day outside!");
      }
      Console.WriteLine("stay safe!"); //response then given depending on the temperature
    }
  }
}
