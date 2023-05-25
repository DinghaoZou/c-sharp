/* "using" lets you use classes from a namespace. */

/* namespace is a code organizer. */

/* "class" is a container for data and methods. */

/* "Console" is a class that belongs to the "System" namespace. */

/* WriteLine() method is used to print a line into the console. It belongs to the "Console" class.*/

/* Should the "using System;" code be unused, one shall write "System.Console.WriteLine()" instead.*/

/* WriteLine() can be used to print numbers. (And it also can be used to calculate math.) */

using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine("I am Learning C#");
      Console.WriteLine("It is awesome!");

/* WriteLine() can be used to print numbers. (And it also can be used to calculate math.) */

      Console.WriteLine(3 + 3);

/* Write() method can be used like WriteLine(), except that it doesn't go to a new line every time you use it. */

      Console.Write("Hello World! ");
      Console.Write("I will print on the same line.");

// C# has variables.

// C# variable types:
/*
  int - Integers (Whole Numbers Without Decimals) - 125
  double - Numbers With Decimals - 6.25
  char - Single Characters - 'E'
  bool - True or False
  string - Text - "Hello World!"
*/

      int five = 5;
      double fivePointSix = 5.6;
      char firstLetter = 'A';
      bool yes = true;
      string hi = "Hello";

// Constant variables cannot be changed later on. If a constant variable is created, the data that's given to it will stay with the constant variable forever.

      const int permanentNumber = 3;
      // Doing "permanentNumber = 5" will result in an error.
      // Leaving a constant variable blank will cause an error.

// Use "+" to combine data together.

      Console.WriteLine(" ");
      Console.WriteLine(hi + " World!");

// You can assign a single value to multiple variables in one go.

      int hey, hello, areYouThere;
      hey = hello = areYouThere = 30;
      Console.WriteLine(hey + hello + areYouThere);

// C# keywords cannot be used as variable names.

// Another C# variable type: long - Bigger Numbers Than What 'int' Can Store

      long longNumber = 15000000000000000;
      Console.WriteLine(longNumber);

// Another C# variable type: float - Decimal Number, Cannot Store As Much Digits As 'double'
// 'float' and 'double' variables can have scientific numbers. (Has an "e" that indicates the power of 10.)

      float floatScientific = 35e3F;
      double doubleScientific = 12E4D;
      Console.WriteLine(floatScientific);
      Console.WriteLine(doubleScientific);

// Type Casting: Assigning a value of one data variable type to another data variable type.
// Implicit Casting (Auto) - Smaller to Bigger - char, int, long, float, double
// Explicit Casting (Manual) - Bigger to Smaller - double, float, long, int, char

      int aFunnyNumber = 10;
      double aFunnyDouble = aFunnyNumber;

// When doing explicit casting, one must put the variable type name in parentheses in front of the value.

      double justADouble = 1.59;
      int justAnInteger = (int) justADouble;
      Console.WriteLine(justADouble);
      Console.WriteLine(justAnInteger);

      int integerAgain = 15;
      double doubleAgain = 6.25;
      bool boolAgain = false;

      Console.WriteLine(Convert.ToString(integerAgain));    // Int -> String
      Console.WriteLine(Convert.ToDouble(integerAgain));    // Int -> Double
      Console.WriteLine(Convert.ToInt32(doubleAgain));  // Double -> Int
      Console.WriteLine(Convert.ToString(boolAgain));   // Bool -> String

// Use 'Console.ReadLine()' to get user input for a variable.

      Console.WriteLine("Please enter your name.");
      string username = Console.ReadLine();
      Console.WriteLine("Your name is " + username + ".");

// Arithmetic Operators

/*
+ - Addition - 1 + 2 -> 3
- - Subtraction - 5 - 3 -> 2
* - Multiplication - 3 * 4 -> 12
/ - Division - 6 / 2 -> 3
% - Modulus (Division Remainder) - 17 % 4 -> 1 (If you divide 17 by 4, you'll get 4 with a remainder of 1.)
*/

// If you use "[Integer Variable]++", you'll increase the value of that variable by 1.
// If you use "[Integer Variable]--", you'll decrease the value of that variable by 1.

      int added = 0;
      int subtracted = 1;

      added++;
      subtracted--;

      Console.WriteLine(added);
      Console.WriteLine(subtracted);

// Assignment Operators

/*
Operator                Exactly Like
x += y                  x = x + y
x -= y                  x = x - y
x *= y                  x = x * y
x /= y                  x = x / y
x %= y                  x = x % y
x &= y                  x = x & y
x |= y                  x = x | y 
x ^= y                  x = x ^ y
x >>= y                 x = x >> y
x <<= y                 x = x << y
*/
    }
  }
}