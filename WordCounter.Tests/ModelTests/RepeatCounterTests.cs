using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTests
  {
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
  }
}