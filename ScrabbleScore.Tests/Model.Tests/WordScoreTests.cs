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
      Assert.AreEqual(test, result);
    }

    [TestMethod]
    public void WordScoreConstructor_SetWordScore_String()
    {
      string test = "test";
      WordScore newWordScore = new WordScore(test);
      string updatedTest = "test2";
      newWordScore.Word = updatedTest;
      string result = newWordScore.Word;
      Assert.AreEqual(updatedTest, result);
    }

    [TestMethod]
    public void GetScore_ReturnInt_Int()
    {
      string test = "test";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(1, result);
    }
  }
}