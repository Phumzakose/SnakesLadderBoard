namespace SnakeLadderFunctions;

public class Move
{


  int board = 100;
  public int block;
  //public int Block { get; set; }
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

  public int BlockStage(int dice)
  {
    if (dice >= 0 && dice < 7 && block >= 1)
    {
      return block += dice;
    }
    return 0;
  }

  public int Ladders(int blockValue)
  {
    if (blockValue == 1)
    {
      block = 38;
      return block;
    }
    else if (blockValue == 4)
    {
      block = 14;
      return block;
    }
    else if (blockValue == 8)
    {
      block = 30;
      return block;
    }
    return 0;
  }


  public int Snakes(int blockValue)
  {
    if (blockValue == 32)
    {
      block = 10;
      return block;
    }
    else if (blockValue == 36)
    {
      block = 6;
      return block;
    }
    return block;
  }

  public string Message(int blockValue)
  {
    List<int> numbers = new List<int>() { 6, 10, 18, 26, 78, 24, 56 };
    if (numbers.Contains(blockValue))
    {
      return "Oops you have been eaten by a snake";
    }
    return "";
  }

  public string LedderMsg(int blockValue)
  {
    List<int> numbers = new List<int>() { 1, 14, 30, 42, 76, 67, 92, 99 };

    if (numbers.Contains(blockValue))
    {
      return "Hooray! you climbed the ladder!";
    }
    return "";
  }

}