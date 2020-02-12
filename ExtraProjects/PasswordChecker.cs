*/Purpose:Receive a users password
* and return a score (from 1-5)
* based on how many of the factors
* they included. Output will
* inform the user of their score
* and strength.
*/ 

using System;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      //Standard password factors
      int minLength = 10;
      string uppercase = "UPPERCASE";
      string lowercase = "lowercase";
      string digits = "0123456789";
      string specialChars = "#-?!";
      
      Console.Write("Enter your password: ");
      string userPassword = Console.ReadLine();
      
      int score = 0;
      
      if(userPassword.Length >= minLength)
      {
        score++;
      }
      
      if(Tools.Contains(userPassword, uppercase))
      {
        score++;
      }
      
       if(Tools.Contains(userPassword, lowercase))
      {
        score++;
      }
      
       if(Tools.Contains(userPassword, digits))
      {
        score++;
      }
      
       if(Tools.Contains(userPassword, specialChars))
      {
        score++;
      }
      
      Console.WriteLine(score);
      
      switch(score)
      {
        case 5:
        case 4:
          Console.WriteLine("The password is extremely strong");
          break;
        case 3:
          Console.WriteLine("The password is strong");
          break;
        case 2:
          Console.WriteLine("The password is medium");
          break;
        case 1:
          Console.WriteLine("The password is weak");
          break;
        default:
          Console.WriteLine("Password doesn't meet any of the standards");
          break;
      }   

    }
  }
}
