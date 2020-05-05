using System;

namespace RPS2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");

      //create var to manage while loop and initialize
      var playing = true;
      //create var to hold invalid entry string
      var invalid = "That is not a valid selection.";
      //var to hold valid rps selections
      var rps = "Valid entries are rock, paper, scissors, lizard, or spock.";
      //var to hold valid y or n
      var yOrN = "Valid entries are y (yes) or n (no).";
      //var to hold valid diff string
      var diff = "Valid entries are e (easy), n (normal), or i (impossible).";
      //create var to hold computer selection
      var cpuSelection = "";

      while (playing)
      {

        //var to hold difficulty and initial val
        var difficulty = "norm";
        //vars to hold isValid booleans and initial values
        var rpsIsValid = false;
        var ynIsValid = false;
        var diffIsValid = false;
        //var for playagain
        var playAgain = "";
        //set var to hold player choice
        var playerSelection = "";
        Console.WriteLine("Player, please choose a difficulty level.");
        Console.WriteLine($"{diff}");

        //error catching
        while (!diffIsValid)
        {
          difficulty = Console.ReadLine().ToLower();
          if (difficulty != "e" && difficulty != "n" && difficulty != "i")
          {
            Console.WriteLine($"{invalid}");
            Console.WriteLine($"{diff} Please try again.");
          }
          else
          {
            diffIsValid = true;
          }
        }
        Console.WriteLine("Player, please enter your selection.");
        Console.WriteLine($"{rps}");

        //error catching
        while (!rpsIsValid)
        {
          playerSelection = Console.ReadLine().ToLower();
          if (playerSelection != "rock" && playerSelection != "paper" && playerSelection != "scissors" && playerSelection != "lizard" && playerSelection != "spock")
          {
            Console.WriteLine($"{invalid}");
            Console.WriteLine($"{rps} Please try again.");
          }
          else
          {
            rpsIsValid = true;
          }
        }

        //difficulty logic
        if (difficulty == "e")
        {
          if (playerSelection == "rock")
          {
            cpuSelection = "scissors";
          }
          else if (playerSelection == "paper")
          {
            cpuSelection = "rock";
          }
          else if (playerSelection == "scissors")
          {
            cpuSelection = "paper";
          }
          else if (playerSelection == "lizard")
          {
            cpuSelection = "spock";
          }
          else { cpuSelection = "rock"; }
        }
        else if (difficulty == "i")
        {
          if (playerSelection == "rock")
          {
            cpuSelection = "paper";
          }
          else if (playerSelection == "paper")
          {
            cpuSelection = "scissors";
          }
          else if (playerSelection == "scissors")
          {
            cpuSelection = "rock";
          }
          else if (playerSelection == "lizard")
          {
            cpuSelection = "rock";
          }
          else
          {
            cpuSelection = "lizard";
          }
        }
        else
        {
          //create new random instance
          Random rando = new Random();
          //set output for rando
          int randOutput = rando.Next(1, 5);
          //set cpuSelection based on rando
          if (randOutput == 1)
          {
            cpuSelection = "rock";
          }
          else if (randOutput == 2)
          {
            cpuSelection = "paper";
          }
          else if (randOutput == 3)
          {
            cpuSelection = "scissors";
          }
          else if (randOutput == 4)
          {
            cpuSelection = "lizard";
          }
          else { cpuSelection = "spock"; }
        }

        Console.WriteLine($"Player selected {playerSelection}. Computer selected {cpuSelection}.");
        //compare selections and display winner
        //player loss conditions
        if ((cpuSelection == "rock" && playerSelection == "scissors") ||
         (cpuSelection == "paper" && playerSelection == "rock") ||
          (cpuSelection == "scissors" && playerSelection == "paper") ||
           (cpuSelection == "spock" && playerSelection == "rock") ||
            (cpuSelection == "spock" && playerSelection == "scissors") ||
             (cpuSelection == "lizard" && playerSelection == "paper") ||
              (cpuSelection == "lizard" && playerSelection == "spock") ||
              (cpuSelection == "rock" && playerSelection == "lizard") ||
              (cpuSelection == "paper" && playerSelection == "spock") ||
              (cpuSelection == "scissors" && playerSelection == "lizard"))
        {
          Console.WriteLine("Player lost.");
          //tie conditions
        }
        else if ((cpuSelection == "scissors" && playerSelection == "scissors") ||
         (cpuSelection == "rock" && playerSelection == "rock") ||
          (cpuSelection == "paper" && playerSelection == "paper") ||
          (cpuSelection == "lizard" && playerSelection == "lizard") ||
          (cpuSelection == "spock" && playerSelection == "spock"))
        {
          Console.WriteLine("Tie game.");
        }
        else
        {
          Console.WriteLine("Player wins!");
        }


        Console.WriteLine("Would you like to play again?");
        Console.WriteLine($"{yOrN}");
        //error catching
        while (!ynIsValid)
        {
          playAgain = Console.ReadLine().ToLower();
          if (playAgain != "y" && playAgain != "n")
          {
            Console.WriteLine($"{invalid}");
            Console.WriteLine($"{yOrN}");
          }
          else
          {
            ynIsValid = true;
          }
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
