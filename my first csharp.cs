/* "using" lets you use classes from a namespace. */

/* namespace is a code organizer. */

/* "class" is a container for data and methods. */

/* "Console" is a class that belongs to the "System" namespace. */

/* WriteLine() method is used to print a line into the console. It belongs to the "Console" class.*/

/* Should the "using System;" code be unused, one shall write "System.Console.WriteLine()" instead.*/

/* WriteLine() can be used to print numbers. (And it also can be used to calculate math.) */

using System;
using System.Linq;

namespace MyApplication
{
  class Program
  {
      // Multiple methods can have the same name with different parameters and data types.
      static int additionMethod(int x, int y) {
            return x + y;
      }

      static double additionMethod(double x, double y) {
            return x + y;
      }
    static void Main(string[] args) // The method named "Main" will always be executed first.
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

// Comparison Operators
// Compare two values to see if the comparison is true or false. Will return a boolean.

      int biggerNumber = 7;
      int smallerNumber = 4;

      Console.WriteLine(biggerNumber < smallerNumber); // Returns False

/*
== - Equal To
!= - Not Equal To
> - Greater Than
< - Less Than
>= - Greater Than or Equal To
<= - Less Than or Equal To
*/

// Logical Operators

/*
&& - Logical And - Returns True if all statements are True.
|| - Logical Or - Return True if one of the statements are True.
! - Logical Not - Reverse the result, returns False if the result is True.
*/

      Math.Max(5, 10); // Returns 10 - Returns the highest value.
      Math.Min(5, 10); // Returns 5 - Returns the lowest value.
      Math.Sqrt(64); // Return 8 - Returns the square root of the value.
      Math.Abs(-2); // Returns 2 - Returns the absolute value (Positive) of the value.
      Math.Round(9.99); // Returns 10 - Rounds the value to the nearest whole number, then returns the rounded value.

      string allTheLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      Console.WriteLine(allTheLetters.Length); // [String Variable].length - Returns the length of a string in characters.

      Console.WriteLine(allTheLetters.ToUpper()); // [String Variable].ToUpper - Makes all the letters in the string uppercase.
      Console.WriteLine(allTheLetters.ToLower()); // [String Variable].ToLower - Makes all the letters in the string lowercase.

      string firstName = "Harry ";
      string lastName = "Zou";
      string name = firstName + lastName; // The "+" combines the two strings together into one string. (Concatenation)
      Console.WriteLine(name); 

      string firstName2 = "Annie ";
      string lastName2 = "Zou";
      string name2 = string.Concat(firstName2, lastName2); // string.Concat() combines the submitted strings into one string.
      Console.WriteLine(name2);

      Console.WriteLine($"My brother's full name is: {firstName}{lastName}"); // String Interpolation is the act of using variables in a string without putting it outside the string borders. You must put "$" at the beginning of the string to use String Interpolation, and you must put the variables inside curved brackets for String Interpolation to work.

      string greetings = "Hi there!";
      Console.WriteLine(greetings[0]); // To access a character in a string, put the string variable name and brackets at the end with a number inside. The first character is 0, the second character is 1, and so on.
      Console.WriteLine(greetings.IndexOf("e")); // Use IndexOf() to find the first appearance of the character in a string.

      int aCharacterPosition = name.IndexOf("Z");
      string lastNameAgain = name.Substring(aCharacterPosition); // Substring() extracts a part of a string starting from the specified character position, and returns a new string.
      Console.WriteLine(lastNameAgain);

// Use backslash (\) to make special characters in strings.
/*
      \' - ' - Single Quote
      \" - " - Double Quote
      \\ - \ - Backslash
      \n - New Line
      \t - Tab
      \b - Backspace
*/

      int height = 70;

      if (height > 72) { // Checks if a condition is true.
            Console.WriteLine("Wow, you are really tall.");
      } else if (height > 48) { // Checks if this condition is true if the previous condition is false.
            Console.WriteLine("You are the average height, nice.");
      } else { // Runs this code if the rest of the conditions are false.
            Console.WriteLine("Wow, you are really short.");
      }

