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
      int Sub = Convert.ToInt32(Console.ReadLine());  //school subject = the score
      Console.WriteLine("The score you entered is " + TS);  //read it back to them
      switch (Sub) 
      {
        case Math:
            if (TS > 100)
                Console.WriteLine("Amazing! you scored an A+.");
            if (TS > 89)
                Console.WriteLine("Great job! you scored an A.");
            if (TS > 79)
                Console.WriteLine("Good effort! you scored an B.");
            if (TS > 69)
                Console.WriteLine("Keep trying! you scored an C.");  
            if (TS > 59)
                Console.WriteLine("Maybe next time! you scored an D.");  
            if (TS < 60)
                Console.WriteLine("So close! you scored an F.");  
            else if
                Console.WriteLine("Sorry, please enter in your score again!"); //responses given as well as a "just in case" messup response 


            if (number1 >= number2) {
                if (number1 == number2) {
                    printf("Result: %d = %d",number1,number2);
                }
                else {
                    printf("Result: %d > %d", number1, number2);
                }
            }
            else {
                printf("Result: %d < %d",number1, number2);
            }
      }
    }
  }
}