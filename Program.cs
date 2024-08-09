
var random = new Random();
var diceRollResult = random.Next(1, 7);

Console.WriteLine($"What is value {diceRollResult}");
Console.ReadKey();

class Dice
{
    private const int sidesCount = 6;
    private readonly Random _random;

    public Dice(Random random)
    {
        _random = random;
    }


    public int Roll() => _random.Next(1, sidesCount + 1);

    public void Describe() => Console.WriteLine($"This is a dice with {sidesCount} sides");
}