      string areYouTall = (height > 72) ? "You are tall." : "You are not tall.";
      Console.WriteLine(areYouTall);

      int dayOfTheWeek = 4;

      switch (dayOfTheWeek) // The argument of the switch is the variable the switch checks.
      {
            case 1: // A switch will check if the variable will match with the cases, if it finds a match it will run the code inside the case.
                  Console.WriteLine("Monday");
                  break; // Breaks out of the switch statement.
            case 2:
                  Console.WriteLine("Tuesday");
                  break;
            case 3:
                  Console.WriteLine("Wednesday");
                  break;
            case 4:
                  Console.WriteLine("Thursday");
                  break;
            case 5:
                  Console.WriteLine("Friday");
                  break;
            case 6:
                  Console.WriteLine("Saturday");
                  break;
            case 7:
                  Console.WriteLine("Sunday");
                  break;
            default: // Acts like an "else" for "switch' statements, specifies a code to run if the variable of the argument doesn't match with any of the cases.
                  Console.WriteLine("That's not a day of the week.");
                  break;
      }

      int aNumberAgain = 0;

      while (aNumberAgain < 5) { // A "while" statement constantly runs a code as long the condition is true.
            Console.WriteLine(aNumberAgain);
            aNumberAgain++;
      }
 
      aNumberAgain = 0;

      // The "do" statement is a flipped version of the "while" statement. First it runs the code, then it checks if the condition is true. If the condition is true, it runs the code in the "do" statement again.
      do {
            Console.WriteLine(aNumberAgain);
            aNumberAgain++;
      } while (aNumberAgain < 5);

      // In a "for" statment:

      /*
            The first statement is a code that is ran only one time before the loop.
            The second statment is the condition for the loop.
            The third statment is a code that is ran after the code in the "for" loop is ran. 
      */

      for (int aNumberAgainAgain = 0; aNumberAgainAgain < 5; aNumberAgainAgain++) {
            Console.WriteLine(aNumberAgainAgain);
      }

      string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

      foreach (string i in cars) { // "foreach" is a statement that loops through elements in an array.
            Console.WriteLine(i);
      }

      for (int anotherIntegerHaha = 0; anotherIntegerHaha < 10; anotherIntegerHaha++) {
            if (anotherIntegerHaha == 4) {
                  break; // The "break" statement stops a loop.
            }
            Console.WriteLine(anotherIntegerHaha);
      }

      for (int aaaaa = 0; aaaaa < 10; aaaaa++) {
            if (aaaaa == 4) {
                  continue; // The "continue" statement skips a loop section.
            }
            Console.WriteLine(aaaaa);
      }

      // To make an array, put square brackets at the end of the variable type name.
      string[] languages = {"Chinese", "English", "Japanese"};
      int[] numbersOfTen = {10, 20, 30, 40, 50};

      languages[2] = "Spanish"; // To change a specific array element, put the index number in brackets after the variable name.

      Console.WriteLine(languages.Length); // Find how long an array is with the "Length" property.

      // Different ways to create arrays:

      string[] emptyArray = new string[4]; // Creates an empty array to add values later.
      string[] fruits = new string[4] {"Apple", "Orange", "Banana", "Peach"}; // Creates an array right away.
      string[] vegetables = new string[] {"Spinach", "Lettuce", "Carrot"}; // Creates an array without specifiying the size.
      string[] snacks = {"Doritos", "Lays"}; // Creates an array without specifiying the size and without using the "new" keyword.

      // If you add values to an already existing array, you must use the "new" keyword or else it will cause an error.

      string[] notEmptyArray;
      notEmptyArray = new string[] {"Not", "Empty", "Array"};

      string[] alphabetsNotInOrder = {"C", "A", "B"};
      Array.Sort(alphabetsNotInOrder); // Use the "Sort" method to sort an array alphabetically (Strings) or in a numerical ascending order. (Integers)
      int[] numbersNotInOrder = {3, 1, 2};
      Array.Sort(numbersNotInOrder);

      foreach (string blah in cars) {
            Console.WriteLine(blah);
      }
      foreach (string blahblah in cars) {
            Console.WriteLine(blahblah);
      }

