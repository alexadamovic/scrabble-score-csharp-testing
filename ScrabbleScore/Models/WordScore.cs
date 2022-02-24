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
      
    }
}