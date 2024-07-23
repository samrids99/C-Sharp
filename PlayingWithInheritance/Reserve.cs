using System;

namespace PlayingWithInheritance
{
  class Reserve : Footballer
  {
    public Reserve(string name, string nationality, int shirtNumber) : base(name, nationality, shirtNumber)
    {
    }

    public override string Score()
    {
      return $"{Name} takes a crack at goal, he's 30 yards out......OH MY WORD that's one of the worst attempts I've seen. It's gone for a throw!";
    }
  }
}
