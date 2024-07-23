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
  }
}
