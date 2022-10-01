namespace RandomNumberKata;

public class Attempt
{
    private readonly int _attempt;
    private readonly bool _isSuccessful;

    public Attempt(int attempt, bool isSuccessful)
    {
        _attempt = attempt;
        _isSuccessful = isSuccessful;
    }

    public static Attempt SusccessfullAttempt(int attempt)
    {
        return new Attempt(attempt, true);
    }

    public static Attempt BadAttempt(int attempt)
    {
        return new Attempt(attempt, false);
    }

    public bool IsSuccessful()
    {
        return _isSuccessful;
    }

    public int GuessedNumber()
    {
        return _attempt;
    }

    public string Recommendation(int numberToGuess)
    {
        if (GuessedNumber() > numberToGuess)
            return GuessingNumberGame.LOWER;
        
        return GuessingNumberGame.HIGHER;
    }
}