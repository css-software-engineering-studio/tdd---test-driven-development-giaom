# sample/Program.py
import sys
from lib.Converter import IntegerToWordedString

def main(args):
    if (
        len(args) < 2
    ):  # args also includes the script name, so we need at least 2 items for one argument
        print("Expected parameter <integer>")
        return 1

    try:
        number = int(args[1])  # args are strings by default, convert to int
    except ValueError:
        print("Expected parameter <integer> is not a valid number")
        return 1

    try:
        worded_string = IntegerToWordedString(number)
        print(worded_string)
        return 0
    except Exception as e:
        print(str(e))
        return 1


if __name__ == "__main__":
    main(sys.argv)
