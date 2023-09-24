using System;
class numguess {
  static void Main() {
    Console.WriteLine("Hello World");
		int a = 0;
	 	int guess = 0; 
		Random ranb = new Random(); //generating a random number
	 	Console.WriteLine("Welcome to number guesser! I have a new number in mind...");
     	Console.WriteLine("Guess which number im thinking of! it's a number from 1-10:");
	 	int ranA = ranb.Next(1,10);
		 while(guess != ranA)
		{
		  try
		    {
        	guess = Convert.ToInt32(Console.ReadLine());
			a++; //a stands for the amount of turns!
	 			if (guess < ranA)
     			{
     			Console.WriteLine("Too Low! try again!");
     			}
			    else if (guess > ranA)
     			{
     			Console.WriteLine("Too High! try again!"); //too high or too low responses!
				} 
		    }
		  catch
		       {
			   Console.WriteLine("The guess must be a number"); //in case of incorrect numbers or letters
		   	   }
		}
     Console.WriteLine("you got it! the number was:");
     Console.WriteLine(ranA); 
	 Console.WriteLine("It took you " + a + " times to guess the correct number."); //showing the amount of attempts and the generated number
	}
}