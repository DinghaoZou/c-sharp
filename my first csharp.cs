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
    }
  }
}