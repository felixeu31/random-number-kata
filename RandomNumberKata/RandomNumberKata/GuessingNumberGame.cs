namespace RandomNumberKata;

public class GuessingNumberGame
{
    public const string Win = "win";
    public const string Lower = "lower";
    public const string Higher = "higher";
    public const string Lose = "lose";
    private const int MaximumAttemptNumber = 3;
    private readonly int _numberToGuess;
    private readonly List<Attempt> _attempts = new List<Attempt>();

    public GuessingNumberGame(int numberToGuess)
    {
        _numberToGuess = numberToGuess;
    }

    public static GuessingNumberGame StartGame(INumberGenerator numberGenerator)
    {
        return new GuessingNumberGame(numberGenerator.GenerateNumber());
    }

    public string GuessNumber(int guessedNumber)
    {
        if (ExceededMaximumNumberOfAttempts())
            return Lose;

        var attempt = CreateNewAttempt(guessedNumber);
        _attempts.Add(attempt);

        if (attempt.IsSuccessful())
            return Win;

        if (ExceededMaximumNumberOfAttempts())
            return Lose;

        return attempt.Recommendation(_numberToGuess);
    }

    private Attempt CreateNewAttempt(int guessedNumber)
    {
        if (guessedNumber == _numberToGuess)
            return Attempt.SusccessfullAttempt(guessedNumber);
        
        return Attempt.BadAttempt(guessedNumber);
    }

    private bool ExceededMaximumNumberOfAttempts()
    {
        return _attempts.Count >= MaximumAttemptNumber;
    }
}