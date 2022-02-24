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
        else if (letter == 'D' || letter == 'G')
        {
          counter += 2;
        }
        else if (letter == 'B' || letter == 'C' || letter == 'M' || letter == 'P')
        {
          counter += 3;
        }
        else if (letter == 'F' || letter == 'H' || letter == 'V' || letter == 'W' || letter == 'Y')
        {
          counter += 4;
        }
        else 
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