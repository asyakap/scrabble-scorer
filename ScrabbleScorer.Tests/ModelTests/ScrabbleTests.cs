using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScorer.Models;
using System.Collections.Generic;
using System;

namespace ScrabbleScorer.Tests
{
  [TestClass]
  public class ScrabbleTests
  {
    [TestMethod]
    public void ScrabbleConstructor_CreatesInstanceOfScrabbleWord_ScrabbleWords()
    {
      ScrabbleWords c = new ScrabbleWords(); // 
      Assert.AreEqual(typeof(ScrabbleWords), c.GetType());
    }



  }
}