using System;

namespace PlayingWithInheritance
{
  class Starter : Reserve
  {
    public Starter(string name, string nationality, int shirtNumber) : base(name, nationality, shirtNumber)
    {
    }

    public string Win()
    {
      return $"The man hailing from {Nationality} finally lifts the trophy for his country! Remember the name...{Name}";
    }
  }

}
