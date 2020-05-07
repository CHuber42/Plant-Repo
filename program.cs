using System;
using System.Collections.Generic;
using Plant.Models;

namespace Plant
{
  class Program
  {
    public static PlantClass plantyBoi = new PlantClass(0, 8, 10, 10);
    public static bool flag = false;

    public static void Main()
    {
      string userInput = "g";

      if (flag == false)
      {
        flag = true;
        Console.WriteLine("Hi, you have a plant named PlantyBoi.");
      }

      while (userInput != "f" && userInput != "w" && userInput != "m" && userInput != "e")
      {
        Console.WriteLine("Would you like to [f]eed him, [w]ater him, or [m]ove him into the sun? or [e]xit?");
        userInput = Console.ReadLine();
      }

      switch (userInput)
      {
        case "f":
          plantyBoi.Feed();
          break;
        case "w":
          plantyBoi.Water();
          break;
        case "m":
          plantyBoi.PutInSunlight();
          break;
        case "e":
          Console.WriteLine("Goodbye");
          Environment.Exit(0);
          break;
        default:
          break;
      }

      Main();

    }

  }


}
