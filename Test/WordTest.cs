using Xunit;
// using System.Collections.Generic;

namespace Anagram
{
  public class WordTest
  {
    [Fact]
    public void Sort_CompareAandA_true()
    {
      Word testalphabet = new Word() {};
      string actualalphabet = "a";
      Assert.Equal(actualalphabet, testalphabet.Sort("b"));
    }

  }
}
