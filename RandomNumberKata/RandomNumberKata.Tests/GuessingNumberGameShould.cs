using FluentAssertions;
using NSubstitute;

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
            var game = GuessingNumberGame.Start(_numberGeneratorMock);

            game.Should().NotBeNull();
        }


        [Fact]
        public void win_if_correct_number()
        {
            var numberToGuess = 1;

            _numberGeneratorMock.GenerateNumber().Returns(numberToGuess);

            var game = GuessingNumberGame.Start(_numberGeneratorMock);

            game.GuessNumber(numberToGuess).Should().Be("win");
        }


        [Fact]
        public void try_again_if_incorrect_number()
        {
            var numberToGuess = 1;

            _numberGeneratorMock.GenerateNumber().Returns(numberToGuess);

            var game = GuessingNumberGame.Start(_numberGeneratorMock);

            game.GuessNumber(numberToGuess).Should().Be("try-again");
        }

    }
}

/*
 * The user starts playing, the game generates a random number that must not change until the game it's over.
 * If the user guesses the number the player wins.
 * If the user does not guess the number the system would have to notify the user if the number it's higher or lower.
 * If the user does not guess the number on three intents it will lose.
 */