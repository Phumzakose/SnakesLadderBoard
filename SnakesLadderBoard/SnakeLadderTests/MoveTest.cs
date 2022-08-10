using SnakeLadderFunctions;
namespace SnakeLadderTests;

public class MoveTest
{
  Move test = new Move();

  // Tests for StartPlaying Method 
  [Fact]
  public void ItShouldBeAbleToReturn_YouAreToReadyPlay()
  {
    Assert.Equal("You are ready to play!!!", test.StartPlaying(6));
  }
  [Fact]
  public void ItShouldBeAbleToReturn_EnterNumberAgain()
  {
    Assert.Equal("Enter a number again", test.StartPlaying(3));
  }

  // Tests for BlockPosition Method 
  [Fact]
  public void ShouldReturnTheBlockNumberThePlayerIsAtOnTheBoard()
  {
    test.block = 1;
    Assert.Equal(4, test.BlockPosition(3));
  }
  [Fact]
  public void ShouldReturnOneIfTheNumberPlayedIsNotBetweenOneAndSix()
  {
    test.block = 1;
    Assert.Equal(1, test.BlockPosition(8));
  }
}