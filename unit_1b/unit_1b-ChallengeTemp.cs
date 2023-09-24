using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello user, please enter the number of the current temperature (in celsius) of your nearest city.");//user inputs temperature
      int temperature = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("It looks like the current temperature is " + temperature); //temperature is read back to them
      //depending on the temperatures, i gave different guidelines on how to handle the weather. 
      if (temperature > 39)  
      {
      Console.WriteLine("WOW! that's hot! " + temperature + " degrees can be dangerous! Be sure to stay inside and drink water!");
      } 
      else if (temperature > 29)
      {
      Console.WriteLine("What a beautiful summer day!" + temperature + "degrees means its good to go outside and enjoy the weather- but be sure to wear sunscreen and stay hydrated");
      }
      else if (temperature > 19)
      {
      Console.WriteLine("looks like its gonna be a nice day outside! " + temperature + " degrees is nice and warm. Probably dont wear a sweatshirt tho!");  
      }
      else if (temperature > 9)
      {
      Console.WriteLine("sweater weather is back on! " + temperature + " degrees is 'not too hot not too cold' but be sure to look out for any chances of rain in the next couple of days");  
      }
      else if (temperature > 0)
      {
      Console.WriteLine(temperature + " degrees means it's a little chilly. Be sure to wear some layers as 0 degrees means- things could freeze!");  
      }
      else if (temperature > -11)
      {
      Console.WriteLine("Its getting chilly! " + temperature + " degrees is pretty cold but not unbearable! just be sure to wear a warm jacket and pants.");  
      }
      else if (temperature > -21)
      {
      Console.WriteLine("if you want to go outside, stay safe! " + temperature + " could mean ice on the roads or even outside of your front door. wear lots of warm layers and if you start feeling too cold, go inside!");  
      }
      else if (temperature > -31)
      {
      Console.WriteLine("This. is. Cold. " + temperature + " degrees is no joke. dont go outside for too long unless u have too. ");  
      }
      else if (temperature > -41)
      {
      Console.WriteLine("Unless propoerly equiped, " + temperature + " degrees is dangerous. Roads can be icy so dont go outside unless you have to!");  
      }
      else if (temperature < -40)
      {
      Console.WriteLine(temperature + " degrees is tooooo cold. Santa needs to turn down christmas because nobody is going outside!");  
      }
      else
      {
      Console.WriteLine("Sorry, please re-enter your temperature.");
      }
    }
  }
}
