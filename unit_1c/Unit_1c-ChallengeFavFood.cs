using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Please enter your top 3 favorite foods, one at a time!");
    string foodA = Convert.ToString(Console.ReadLine()); //input 1
    string foodB = Convert.ToString(Console.ReadLine()); //input 2
    string foodC = Convert.ToString(Console.ReadLine()); //input 3
    string[] foods = {foodA, foodB, foodC}; //putting them in array
        for (int i = 0; i < foods.Length; i++) 
        {
        Console.WriteLine(foods[i] + " is so delicous."); //printing out array
        }
    Console.WriteLine("Nice! " + foods[0] +", "+ foods[1] +", and "+ foods[2] + " are some great foods!" ); //cherry on top!
  }
}