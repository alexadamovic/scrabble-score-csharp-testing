using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models
{
  public class WordScore
  {

    public string Word { get; set; }

    public WordScore(string word)
    {
      Word = word;
    }

    public int GetScore()
    {
      char[] wordArray = Word.ToCharArray();
      int counter = 0;
      foreach (char letter in wordArray)
      {
        System.Console.WriteLine(letter);
        if (letter == 'A')
        {
          counter += 1;
        }
        else
        {
          counter += 0;
        }
      }
      System.Console.WriteLine(counter);
      return counter;
    }
  }
}