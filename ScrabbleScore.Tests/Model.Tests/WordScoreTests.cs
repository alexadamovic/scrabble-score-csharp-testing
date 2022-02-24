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
      string test = "A";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetScore_Return0ForNotLetter_Int()
    {
      string test = "1";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(0, result);
    }

    [TestMethod]
    public void GetScore_Return2ForTwoLetters_Int()
    {
      string test = "AA";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetScore_Return2For1Letter_Int()
    {
      string test = "D";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetScore_Return3For1Letter_Int()
    {
      string test = "B";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void GetScore_Return4For1Letter_Int()
    {
      string test = "F";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(4, result);
    }

  [TestMethod]
    public void GetScore_Return5For1Letter_Int()
    {
      string test = "K";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetScore_Return8For1Letter_Int()
    {
      string test = "J";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(8, result);
    }

  [TestMethod]
    public void GetScore_Return10For1Letter_Int()
    {
      string test = "Q";
      WordScore newWordScore = new WordScore(test);
      int result = newWordScore.GetScore();
      Assert.AreEqual(10, result);
    }



  }
}