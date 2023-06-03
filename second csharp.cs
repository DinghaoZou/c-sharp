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

  class FastFood { // Base Parent Class
    public string brand = "McDonalds"; // FastFood Field
    public void eat() { // FastFood Method
      Console.WriteLine("Nom!");
    }
  }

  // If you don't want a class to get inherited by other classed, put "sealed" before the class.

  class TheFoodItself : FastFood { // Derived Child Class
    public string foodType = "Chicken Nuggets"; // TheFoodItself Field
  }

  class Animal {
    public virtual void animalSound() { // The base class uses has the "virtual" keyword for its method.
      Console.WriteLine("Animal made a sound.");
    }
  }

  class Cat : Animal {
    public override void animalSound() { // The derived classes use the "override" keyword so the drived classes can have their own method results with the same method name.
      Console.WriteLine("Meow.");
    }
  }

  class Dog : Animal {
    public override void animalSound() {
      Console.WriteLine("Woof.");
    }
  }

  abstract class Citizen { // An abstract class cannot be used to create an object. It can only be access it by making it be inherited from another class.
    public abstract void catchphrase(); // An abstract method can only be used in an abstract class, and does not have a body. The body comes from the derived class.
    public void sleep() {
      Console.WriteLine("Zzzzzzz...");
    }
  }

  class Joe : Citizen { // Derived class inherited from "Citizen".
    public override void catchphrase() { // The body of "catchphrase" is given here.
      Console.WriteLine("We'll make lots of money tomorrow.");
    }
  }

  interface IPlanet { // An interface is a completely abstract class which can only contain abstract methods and properties. Both abstract classes and interfaces can't create objects.
    void typeOfPlanet(); // Interface method that doesn't have a body.
  }

  class Jupiter : IPlanet { // The class "Jupiter" implements the IPlanet interface.
    public void typeOfPlanet() { // Body of typeOfPlanet is provided here.
      Console.WriteLine("Gas Giant");
    }
  }

  interface IFirstExample {
    void exampleMethod();
  }

  interface ISecondExample {
    void SecondExampleMethod();
  }

  class exampleClass : IFirstExample, ISecondExample { // Multiple interfaces can be implemented, to implement multiple interfaces, separate them with commas.
    public void exampleMethod() {
      Console.WriteLine("Text...");
    }

    public void SecondExampleMethod() {
      Console.WriteLine("Text 2...");
    }
  }
}
