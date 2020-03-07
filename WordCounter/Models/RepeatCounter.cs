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
      char[] wordChars = inputWord.ToCharArray();
      for (int i = 0; i<wordChars.Length; i++)
      {
        if (Char.IsPunctuation(wordChars[i]))
        {
          wordChars[i] = ' ';
        }
        else if (wordChars[i] == '$')
        {
          wordChars[i] = ' ';
        }
      }
      string userWord = new String(wordChars);
      string revisedUserWord = userWord.Trim();
      if (revisedUserWord.Contains(" ") || String.IsNullOrWhiteSpace(revisedUserWord))
      {
        return "invalid input";
      }
      else
      {
        return revisedUserWord.ToLower();
      }
    }

    public static string ValidateSentence(string inputSentence)
    {
      string[] wordsInSentence = inputSentence.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
      if (wordsInSentence.Length > 1 && String.IsNullOrWhiteSpace(inputSentence) == false)
      {
        char[] sentenceArray = inputSentence.ToCharArray();
        for (int i=0; i<sentenceArray.Length; i++)
        {
          if (Char.IsPunctuation(sentenceArray[i]))
          {
            sentenceArray[i] = ' ';
          }
          else if (sentenceArray[i] == '$')
          {
            sentenceArray[i] = ' ';
          }
        }
        string validatedSentence = new String(sentenceArray);
        string removeWhitespaceSentence = validatedSentence.Trim();
        return removeWhitespaceSentence.ToLower();
      }
      else
      {
        return "invalid input";
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