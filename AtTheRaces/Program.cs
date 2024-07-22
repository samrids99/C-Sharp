using System;

namespace AtTheRaces
{
  class Program
  {
    static void Main(string[] args)
    {
      // set out fields
      int userMoney = 150;
      bool continuePlaying = true;
      Random winner = new Random();
      string[] horses = new string[] {"RedRum","Maximus", "Air Horse One", "I'm Coasting", "Hasta La Vista", "Bolt"};

      // introduce to the game and set the scene
      Console.WriteLine("Welcome to your day at the races!!");
      Console.WriteLine("A fun little game to demonstrate some C# knowledge :)");
      Console.WriteLine("\n");
      Console.WriteLine("6 horses are about to give it their all to reach the finish first and claim glory, your job is to pick the winner");
      Console.WriteLine("\n");
      Console.WriteLine("First place will see your bet tripled! Can you reach $500..?");
      Console.WriteLine("\n");

    // while loop to make sure the user wants to continue playing
    while (continuePlaying && userMoney > 0)
    {
      // give balance and get bet
      Console.WriteLine($"Your current balance is ${userMoney}");
      Console.WriteLine("How much are you willing to bet: ");
      string betString = Console.ReadLine();
      int bet = Int32.Parse(betString);

      // bet has to be within financial capacity
      if (bet > userMoney || bet <= 0)
      {
        Console.WriteLine("Invalid bet amount. Try again.");
        continue;
      }

      // Choose a horse
      Console.WriteLine("\n");
      Console.WriteLine("It's now time to choose your champion...");
      Console.WriteLine("\n");
      Console.WriteLine($"In lane 1 we have: {horses[0]}\nIn lane 2 we have: {horses[1]}\nIn lane 3 we have: {horses[2]}\nIn lane 4 we have: {horses[3]}\nIn lane 5 we have: {horses[4]}\nIn lane 6 we have: {horses[5]}");
      Console.WriteLine("Choose by picking the lane of your desired horse:");
      string horseChoice = Console.ReadLine();
      int horseIndex = Int32.Parse(horseChoice) - 1;

      // make sure horse exists
      if (horseIndex < 0 || horseIndex > 5)
      {
        Console.WriteLine("Invalid lane selection. Please try again.");
        continue;
      }

      // get horse winner using random
      int winningHorseIndex = winner.Next(0, 6);
      Console.WriteLine("The winner of the race was.......");
      Console.WriteLine($"{horses[winningHorseIndex]}");

      // is it a winner?
      if (horseIndex == winningHorseIndex)
      {
        userMoney += (bet*3);
        Console.WriteLine($"Congrats! You have just won ${bet*3}!");
      }
      else // is it a loser?
      {
        Console.WriteLine($"Better luck next time, you lost your ${bet}.");
        userMoney -= bet;
      }

      // show updated balance
      Console.WriteLine($"Your new balance is ${userMoney}.");

      // is the user able to continue playing?
      if (userMoney >= 500)
      {
        Console.Write("You have successfully bankrupt the racecourse, thanks for playing!");
        continuePlaying = false;
      }
      else if (userMoney > 0)
      {
        Console.WriteLine("Would you like to continue? (y/n):");
        string keepPlaying = Console.ReadLine();
        // does the user want to continue playing?
        continuePlaying = keepPlaying.ToLower() == "y";
      }
      else
      {
        Console.WriteLine("You're bankrupt, thanks for all your money! Please come again...");
        continuePlaying = false;
      }
    }
    }
  }
}
