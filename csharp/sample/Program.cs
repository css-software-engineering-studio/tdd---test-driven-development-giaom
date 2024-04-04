class Program
{
    public static int Main(string[] args)
    {
        if (args.Length < 1) {
            Console.WriteLine("Expected parameter <integer>");
            return 1;
        }
        int number;
        if (!int.TryParse(args[0],out number)) {
            Console.WriteLine("Expected parameter <intege> is not a valid number");
            return 1;
        }
        try {
            Console.WriteLine(sample.lib.Converter.IntegerToWordedString(number));
            return 0;
        }
        catch (Exception e) {
            Console.WriteLine(e.Message);
            return 1;
        }
    }
}