      int[] numbersAgainAndAgain = {6, 1, 8, 9};
      Console.WriteLine(numbersAgainAndAgain.Max());  // Returns Largest Value
      Console.WriteLine(numbersAgainAndAgain.Min());  // returns Smallest Value
      Console.WriteLine(numbersAgainAndAgain.Sum());  // Returns the Sum of All of the Numbers
      // All of these methods require the "System.Linq" namespace.

      // To put arrays in an array, put a comma inside the square brackets.
      int[,] arrayInArray = {{1, 4, 2}, {3, 6, 5}};
      // To access elements in an array in an array, use multiple indexes based on how deep the array is.
      Console.WriteLine(arrayInArray[0, 1]);
      // Using a "foreach" on an array in an array will output all of the elements, but not whole arrays.
      foreach (int aeiou in arrayInArray) {
            Console.WriteLine(aeiou);
      }

      static void myFirstMethod() { // A method is a bunch of code that can be saved and used for later. Useful for not clogging up the code.
            Console.WriteLine("Method executed.");
      }

      myFirstMethod();

      static void myFriendIs(string friendName, string friendIsA) { // You can put parameters in a method so that when you use the method, you can change some of the values inside the method.
            Console.WriteLine("My friend is " + friendName + " and they're a " + friendIsA + ".");
      }

      myFriendIs("Moonlight", "Fox-Cat Hybrid");
      myFriendIs("AJ", "Finarian");
      myFriendIs("Podz", "Crewmate");
      myFriendIs(friendIsA: "Demon Cat", friendName: "Staples"); // You can use the "key: value" syntax so that the order of the arguments doesn't matter.

      static void countries(string country = "China") { // You can set a default parameter value, making the parameter optional.
            Console.WriteLine(country);
      }

      countries("United States");
      countries("Japan");
      countries(); // Because the parameter isn't set, it will output the default value, which is China.
      countries("Mexico");

      static int fivePlus(int x) { // To make a method return a value, put a data type instead of "void".
            return 5 + x; // Use "return" to return a value.
      }

      Console.WriteLine(fivePlus(5));

      // Multiple methods can have the same name with different parameters and data types.

      Console.WriteLine(additionMethod(3.2, 4.6));
      Console.WriteLine(additionMethod(3, 4));

      Car.notMain(); // You can access methods from other classes via [Class Name].[Method Name]();.

      Fruit myFirstFruit = new Fruit(); // You can create objects using classes from other files.
      Console.WriteLine(myFirstFruit.typeOfFruit);

      EnergyDrink cocaCola = new EnergyDrink();
      cocaCola.brandColor = "Red"; // You can change an object's properties later.
      cocaCola.calories = 182;
      Console.WriteLine("Coca Cola's brand color is " + cocaCola.brandColor + ".");

      learningBook algebraBook = new learningBook();
      Console.WriteLine(algebraBook.subject);

      pet aDog = new pet();
      aDog.Name = "Lucky"; // Using the "Name" method, you can access the private field.
      Console.WriteLine(aDog.Name);

      TheFoodItself aNewPiece = new TheFoodItself(); // Make a "aNewPiece" object from the "TheFoodItself" class.
      aNewPiece.eat(); // Because "TheFoodItself" is derived from "FastFood", "aNewPiece" has all the fields and methods from both "TheFoodItself" and "FastFood".
      Console.WriteLine(aNewPiece.brand + " " + aNewPiece.foodType);

      Animal myAnimal = new Animal();
      Animal myCat = new Cat();
      Animal myDog = new Dog();

      myAnimal.animalSound();
      myCat.animalSound();
      myDog.animalSound();
    }
  }

  public class Car { // A class is a template for objects. To make a class accessable by other classes, put "public" at the start of the class.
      string color = "Red";

      public static void notMain() {
            Car myFirstObject = new Car(); // By creating an object, which is an instance of a class, it has properties given by the class.
            Console.WriteLine(myFirstObject.color); // To access an object's properties, do [Object Name].[Property Name].
      }
  }
}