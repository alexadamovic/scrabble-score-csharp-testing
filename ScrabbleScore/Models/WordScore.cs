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
        if (letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U' || letter == 'R' || letter == 'S' || letter == 'L' || letter == 'N' || letter == 'T')
        {
          counter += 1;
        }
        else if ()
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