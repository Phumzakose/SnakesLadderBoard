namespace SnakeLadderFunctions;

public class Move
{

    int board = 100;
    public int block;
    Dictionary<int, int> ladderBlocks = new Dictionary<int, int>()
    {
      {1, 38}, {4, 14}, {8, 30}, {21, 42}, {28, 76}, {50, 67}, {71, 92}, {80, 99}
    };
      Dictionary<int, int> snakeBlocks = new Dictionary<int, int>()
    {
      {97, 78}, {95, 56}, {88, 24}, {62, 18}, {36, 6}, {48, 26}, {32, 10}
    };

    // Roll 6 before you can play
    public string StartPlaying(int dice)
    {
        if (dice == 6)
        {
            block = 1;
            return "You are ready to play!!!";
        }
        else
        {
            return "Enter a number again";
        }
    }


    // Position of the block on the board
    public int BlockPosition(int dice)
    {
        if (dice > 0 && dice < 7 && block >= 1)
        {
            return block += dice;
        }
        return block;
    }


    // Climbing ladder method
    public int ClimbLadders(int blockValue)
    {
        foreach (var kvp in ladderBlocks)
        {
            if (kvp.Key == blockValue) return block = kvp.Value;
        }
        return block;
    }

    // Eaten by snake method
    public int EatenBySnake(int blockValue)
    {
        foreach (var kvp in snakeBlocks)
        {
            if (kvp.Key == blockValue)
            {
                return block = kvp.Value;
            }
        }
        return block;
    }
    
    // Display msg when climbed the ladder or eaten by a snake
    public string Message(int blockValue)
    {
        if (snakeBlocks.ContainsKey(blockValue))
        {
            return "Oops you have been eaten by a snake 🪱";
        }
        else if (ladderBlocks.ContainsKey(blockValue))
        {
            return "Hooray! you climbed the ladder! 🪜";
        }
        else
        {
            return "Good play!";
        }
    }

    public static void ShowBoard()
    {
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


            Console.WriteLine("===========================================================");
            Console.WriteLine(test.Message(diceResult));

            diceResult = (test.ClimbLadders(diceResult) != 0) ? test.ClimbLadders(diceResult) : diceResult;
            diceResult = (test.EatenBySnake(diceResult) != 0) ? test.EatenBySnake(diceResult) : diceResult;

            Console.WriteLine($"Block : [{diceResult}]");
            Console.WriteLine("===========================================================");
        }
    }
}