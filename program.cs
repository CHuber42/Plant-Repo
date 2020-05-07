using System;
using Plant.Models;

namespace Plant
{
  class Program
  {
    Plant plantyBoi = new Plant(0, 10, 10, 10);
    public static void Main()
    {
      string userInput = "g";
      Console.WriteLine("Hi, you have a plant named PlantyBoi.");
      while (userInput != "f" || userInput != "w" || userInput != "m" || userInput != "e")
      {
        Console.WriteLine("Would you like to [f]eed him, [w]ater him, or [m]ove him into the sun? or [e]xit?");
        userInput = Console.ReadLine();
      }
      // char resp = response[0];

      switch (userInput)
      {
        case "f":
          plantyBoi.Feed();
          break;
        case "w":
          plantyBoi.Water();
          break;
        case "m":
          plantyBoi.MoveIntoSunlight();
          break;
        case "e":
          Console.WriteLine("Goodbye");
          Exit();
        default:
          break;
      }
      Main();
    }
  }
}

