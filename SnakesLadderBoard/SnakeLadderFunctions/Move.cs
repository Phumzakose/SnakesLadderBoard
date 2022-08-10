namespace SnakeLadderFunctions;

public class Move
{
  
  int board = 100;
  public int block;

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
    Dictionary<int,int> ladderBlocks = new Dictionary<int, int>() 
    {
      {1, 38}, {4, 14}, {8, 30}, {21, 42}, {28, 76}, {50, 67}, {71, 92}, {80, 99}
    };

    foreach(var kvp in ladderBlocks)
    {
      if(ladderBlocks.ContainsKey(blockValue))
      {
        block = kvp.Value;
        break;
      }
    }
    return block;
  }


  // Eaten by snake method
  public int EatenBySnake(int blockValue)
  {
    Dictionary<int,int> snakeBlocks = new Dictionary<int, int>() 
    {
      {97, 78}, {95, 56}, {88, 24}, {62, 18}, {36, 6}, {48, 26}, {32, 10}
    };

      foreach(var kvp in snakeBlocks)
    {
      if(snakeBlocks.ContainsKey(blockValue))
      {
        block = kvp.Value;
        break;
      }
    }
    return block;

  }

  // Display msg when climbed the ladder or eaten by a snake
  public string Message(int blockValue)
  {
    List<int> snakesTails = new List<int>() { 6, 10, 18, 26, 78, 24, 56 };
    List<int> ladderPositions = new List<int>() { 38, 14, 30, 42, 76, 67, 92, 99 };

    if (snakesTails.Contains(blockValue))
    {
      return "Oops you have been eaten by a snake";
    }
    else if (ladderPositions.Contains(blockValue))
    {
      return "Hooray! you climbed the ladder!";
    }
    else{
      return "Good play!";
    }
  }
}