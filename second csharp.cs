using System;

namespace MyApplication { // Multiple files can be used for one C# program. Make sure they're all in the same folder.
  class Fruit {
    public string typeOfFruit = "Apple"; // To make a variable accessable by any class/any file, put "public" at the start.
  }

  class EnergyDrink {
    public string brandColor; // You can leave class variables blank to change them later.
    public int calories;
  }
}
