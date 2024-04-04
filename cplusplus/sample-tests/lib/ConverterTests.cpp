#define DOCTEST_CONFIG_IMPLEMENT_WITH_MAIN
#include "../doctest.h"
#include "../../sample/lib/Converter.hpp"
#include <stdexcept>

TEST_CASE("Converter Function is not implemented")
{
    REQUIRE_THROWS_AS(Converter::IntegerToWordedString(int(INT32_MIN)), std::logic_error);
}

TEST_CASE("First positive integer is converted to 'one'")
{
    int number = 1;
    CHECK(Converter::IntegerToWordedString(number) == "one");
}
//  g++ -std=c++11 ConverterTests.cpp -o ConverterTests && ./ConverterTests