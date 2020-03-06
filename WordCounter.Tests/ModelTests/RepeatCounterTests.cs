using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests : IDisposable
  {
    public void Dispose()
    {
      RepeatCounter.ClearAll();
    }

    [TestMethod]
    public void ValidateWord_ReturnError_InvalidInput()
    {
      string validation = RepeatCounter.ValidateWord("Hello There");
      Assert.AreEqual("invalid input", validation);
    }

    [TestMethod]
    public void ValidateWord_ReturnLowercaseWord_hello()
    {
      string validation = RepeatCounter.ValidateWord("Hello");
      Assert.AreEqual("hello", validation);
    }

    [TestMethod]
    public void ValidateSentence_ReturnError_InvalidInput()
    {
      string validation = RepeatCounter.ValidateSentence("cat");
      Assert.AreEqual("Please enter a sentence", validation);
    }

    [TestMethod]
    public void ValidateSentence_ReturnLowercaseSentence_LowercaseSentence()
    {
      string validation = RepeatCounter.ValidateSentence("Hello There");
      Assert.AreEqual("hello there", validation);
    }

    [TestMethod]
    public void ValidateSentence_RemovesPunctuation_NoPunctuationSentence()
    {
      string validation = RepeatCounter.ValidateSentence("The cat walked.");
      Assert.AreEqual("the cat walked ", validation);
    }

    [TestMethod]
    public void RepearCounterClass_RetrieveEmptyList_EmptyList()
    {
      // Arrange
      RepeatCounter.AddMatchesToList("cat", "i walked it");

      // Act
      List<string> matchingWords = RepeatCounter.MatchingWords;
      int numberOfMatches = matchingWords.Count;

      // Assert
      Assert.AreEqual(0, numberOfMatches);
    }

  }
}