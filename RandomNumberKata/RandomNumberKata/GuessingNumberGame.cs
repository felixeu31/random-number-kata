namespace RandomNumberKata;

public class GuessingNumberGame
{
    public const string WIN = "win";
    public const string LOWER = "lower";
    public const string HIGHER = "higher";
    public const string LOSE = "lose";
    private const int _maximumAttemptNumer = 3;
    private readonly int _numberToGuess;
    private List<Attempt> _attempts = new List<Attempt>();

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
            return LOSE;

        var attempt = CreateNewAttempt(guessedNumber);
        _attempts.Add(attempt);

        if (attempt.IsSuccessful())
            return WIN;

        if (ExceededMaximumNumberOfAttempts())
            return LOSE;

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
        return _attempts.Count >= _maximumAttemptNumer;
    }
}