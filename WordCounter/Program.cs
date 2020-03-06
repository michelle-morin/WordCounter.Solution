using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      string validatedWord = GetUserWord();
      if (validatedWord == "invalid input" || validatedWord == "error")
      {
        Console.WriteLine(validatedWord);
        Main();
      }
      else
      {
        string validatedSentence = GetUserSentence();
        if (validatedSentence == "invalid input" || validatedSentence == "error")
        {
          Console.WriteLine(validatedSentence);
          Main();
        }
        else
        {
          RepeatCounter.AddMatchesToList(validatedWord, validatedSentence);
          DisplayNumberOfMatches(validatedWord, validatedSentence);
        }
      }
      
    }

    public static string GetUserWord()
    {
      try
      {
        Console.WriteLine("Please enter a word:");
        string userInput = Console.ReadLine();
        string userWord = RepeatCounter.ValidateWord(userInput);
        return userWord;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return "error";
      }
    }

    public static string GetUserSentence()
    {
      try
      {
        Console.WriteLine("Please enter a sentence:");
        string inputSentence = Console.ReadLine();
        string userSentence = RepeatCounter.ValidateSentence(inputSentence);
        return userSentence;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return "error";
      }
    }

    public static void DisplayNumberOfMatches(string word, string sentence)
    {
      List<string> matchingWords = RepeatCounter.MatchingWords;
      try
      {
        int numberOfMatches = matchingWords.Count;
        Console.WriteLine($"The number of times the word '{word}' appears in the sentence '{sentence}' is {numberOfMatches}!");
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
  }
}