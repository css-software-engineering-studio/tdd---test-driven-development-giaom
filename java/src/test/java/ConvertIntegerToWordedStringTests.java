import org.junit.jupiter.api.Test;
import static org.junit.jupiter.api.Assertions.*;
import lib.Converter;

public class ConvertIntegerToWordedStringTests {

    @Test
    void notImplementedYet() {
        assertThrows(UnsupportedOperationException.class, () -> {
            Converter.integerToWordedString(Integer.MIN_VALUE);
        });
    }

    @Test
    void firstPostiveIntegerIsOne() {
        int number = 1;
        String words = Converter.integerToWordedString(number);
        assertEquals("one", words);
    }
}