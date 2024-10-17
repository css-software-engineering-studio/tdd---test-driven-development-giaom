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

    /*
    [Fact]
    //TODO: Initial "red" test to code logic
    public void One()
    {
        string words = Converter.IntegerToWordedString(1);
        Assert.Equal("one", words, true);
    } */

    /* _________________________________________________________
    NOTES: xUnit C# testing:
    [Fact]: -Specific case, -No input now multiple test cases -fixed expected outcome
    [Theory]: -Multiple test cases, -Parameterized test cases -requires data source for parameters, like InlineData, MemberData, or ClassData.
        InlineData: Provides test data directly in the attribute. Great for simple cases.
        MemberData: Pulls test data from a method, property, or field. Good for sharing data or larger datasets.
        ClassData: Provides test data from a class. Best for dynamic or complex data sets.
    ____________________________________________________________ */

    [Theory]
    // Test within ones (1-19) and boundaries
    [InlineData(0, "zero")]
    [InlineData(1, "one")]
    [InlineData(9, "nine")]
    [InlineData(10, "ten")]
    [InlineData(15, "fifteen")]
    [InlineData(19, "nineteen")]
    // Test within tens (20-99) and boundaries
    [InlineData(20, "twenty")]
    [InlineData(23, "twenty-three")]
    [InlineData(50, "fifty")]
    [InlineData(99, "ninety-nine")]
    /*
        // Test within hundreds (100-999) and boundaries
        [InlineData(100, "one hundred")]
        [InlineData(105, "one hundred and five")]
        [InlineData(250, "two hundred and fifty")]
        [InlineData(999, "nine hundred and ninety-nine")]
        // Test within Thousands (1000-9999) and boundaries
        [InlineData(1000, "one thousand")]
        [InlineData(1234, "one thousand two hundred and thirty-four")]
        [InlineData(2000, "two thousand")]
        [InlineData(9999, "nine thousand nine hundred and ninety-nine")]
    */
    // Test throw exceptions:
    //[InlineData(-1, "negative one")] // negative
    //[InlineData(10000, "one thousand")] // out of range
    //[InlineData(1, "One")] // case sensitive
    public void Test_IntegerToWordedString(int numberIn, string expectedString)
    {
        // Act
        string result = Converter.IntegerToWordedString(numberIn);

        // Assert
        Assert.Equal(expectedString, result);
    }
}