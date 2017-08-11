using RepeatCounterApp.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RepeatCounterApp.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void CountRepeats_EmptyStringReturnsZero_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 0;

      // Act
      int actual = count.CountRepeats("", "");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_SingleMatchingWordReturnsOne_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 1;

      // Act
      int actual = count.CountRepeats("Epicodus", "Learning at Epicodus is great!");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_MultipleMatchingWordsReturnsCorrectValue_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 5;

      // Act
      int actual = count.CountRepeats("code", "code all day, code all night, code code code");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_MatchingValuesAreCaseSensitive_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 1;

      // Act
      int actual = count.CountRepeats("aBBa", "aBBa AbbA");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_CheckForPunctuationWhereWordShouldStillMatch_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 3;

      // Act
      int actual = count.CountRepeats("code", "I love to code, code, code!");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_CheckIfHypenatedWordsMatch_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 1;

      // Act
      int actual = count.CountRepeats("see-saw", "They played on the see-saw.");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_IfMultileWordsAreSubmittedSearchOnlyFirstWordAsMatch_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 3;

      // Act
      int actual = count.CountRepeats("see saw", "They played on the see see see saw.");

      // Assert
      Assert.AreEqual(expected, actual);
    }
    [TestMethod]
    public void CountRepeats_CheckStringWithNumbersAndSpechailCharacters_True()
    {
      // Arrange
      RepeatCounter count = new RepeatCounter();
      int expected = 1;

      // Act
      int actual = count.CountRepeats("l33tsp@ak", "I only speak l33tsp@ak!");

      // Assert
      Assert.AreEqual(expected, actual);
    }
  }
}
