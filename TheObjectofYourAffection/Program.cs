using System;

namespace DatingProfile
{
  class Program
  {
    static void Main(string[] args)
    {
      Profile john = new Profile("John Doe", 28, "Denver, CO", "USA", "he/him");

      john.SetHobbies(new string[] {"Hiking", "Golf", "Football", "Reading", "Coding"});

      Console.WriteLine(john.ViewProfile());
    }
  }
}
