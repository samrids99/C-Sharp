using system;

namespace AtTheRaces
{
  class Program
  {
    static void Main(string[] args)
    {
      int userMoney = 150;
      bool continue = true;
      Random winner = new Random();

      Console.WriteLine("Welcome to your day at the races!!");
      Console.WriteLine("A fun little game to demonstrate some C# knowledge :)");
      Console.WriteLine("\n");
      Console.WriteLine("6 horses are about to give it their all to reach the finish first and claim glory, your job is to pick the winner");
      Console.WriteLine("\n");
      Console.WriteLine("First place will see your bet tripled, whilst second and third provide your money back. Can you reach $1000..?")
    }
  }

}
