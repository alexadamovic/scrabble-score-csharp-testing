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
      WordScore newWordScore = new WordScore();
      Assert.AreEqual(typeof(WordScore), newWordScore.GetType());
    }
  }
}