using System;

namespace MyApplication
{
  class Program
  {
    Console.Write("Input number of rows : "); //beginning text
    Console.Write("\n"); //space to organize
    int rows = Convert.ToInt32(Console.ReadLine()); //read the user input and give that value to rows
    for(int a=1;a<=rows;a++)//everytime the number input is bigger then the value of a, you...
    {        
	for(int b=1;b<=a;b++) //...write down the value of a which should start with 1. and if a is bigger then the value of b... 
	Console.Write(a); //you write it again and again until its not.
	// then, when b<=a, you write the last number and you shoot back to thetop of the loop...
    // a++ then "is a<=rows". 
    //you repeat the cycle until a<=rows.
    }   
   }
}