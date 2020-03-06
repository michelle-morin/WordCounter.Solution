using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    public static List<string> MatchingWords { get; set; } = new List<string> {};

    public static void ClearAll()
    {
      MatchingWords.Clear();
    }

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

    public static void AddMatchesToList(string word, string sentence)
    {
      string[] setenceArr = sentence.Split(' ');
      for (int i=0; i<setenceArr.Length; i++)
      {
        if (word == setenceArr[i].Trim())
        {
          MatchingWords.Add(setenceArr[i]);
        }
      }
    }

  }
}