#include <iostream>
#include <cstdlib>
#include <exception>
#include "lib/Converter.hpp"

int main(int argc, char *argv[])
{
    if (argc < 2)
    { // argc includes the program name, so we require at least 2
        std::cout << "Expected parameter <integer>" << std::endl;
        return 1;
    }

    try
    {
        int number = std::stoi(argv[1]); // Convert the first argument to int
        std::cout << Converter::IntegerToWordedString(number) << std::endl;
        return 0;
    }
    catch (const std::invalid_argument &e)
    {
        // If std::stoi cannot convert the input to an int
        std::cout << "Expected parameter <integer> is not a valid number" << std::endl;
        return 1;
    }
    catch (const std::exception &e)
    {
        std::cout << e.what() << std::endl;
        return 1;
    }
    catch (...)
    {
        std::cout << "An unknown error occurred" << std::endl;
        return 1;
    }

    return 0; // Return 0 for success
}
// g++ Program.cpp -o Program && ./Program 1