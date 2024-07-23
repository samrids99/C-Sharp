using System;

namespace PlayingWithInheritance
{
  class Footballer
  {
    // properties
    public string Name
    { get; private set;}
    public string Nationality
    { get; private set;}
    public int ShirtNumber
    { get; private set;}

    // constructor
    public Footballer(string name, string nationality, int shirtNumber)
    {
      this.Name = name;
      this.Nationality = nationality;
      this.ShirtNumber = shirtNumber;
    }

    // method
    public string Kick()
    {
      return $"Number {ShirtNumber} for the blues pings one across the park in a brilliant switch of play";
    }

    public string Score()
    {
      return $"{Name} takes a crack at goal, he's 30 yards out......GOALLLLLL!";
    }
  }
}
