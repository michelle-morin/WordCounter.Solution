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
  }
}