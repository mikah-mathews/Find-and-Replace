using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindNReplace.Models;

namespace FindNReplace.Tests
{
  [TestClass]

  public class ReplacementTests
  {
    [TestMethod]
    public void ReplacementConstructor_CreatesInstanceOfReplacement_Replacement()
    {
      Replacement newReplacement = new Replacement();
      Assert.AreEqual(typeof(Replacement), newReplacement.GetType());
    }
    [TestMethod]
    public void ReplaceWord_ReplacesWordInString_String()
    {
      Replacement newReplacement = new Replacement();
      string sentence = "I'm not a pokeman fan";
      string wordToReplace = "pokeman";
      string replacementWord = "pokemon";
      string result = sentence.Replace(wordToReplace, replacementWord);
      Assert.AreEqual(result, "I'm not a pokemon fan");
    }
  }
}