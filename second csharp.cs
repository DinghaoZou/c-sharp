using System;

namespace MyApplication { // Multiple files can be used for one C# program. Make sure they're all in the same folder.
  class Fruit {
    public string typeOfFruit = "Apple"; // To make a variable accessable by any class/any file, put "public" at the start.
  }

  class EnergyDrink {
    public string brandColor; // You can leave class variables blank to change them later.
    public int calories;
  }

// C# Access Modifiers

/*
Public - Accessible For All Classes
Private - Only Accessible For The Same Class
Protected - Accessible For The Same Class Or A Class That Is Inherited From That Class
Internal - Only Accessible Within Own Assembly, Not From Another Assembly
*/

// Access Modifiers are useful to hide sensitive data.
  class learningBook { // This class is a constructor.
    public string subject; // This is a property the will be put on an object after the constructor made it.

    public learningBook(string subjEct = "Algebra") { // This gives the object a default value.
      subject = subjEct; 
    }
  }

  class pet {
    private string name; // Field

    public string Name { // Property
      get {return name;} // Returns the value of the variable "name".
      set {name = value;} // Assigns a "value" to the "name" variable, which represents the value that is assigned to the property.
    }
  }
}
