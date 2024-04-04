
// javac Program.java lib/Converter.java 
// java -ea Program.java
import lib.Converter;

public class Program {

    public static void main(String[] args) {
        if (args.length < 1) {
            System.out.println("Expected parameter <integer>");
            System.exit(1);
        }

        try {
            int number = Integer.parseInt(args[0]);
            System.out.println(Converter.integerToWordedString(number));
        } catch (NumberFormatException e) {
            System.out.println("Expected parameter <integer> is not a valid number");
            System.exit(1);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            System.exit(1);
        }
    }
}