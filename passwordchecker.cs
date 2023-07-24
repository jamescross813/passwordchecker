using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      int minLength = 8;
      string upperCase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowerCase = "abcdefghijklmnopqrstuvwkyz";
      string digits = "1234567890";
      string specialChars = "!=%;&_-#$^*@";

      Console.WriteLine("Please enter a password:");
      string input = Console.ReadLine();

      int score = 0;

      if (input.Length >= minLength){
        score++;
      }
     
      if(Tools.Contains(input, upperCase)){
        score++;
      }
  
      if(Tools.Contains(input, lowerCase)){
        score++;
      }
      
      if(Tools.Contains(input, digits)){
        score++;
      }
   
      if(Tools.Contains(input, specialChars)){
        score++;
      }
      
      }

      
    }
  }
}
