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

        //Action act2 = () => Converter.IntegerToWordedString(int.MinValue);
        //Assert.Throws<ArgumentOutOfRangeException>(act2);
    }

    [Fact]
    //TODO: Initial "red" test to code logic
    public void One()
    {
        string words = Converter.IntegerToWordedString(1);
        Assert.Equal("one", words, true);
    }

    [Fact]
    public void Two()
    {
        string words = Converter.IntegerToWordedString(2);
        Assert.Equal("two", words, true);
    }

    [Fact]
    public void Zero()
    {
        string words = Converter.IntegerToWordedString(0);
        Assert.Equal("zero", words, true);
    }

    [Fact]
    public void NegativeOutOfRange()
    {
        string words = Converter.IntegerToWordedString(-1);
        Assert.Equal("negative one", words, true);
    }

    [Fact]
    public void PositiveOutOfRange()
    {
        string words = Converter.IntegerToWordedString(10000);
        Assert.Equal("1 million", words, true);
    }
}