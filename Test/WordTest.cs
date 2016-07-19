using Xunit;
using System.Collections.Generic;
using System;
namespace Anagram
{
  public class WordTest
  {
    [Fact]
    public void Evaluate_CompareAandA_sameWord_true()
    {
      Word testWord = new Word() {};
      string word1 ="good";
      string word2 = "good";
      Assert.Equal("good", testWord.Evaluate(word1, word2));
     }

     [Fact]
     public void Evaluate_CompareAandA_differentWord_true()
     {
       Word testWord = new Word() {};
       string word1 ="good";
       string word2 = "oogd";
       Assert.Equal("oogd", testWord.Evaluate(word1, word2));
      }

      [Fact]
      public void Evaluate_CompareAandA_differentWord_false()
      {
        Word testWord = new Word() {};
        string word1 ="good";
        string word2 = "bad";
        Assert.Equal(null, testWord.Evaluate(word1, word2));
       }
  //   [Fact]
  //   public void Sort_CompareInput1Input2_true()
  //  {
  //      Word testWord = new Word() {};
   //
  //      Assert.Equal();
   //
   //
   //
  //  }
  }
}
