# sample-tests/ConvertIntegerToWordedStringTests.py
import unittest
import sys

sys.path.append("../")
from sample.lib.Converter import IntegerToWordedString


class ConvertIntegerToWordedStringTests(unittest.TestCase):

    # TODO: This test will become obsolete if the featured function is fully implemented.
    def test_not_implemented_yet(self):
        with self.assertRaises(NotImplementedError):
            IntegerToWordedString(-1000000)

    # TODO: Initial "red" test to code logic
    def test_first_positive_integer_is_one(self):
        number = 1
        words = IntegerToWordedString(number)
        self.assertEqual(words.lower(), "one")


if __name__ == "__main__":
    unittest.main()
