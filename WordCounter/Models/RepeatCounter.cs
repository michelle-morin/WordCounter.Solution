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
      if (inputSentence.Contains(" "))
      {
        char[] sentenceArray = inputSentence.ToCharArray();
        for (int i=0; i<sentenceArray.Length; i++)
        {
          if (Char.IsPunctuation(sentenceArray[i]))
          {
            sentenceArray[i] = ' ';
          }
        }
        string validatedSentence = new String(sentenceArray);
        return validatedSentence.ToLower();
      }
      else
      {
        return "Please enter a sentence";
      }
    }

  }
}