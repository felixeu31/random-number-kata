namespace RandomNumberKata.Tests
{
    public class GuessingNumberGameShould
    {
        private INumberGenerator _numberGeneratorMock;

        //Setup
        public GuessingNumberGameShould()
        {
            _numberGeneratorMock = Substitute.For<INumberGenerator>();
        }

        [Fact]
        public void Start()
        {
            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.Should().NotBeNull();
        }


        [Fact]
        public void win_if_correct_number()
        {
            var numberToGuess = 1;

            _numberGeneratorMock.GenerateNumber().Returns(numberToGuess);

            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.GuessNumber(numberToGuess).Should().Be(GuessingNumberGame.WIN);
        }


        [Fact]
        public void lower_if_higher_number()
        {
            _numberGeneratorMock.GenerateNumber().Returns(1);

            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.GuessNumber(2).Should().Be(GuessingNumberGame.LOWER);
        }


        [Fact]
        public void higher_if_lower_number()
        {
            _numberGeneratorMock.GenerateNumber().Returns(2);

            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.GuessNumber(1).Should().Be(GuessingNumberGame.HIGHER);
        }


        [Fact]
        public void lose_if_maximum_attempts_reached()
        {
            _numberGeneratorMock.GenerateNumber().Returns(2);

            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.GuessNumber(1);
            game.GuessNumber(1);
            game.GuessNumber(1).Should().Be(GuessingNumberGame.LOSE);
        }




        [Fact]
        public void lose_always_once_lost_game()
        {
            _numberGeneratorMock.GenerateNumber().Returns(2);

            var game = GuessingNumberGame.StartGame(_numberGeneratorMock);

            game.GuessNumber(1);
            game.GuessNumber(1);
            game.GuessNumber(1);
            game.GuessNumber(2).Should().Be(GuessingNumberGame.LOSE);
        }


    }
}

/*
 * The user starts playing, the game generates a random number that must not change until the game it's over.
 * If the user guesses the number the player wins.
 * If the user does not guess the number the system would have to notify the user if the number it's higher or lower.
 * If the user does not guess the number on three intents it will lose.
 */