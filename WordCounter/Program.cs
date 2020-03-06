using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      StartWordCounter(); 
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

    public static void StartWordCounter()
    {
      Console.BackgroundColor = ConsoleColor.DarkMagenta;
      Console.ForegroundColor = ConsoleColor.White;
      string validatedWord = GetUserWord();
      Console.Clear();
      if (validatedWord == "invalid input" || validatedWord == "error")
      {
        Console.WriteLine(validatedWord);
        StartWordCounter(); 
      }
      else
      {
        string validatedSentence = GetUserSentence();
        if (validatedSentence == "invalid input" || validatedSentence == "error")
        {
          Console.WriteLine(validatedSentence);
          StartWordCounter(); 
        }
        else
        {
          Console.Clear();
          RepeatCounter.AddMatchesToList(validatedWord, validatedSentence);
          DisplayNumberOfMatches(validatedWord, validatedSentence);
        }
      }
    }
  }
}