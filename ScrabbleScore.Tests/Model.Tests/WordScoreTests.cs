using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class WordScoreTests
  {
    [TestMethod]
    public void WordScoreConstructor_CreatesInstanceOfWordScore_WordScore()
    {
      string test = "test";
      WordScore newWordScore = new WordScore(test);
      Assert.AreEqual(typeof(WordScore), newWordScore.GetType());
    }

    [TestMethod]
    public void WordScoreConstructor_ReturnWordVariable_String()
    {
      string test = "test";
      WordScore newWordScore = new WordScore(test);
      string result = newWordScore.Word;
      Assert.AreEqual(test,result);
    }
  }
}