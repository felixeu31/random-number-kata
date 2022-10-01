namespace RandomNumberKata.Tests
{
    public class GameShould
    {
        [Fact]
        public void Start()
        {
            var game = Game.Start();
        }
    }
}

/*
 * The user starts playing, the game generates a random number that must not change until the game it's over.
 * If the user guesses the number the player wins.
 * If the user does not guess the number the system would have to notify the user if the number it's higher or lower.
 * If the user does not guess the number on three intents it will lose.
 */