namespace RandomNumberKata;

public class NumberGenerator : INumberGenerator
{
    public static NumberGenerator New()
    {
        return new NumberGenerator();
    }

    public int GenerateNumber()
    {
        return new Random().Next(0, 10);
    }
}