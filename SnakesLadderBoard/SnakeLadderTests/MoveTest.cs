using SnakeLadderFunctions;
namespace SnakeLadderTests;

public class MoveTest
{
  [Fact]
  public void ItShouldBeAbleToReturn_YouAreToReadyPlay()
  {
    Move test1 = new Move();
    Assert.Equal("You are ready to play!!!", test1.StartPlaying(6));
  }
  [Fact]
  public void ItShouldBeAbleToReturn_EnterNumberAgain()
  {
    Move test2 = new Move();
    Assert.Equal("Enter a number again", test2.StartPlaying(3));
  }
}