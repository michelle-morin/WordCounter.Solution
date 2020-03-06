using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      DisplayWelcome();
      StartWordCounter(); 
    }

    public static string GetUserWord()
    {
      try
      {
        Console.WriteLine("\n Please enter a word:");
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
        Console.WriteLine("\n Please enter a sentence:");
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
        if (numberOfMatches == 0)
        {
          Console.WriteLine($"\n The sentence '{sentence}' does not include the word '{word}' \n");
        }
        else
        {
          Console.WriteLine($"\n The number of times the word '{word}' appears in the sentence '{sentence}' is {numberOfMatches}! \n");
        }
        AskAgain();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public static void AskAgain()
    {
      RepeatCounter.ClearAll();
      string goodbye = @"
      ╔═╗╔═╗╔═╗╔╦╗╔╗ ╦ ╦╔═╗
      ║ ╦║ ║║ ║ ║║╠╩╗╚╦╝║╣ 
      ╚═╝╚═╝╚═╝═╩╝╚═╝ ╩ ╚═╝";
      string flowers = @"
              ,,,                      ,,,
             {{{}}    ,,,             {{{}}    ,,,
          ,,, ~Y~    {{{}},,,      ,,, ~Y~    {{{}},,, 
         {{}}} |/,,,  ~Y~{{}}}    {{}}} |/,,,  ~Y~{{}}}
          ~Y~ \|{{}}}/\|/ ~Y~  ,,, ~Y~ \|{{}}}/\|/ ~Y~  ,,,
          \|/ \|/~Y~  \|,,,|/ {{}}}\|/ \|/~Y~  \|,,,|/ {{}}}
          \|/ \|/\|/  \{{{}}/  ~Y~ \|/ \|/\|/  \{{{}}/  ~Y~
          \|/\\|/\|/ \\|~Y~//  \|/ \|/\\|/\|/ \\|~Y~//  \|/
          \|//\|/\|/,\\|/|/|// \|/ \|//\|/\|/,\\|/|/|// \|/
        ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^";
      Console.WriteLine("\n Would you like to return to the main menu? \n [YES] or [NO]");
      string userResponse = Console.ReadLine();
      if (userResponse.ToLower() == "yes" || userResponse.ToLower() == "y")
      {
        Main();
      }
      else if (userResponse.ToLower() == "no" || userResponse.ToLower() == "n")
      {
        Console.Clear();
        Console.WriteLine($"\n {goodbye}");
        Console.WriteLine($"\n{flowers} \n");
      }
    }

    public static void StartWordCounter()
    {
      string validatedWord = GetUserWord();
      if (validatedWord == "invalid input")
      {
        Console.Clear();
        Console.WriteLine($"\n {validatedWord}");
        StartWordCounter(); 
      }
      else if (validatedWord == "error")
      {
        StartWordCounter();
      }
      else
      {
        string validatedSentence = GetUserSentence();
        if (validatedSentence == "invalid input")
        {
          Console.Clear();
          string confusedArt = @"¯\_(ツ)_/¯";
          Console.WriteLine($"\n {validatedSentence} \n \n {confusedArt} \n Let's try this again, from the beginning!");
          StartWordCounter(); 
        }
        else if (validatedSentence == "error")
        {
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

    public static void DisplayWelcome()
    {
      Console.BackgroundColor = ConsoleColor.DarkCyan;
      Console.ForegroundColor = ConsoleColor.Black;
      Console.Clear();
      string welcomeMessage = @"
      ╦ ╦╔═╗╦  ╔═╗╔═╗╔╦╗╔═╗
      ║║║║╣ ║  ║  ║ ║║║║║╣ 
      ╚╩╝╚═╝╩═╝╚═╝╚═╝╩ ╩╚═╝
      ╔╦╗╔═╗  ╔╦╗╦ ╦╔═╗    
       ║ ║ ║   ║ ╠═╣║╣     
       ╩ ╚═╝   ╩ ╩ ╩╚═╝    
      ╦ ╦╔═╗╦═╗╔╦╗         
      ║║║║ ║╠╦╝ ║║         
      ╚╩╝╚═╝╩╚══╩╝         
      ╔═╗╔═╗╦ ╦╔╗╔╔╦╗╔═╗╦═╗
      ║  ║ ║║ ║║║║ ║ ║╣ ╠╦╝
      ╚═╝╚═╝╚═╝╝╚╝ ╩ ╚═╝╩╚═";
      Console.WriteLine(welcomeMessage);
    }
  }
}