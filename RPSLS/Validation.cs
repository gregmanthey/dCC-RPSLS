using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace RPSLS
{
  class Validation
  {
    //member variables
    public string userInput;
    public int userInputAsInt;
    //constructor
    public Validation()
    {
      userInput = "";
    }
    //member methods
    public void ReadLineFor(string question, Func<string, bool> valid)
    {
      do
      {
        Console.WriteLine(question);
        userInput = Console.ReadLine().Trim();
      }
      while (userInput == null || userInput == "" || !valid(userInput));
    }

    public bool AlphanumericInput(string input)
    {
      Regex nonAlphaNumericChars = new Regex("[^a-zA-Z0-9 ]");
      if (!nonAlphaNumericChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only numbers, letters and spaces.");
      return false;

    }

    public bool LetterInput(string input)
    {
      Regex nonAlphabetChars = new Regex("[^a-zA-Z]");
      if (!nonAlphabetChars.IsMatch(input))
      {
        return true;
      }
      Console.WriteLine("Please enter only letters.");
      return false;
    }
    public bool NumberInput(string input)
    {
      Regex nonNumericChars = new Regex("[^0-9]");
      if (!nonNumericChars.IsMatch(input))
      {
        userInputAsInt = int.Parse(userInput);
        return true;
      }
      Console.WriteLine("Invalid input. Please enter only a number.");
      return false;
    }
    public bool YesNo(string input)
    {
      if (input.ToLower() == "yes" || input.ToLower() == "no")
      {
        return true;
      }
      Console.WriteLine("Please enter yes or no.");
      return false;
    }
  }
}
