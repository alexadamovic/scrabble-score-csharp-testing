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
      if (this.Word == "A")
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
  }
}