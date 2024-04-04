namespace sample_tests;
using Xunit;
using sample.lib;

public class Convert_IntegerToWordedString_Tests
{
    [Fact]
    //TODO: This test will become obsolete if the featured function is fully implemented.
    public void NotImplementedYet()
    {
        Action act = () => Converter.IntegerToWordedString(int.MinValue);
        Assert.Throws<NotImplementedException>(act);
    }

    [Fact]
    //TODO: Initial "red" test to code logic
    public void FirstPostiveIntegerIsOne()
    {
        int number = 1;
        string words = Converter.IntegerToWordedString(number);
        Assert.Equal("one",words,true);
    }
}