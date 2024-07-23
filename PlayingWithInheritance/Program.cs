using System;

namespace PlayingWithInheritance
{
  class Program
  {
   static void Main(string[] args)
    {

      // generic footballer
      Footballer sam = new Footballer("Sam Ridsdale", "England", 8);
      Console.WriteLine(sam.Score());
      Console.WriteLine(sam.Kick());

      // reserve
      Reserve marc = new Reserve("Marc Cucurella", "España", 24);
      Console.WriteLine(marc.Score());
      Console.WriteLine(marc.Kick());

      // starter
      Starter cold = new Starter("Cold Palmer", "England", 20);
      Console.WriteLine(cold.Kick());
      Console.WriteLine(cold.Win());
    }
  }

}
