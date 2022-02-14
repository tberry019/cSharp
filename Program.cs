// // See https://aka.ms/new-console-template for more information



// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.Green;


class cSharp
{
  static void Main(string[] args)
  {
    Random random = new Random();

    String player;
    String computer;
    String answer;

    {
      player = "";
      computer = "";
      answer = "";

      while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
      {
        Console.Write("Type ROCK, PAPER, or SCISSORS: ");
        player = Console.ReadLine();
        player = player.ToUpper();
      }


      switch (random.Next(1, 4))
      {
        case 1:
          computer = "ROCK";
          break;
        case 2:
          computer = "PAPER";
          break;
        case 3:
          computer = "SCISSORS";
          break;
      }

      Console.WriteLine("Human: " + player);
      Console.WriteLine("Robot: " + computer);

      switch (player)
      {
        case "ROCK":
          if (computer == "ROCK")
          {
            Console.WriteLine("It's a draw, lame!");
          }
          else if (computer == "PAPER")
          {
            Console.WriteLine("You loser!");
          }
          else
          {
            Console.WriteLine("You win bro!");
          }
          break;
        case "PAPER":
          if (computer == "ROCK")
          {
            Console.WriteLine("You win bro!");
          }
          else if (computer == "PAPER")
          {
            Console.WriteLine("It's a draw, lame!");
          }
          else
          {
            Console.WriteLine("You loser!");
          }
          break;
        case "SCISSORS":
          if (computer == "ROCK")
          {
            Console.WriteLine("You loser!");
          }
          else if (computer == "PAPER")
          {
            Console.WriteLine("You win bro!");
          }
          else
          {
            Console.WriteLine("It's a draw, lame!");
          }
          break;
      }


      answer = Console.ReadLine();
      answer = answer.ToUpper();
    }
    Console.ReadKey();
  }
}


