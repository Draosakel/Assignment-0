namespace ApplicationTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void isThisALeapYearWith4()
    {
        // Arrange
        LeapYear l = new LeapYear();

        // Act
        var result4 = l.IsLeapYear(1604);

        // Assert
        Assert.AreEqual(true, result4);
    }

    [TestMethod]
    public void isThisALeapYearWith100()
    {
        // Arrange
        LeapYear l = new LeapYear();

        // Act
        var result100 = l.IsLeapYear(1700);

        // Assert
        Assert.AreEqual(false, result100);
    }

    [TestMethod]
    public void isThisALeapYearWith400()
    {
        // Arrange
        LeapYear l = new LeapYear();

        // Act
        var result100 = l.IsLeapYear(1600);

        // Assert
        Assert.AreEqual(true, result100);
    }

    [TestMethod]
    public void enterYearBefore1582Error()
    {
        // Arrange
        LeapYear l = new LeapYear();

        // Act
        var result400 = l.IsLeapYear(400);

        // Assert
        Assert.AreEqual(false, result400);
    }   
}