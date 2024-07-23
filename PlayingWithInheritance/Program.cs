using System;

namespace PlayingWithInheritance
{
  class Program
  {
    public static Main(string[] args)
    {
      Reserve marc = new Reserve("Marc Cucurella", "España", 24);
      Console.WriteLine(marc.Score());
    }
  }

}
