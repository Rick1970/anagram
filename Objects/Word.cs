// using System.Collections.Generic;
using System;
namespace Anagram
{
  public class Word
  {
    public  string Evaluate(string word1, string word2)
    {
      char[] char1 = word1.ToLower().ToCharArray();
      Array.Sort(char1);
      string NewWord1 = new string(char1);

      char[] char2 = word2.ToLower().ToCharArray();
      Array.Sort(char2);
      string NewWord2 = new string(char2);
      if (NewWord1 == NewWord2)
      {
        return word2;
      }
      else
      {
        return null;
      }
    }



  }
}
// "good, bad, oogd, low"
