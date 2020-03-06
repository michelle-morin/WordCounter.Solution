using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public static string ValidateWord(string inputWord)
    {
      if (inputWord.Contains(" "))
      {
        return "invalid input";
      }
      else
      {
        return inputWord.ToLower();
      }
    }

    public static string ValidateSentence(string inputSentence)
    {
      return inputSentence;
    }

  }
}