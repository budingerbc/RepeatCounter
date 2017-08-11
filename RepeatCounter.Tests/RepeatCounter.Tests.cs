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
  }
}
