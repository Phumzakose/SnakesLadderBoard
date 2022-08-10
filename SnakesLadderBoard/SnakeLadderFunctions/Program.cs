// See https://aka.ms/new-console-template for more information
using SnakeLadderFunctions;

// Welcome msg
Console.WriteLine("Welcome to snake ladder board");

int diceStart = 0;
// Before the game
while (diceStart < 6)
{
  Console.WriteLine("Enter a value from 1 to 6");
  diceStart = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("===========================================================");
}

// Instance of the class
Move test = new Move();
Console.WriteLine(test.StartPlaying(diceStart));

// Start of the game
int diceResult = 0;
while (test.block < 100)
{
  Console.WriteLine("Please roll the dice again");

  int diceValue = Convert.ToInt32(Console.ReadLine());

  diceResult = test.BlockPosition(diceValue);

  diceResult = (test.ClimbLadders(diceResult) != 0) ? test.ClimbLadders(diceResult) : diceResult;
  diceResult = (test.EatenBySnake(diceResult) != 0) ? test.EatenBySnake(diceResult) : diceResult;

  Console.WriteLine("===========================================================");
  Console.WriteLine(test.Message(diceResult));
  Console.WriteLine($"Block : [{diceResult}]");
  Console.WriteLine("===========================================================");
}



