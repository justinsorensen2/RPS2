using System;

namespace RPS2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");

      //create var to manage while loop
      var playing = true;
      //create var to hold invalid entry string
      var invalid = "That is not a valid selection.";
      //var to hold valid rps selections
      var rps = "Valid entries are rock, paper, or scissors.";
      //var to hold valid y or n
      var yOrN = "Valid entries are y (yes) or n (no).";

      while (playing)
      {
        Console.WriteLine("Player, please enter your selection.");
        Console.WriteLine($"{rps}");

        //set var to hold player choice
        var playerSelection = Console.ReadLine().ToLower();
        //error catching
        if (playerSelection == "rock" && playerSelection != "paper" && playerSelection != "scissors")
        {
          Console.WriteLine($"{invalid}");
          Console.WriteLine($"{rps} Please try again.");
          playerSelection = Console.ReadLine().ToLower();
        }
        //create var to hold computer selection
        var cpuSelection = "RPS";
        //create new random instance
        Random rando = new Random();
        //set output for rando
        int randOutput = rando.Next(1, 3);
        //set cpuSelection based on rando
        if (randOutput == 1)
        {
          cpuSelection = "rock";
        }
        else if (randOutput == )
        {
          cpuSelection = "paper";
        }
        else
        {
          cpuSelection = "scissors";
        }

        Console.WriteLine($"Player selected {playerSelection}. Computer selected {cpuSelection}.");
        //compare selections and display winner
        //player loss conditions
        if ((cpuSelection == "rock" && playerSelection == "scissors") || (cpuSelection == "paper" && playerSelection == "rock") || (cpuSelection == "scissors" && playerSelection == "paper"))
        {
          Console.WriteLine("Player lost.");
          //tie conditions
        }
        else if ((cpuSelection == "scissors" && playerSelection == "scissors") || (cpuSelection == "rock" && playerSelection == "rock") || (cpuSelection == "paper" && playerSelection == "paper"))
        {
          Console.WriteLine("Tie game.");
        }
        else
        {
          Console.WriteLine("Player wins!");
        }


        Console.WriteLine("Would you like to play again?");
        Console.WriteLine($"{yOrN}");
        var playAgain = Console.ReadLine().ToLower();
        //error catching
        if (playAgain != "y" && playAgain != "n")
        {
          Console.WriteLine($"{invalid}");
          Console.WriteLine($"{yOrN}");
          playAgain = Console.ReadLine().ToLower();
        }
        //determine what to do based on input - replay or not
        if (playAgain == "y")
        {
          Console.WriteLine("Ok. On to the next round.");
        }
        else
        {
          Console.WriteLine("Thank you for playing. Goodbye.");
          playing = false;
        }
      }
    }
  }
}
