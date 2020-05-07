using System;

namespace Plant.Models
{
  public class PlantClass
  {

    public int Height { get; set; }
    public int WaterLevel { get; set; }

    public int Food { get; set; }

    public int Health { get; set; }
    public PlantClass(int height, int waterLevel, int food, int health)
    {
      Height = height;
      WaterLevel = waterLevel;
      Food = food;
      Health = health;

    }

    public void Water()
    {
      WaterLevel += 5;
      if (WaterLevel >= 10)
      {
        WaterLevel = 10;
      }
      NextRound();
    }

    public void Feed()
    {
      Food += 5;
      if (Food >= 10)
      {
        Food = 10;
      }
      NextRound();
    }

    public void PutInSunlight()
    {
      Health += 2;
      if (Health >= 10)
      {
        Health = 10;
      }
      NextRound();
    }

    public void NextRound()
    {
      if (Health >= 7 && WaterLevel >= 7 && Feed >= 7)
      {
        Height += 1;
      }

      if (Health < 5 || WaterLevel < 5 || Feed < 5)
      {
        Height -= 1;
      }

      Random rand = new Random();
      int count = rand.Next(1, 10);

      switch (count)
      {
        case 1:
          SlugBite();
          break;
        case 2:
          WindStorm();
          break;
        case 3:
          AphidAttack();
          break;
        default:
          break;
      }

      Feed -= 1;
      WaterLevel -= 1;

      Console.WriteLine($"Current Water Level: {WaterLevel} Current Food Level: {Feed} Current Health: {Health} Current Height: {Height}");
    }

    public void SlugBite()
    {
      Health -= 1;
    }

    public void WindStorm()
    {
      Health -= 2;
    }

    public void AphidAttack()
    {
      Health -= 3;
    }
  }
}
