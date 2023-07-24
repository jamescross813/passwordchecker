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
      switch(score){
        case 1:
          Console.WriteLine("1. Weak");
          break;
        case 2:
          Console.WriteLine("2. Medium");
          break;
        case 3:
          Console.WriteLine("3. Strong");
          break;
        case 4:
          Console.WriteLine("4. Extremely strong!");
          break;
        case 5:
          Console.WriteLine("5. Extremely strong!");
          break;
        default:
          Console.WriteLine("No standards are met");
          break;
      }

      
    }
  }
}
